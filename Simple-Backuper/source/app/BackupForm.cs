using Simple_Backuper.domain;
using Simple_Backuper.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Simple_Backuper.app
{
    public partial class BackupForm : Form
    {
        #region vars

        private AppData data;
        private Dictionary<string, Thread> workingTimers;

        private string mainSelectedBackup;
        private string managingSelectedBackup;

        // this var is needed to update values after changing the backup
        private bool optionsUpdateDisabled;

        #endregion

        #region Initializtion

        public BackupForm()
        {
            InitializeComponent();
            if (!Directory.Exists(".\\storage"))
            {
                Directory.CreateDirectory(".\\storage");
            }
            // get app data from file
            data = AppDataUtil.ReadAppData(Config.DATA_PATH);
            workingTimers = new Dictionary<string, Thread>();
            optionsUpdateDisabled = false;
            // fill main combobox with names
            foreach(Backup backup in data.Backups)
            {
                comboBoxBackups.Items.Add(backup.Name);
                comboBoxBackupsManaging.Items.Add(backup.Name);
            }
        }

        #endregion

        #region Backups configuring and selecting

        // adding new folder to manage
        private void ButtonAddBackup_Click(object sender, EventArgs e)
        {
            // get backup folder path
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder to backup its content.\r\n"
                    + "\r\nPath should contain only latin characters.";
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(folderDialog.SelectedPath))
                {
                    Backup backup = new Backup();
                    backup.Name = DirectoryUtil.GetDirectoryName(folderDialog.SelectedPath);
                    backup.SourcePath = folderDialog.SelectedPath;
                    AddBackup(backup);
                    SwitchToBackup(backup.Name);
                }
            }
        }

        // when user selects the item for the first time the option panel unlocks
        private void ComboBoxBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!panelOptions.Enabled || !panelControls.Enabled)
            {
                panelOptions.Enabled = true;
                panelControls.Enabled = true;
            }
            mainSelectedBackup = comboBoxBackups.SelectedItem.ToString();
            SwitchOptionsTabToBackupOptions(mainSelectedBackup);
        }

        private void SwitchOptionsTabToBackupOptions(string backupName)
        {
            // disable option saving after each change
            optionsUpdateDisabled = true;
            Backup backup = data.GetBackup(backupName);
            // update fields
            checkBoxBackupsAmount.Checked = backup.CustomAmountEnabled;
            checkBoxTimer.Checked = backup.TimerEnabled;
            numericUpDownBackupsAmount.Value = backup.CustomAmount;
            numericUpDownTimer.Value = backup.TimerDelay;
            // check if backup have working timer
            if (workingTimers.ContainsKey(backupName))
            {
                buttonStartBackuping.Enabled = false;
                buttonStopBackuping.Enabled = true;
            }
            else
            {
                buttonStartBackuping.Enabled = checkBoxTimer.Enabled ? true : false;
                buttonStopBackuping.Enabled = false;
            }
            // enable option saving back
            optionsUpdateDisabled = false;
        }

        private void CheckBoxBackupsAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackupsAmount.Checked)
            {
                numericUpDownBackupsAmount.Enabled = true;
                labelAmount.Enabled = true;
            }
            else
            {
                labelAmount.Enabled = false;
                numericUpDownBackupsAmount.Enabled = false;
                numericUpDownBackupsAmount.Value = 5;
            }
            UpdateBackupOptions(mainSelectedBackup);
        }

        private void CheckBoxTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTimer.Checked)
            {
                numericUpDownTimer.Enabled = true;
                labelTimer.Enabled = true;
                buttonStartBackuping.Enabled = true;
            }
            else
            {
                labelTimer.Enabled = false;
                numericUpDownTimer.Enabled = false;
                numericUpDownTimer.Value = 15;
                buttonStartBackuping.Enabled = false;
            }
            UpdateBackupOptions(mainSelectedBackup);
        }

        private void CheckBoxAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoStart.Checked)
            {
                labelBoot.Enabled = true;
            }
            else
            {
                labelBoot.Enabled = false;
            }
            UpdateBackupOptions(mainSelectedBackup);
        }

        private void NumericUpDowns_ValueChanged(object sender, EventArgs e)
        {
            UpdateBackupOptions(mainSelectedBackup);
        }

        #endregion

        #region backup Timer

        private void ButtonStartBackuping_Click(object sender, EventArgs e)
        {
            // get backup name
            string backupName = mainSelectedBackup;
            UpdateBackupOptions(backupName);
            // create new timer thread
            Thread backupCycle = new Thread(new ParameterizedThreadStart(StartTimerCycle));
            // add thread to working threads list and start it
            workingTimers.Add(backupName, backupCycle);
            backupCycle.Start(backupName);
            // switch buttons
            buttonStartBackuping.Enabled = false;
            buttonStopBackuping.Enabled = true;
        }

        // method using in separate thread to backup directories
        private void StartTimerCycle(object backupName)
        {
            while (true)
            {
                string name = (string)backupName;
                Backup backup = data.GetBackup(name);
                Thread.Sleep(backup.TimerDelay * 1000);
                if (!backup.TimerEnabled)
                {
                    Thread.CurrentThread.Abort();
                    workingTimers.Remove(name);
                    break;
                }
                CreateBackupStamp(name);
            }
        }

        private void ButtonStopBackuping_Click(object sender, EventArgs e)
        {
            string backupName = mainSelectedBackup;
            try
            {
                // stop timer thread
                workingTimers[backupName].Abort();
            }
            catch (Exception) { }
            // remove thread from list of working timers
            workingTimers.Remove(backupName);
            // switch buttons
            buttonStartBackuping.Enabled = true;
            buttonStopBackuping.Enabled = false;
        }

        #endregion

        #region Backups managing

        // when user switch backup on managing tab
        private void ComboBoxBackupsManaging_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!panelBackupManage.Enabled) {
                panelBackupManage.Enabled = true;
            }
            managingSelectedBackup = comboBoxBackupsManaging.SelectedItem.ToString();
            UpdateListView();
        }

        // create Backup of choosen directory according to the config
        private void ButtonCreateBackupStamp_Click(object sender, EventArgs e)
        {
            CreateBackupStamp(managingSelectedBackup);
        }

        // delete choosen backup
        private void ButtonDeleteBackupStamp_Click(object sender, EventArgs e)
        {
            if (listViewBackups.SelectedItems.Count == 0)
            {
                return;
            }
            string selectedStamp = listViewBackups.SelectedItems[0].Text;
            DeleteBackupStamp(managingSelectedBackup, selectedStamp);
        }

        // delete original directory and replace it with backup files
        private void ButtonReplaceSourceWithStamp_Click(object sender, EventArgs e)
        {
            if (listViewBackups.SelectedItems.Count == 0)
            {
                return;
            }
            string selectedStamp = listViewBackups.SelectedItems[0].Text;
            ReplaceSourceWithStamp(managingSelectedBackup, selectedStamp);
            MessageBox.Show("Source replaced successfully");
        }

        // updates list view according to selected backup
        private void UpdateListView()
        {
            if (string.IsNullOrEmpty(managingSelectedBackup))
            {
                return;
            }
            Backup selected = data.GetBackup(managingSelectedBackup);
            // if have access from another thread
            if (InvokeRequired)
            {
                Invoke(new Action(listViewBackups.Items.Clear));
                foreach(string dateStr in selected.StampsList)
                {
                    Invoke(new Action<string>(x => listViewBackups.Items.Add(x)), new Object[] { dateStr });
                }
                return;
            }
            listViewBackups.Items.Clear();
            foreach (string dateStr in selected.StampsList)
            {
                listViewBackups.Items.Add(dateStr);
            }
        }

        #endregion

        #region Util

        private void AddBackup(Backup backup)
        {
            data.Backups.Add(backup);
            comboBoxBackups.Items.Add(backup.Name);
            comboBoxBackupsManaging.Items.Add(backup.Name);
        }

        // create new time stamped version of backup
        private void CreateBackupStamp(string backupName)
        {
            string backupPath = Config.STORAGE_PATH + "\\" + backupName;
            Directory.CreateDirectory(backupPath);

            // get string of current time to name stamp
            string currentTimeStr = DateTime.Now.ToString().Replace(':', '-');
            Backup backup = data.GetBackup(backupName);
            if (backup.StampsList.Contains(currentTimeStr))
            {
                MessageBox.Show(null, "Wait at least one second before creataing next backup stamp!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check if backup stamps limit excessed
            if (backup.StampsList.Count < backup.CustomAmount)
            {
                backup.StampsList.Add(currentTimeStr);
            }
            else
            {
                // find min (by creation time) stamp among all
                string stampToReplace = backup.StampsList.OrderBy(strTime
                    => DateTime.ParseExact(strTime, "dd.MM.yyyy HH-mm-ss", null).Ticks).First();
                // delete previous backup
                Directory.Delete(backupPath + "\\" + stampToReplace, true);
                // replace previous stamp
                backup.StampsList[backup.StampsList.IndexOf(stampToReplace)] = currentTimeStr;
            }
            // copy source directory to backup directory named by time
            DirectoryUtil.DirectoryCopy(backup.SourcePath, backupPath + "\\" + currentTimeStr, true);
            UpdateListView();
        }

        private void DeleteBackupStamp(string backupName, string stamp)
        {
            Backup backup = data.GetBackup(backupName);
            // removing selected backup
            Directory.Delete(Config.STORAGE_PATH + "\\" + backupName + "\\" + stamp, true);
            // find selected stamp and delete it
            backup.StampsList.Remove(stamp);
            // remove deleted backup from list view
            listViewBackups.Items.Remove(listViewBackups.SelectedItems[0]);
            UpdateListView();
        }

        private void ReplaceSourceWithStamp(string backupName, string stamp)
        {
            Backup backup = data.GetBackup(backupName);
            // recursively delete the source (also ignore if it doesn't exist)
            try
            {
                Directory.Delete(backup.SourcePath, true);
            }
            catch (DirectoryNotFoundException) { }
            // copy stamp to the source
            DirectoryUtil.DirectoryCopy(Config.STORAGE_PATH + "\\" + backupName 
                + "\\" + stamp, backup.SourcePath, true);
            UpdateListView();
        }

        // Switch first tab to the particular backup
        private void SwitchToBackup(string backupName)
        {
            Backup selected = new Backup();
            // find backup with given name in data
            foreach(Backup backup in data.Backups)
            {
                if (backup.Name.Equals(backupName))
                {
                    selected = backup;
                    break;
                }
            }
            // switch tab options to backup options
            comboBoxBackups.SelectedIndex = comboBoxBackups.Items.IndexOf(backupName);
            checkBoxBackupsAmount.Checked = selected.CustomAmountEnabled;
            checkBoxTimer.Checked = selected.TimerEnabled;
            numericUpDownBackupsAmount.Value = selected.CustomAmount;
            numericUpDownTimer.Value = selected.TimerDelay;
            // switch buttons according to work of timers
            if (workingTimers.ContainsKey(backupName))
            {
                buttonStartBackuping.Enabled = false;
                buttonStopBackuping.Enabled = true;
            }
            else
            {
                buttonStartBackuping.Enabled = checkBoxTimer.Checked ? true : false;
                buttonStopBackuping.Enabled = false;
            }
        }

        // update selected backup with tab options
        private void UpdateBackupOptions(string backupName)
        {
            if (optionsUpdateDisabled)
            {
                return;
            }
            Backup backup = data.GetBackup(backupName);
            backup.CustomAmountEnabled = checkBoxBackupsAmount.Checked;
            backup.TimerEnabled = checkBoxTimer.Checked;
            backup.CustomAmount = (int)numericUpDownBackupsAmount.Value;
            backup.TimerDelay = (int)numericUpDownTimer.Value;
        }

        #endregion

        #region Exit

        // save config on closure
        private void BackupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Thread thread in workingTimers.Values)
            {
                try
                {
                    thread.Abort();
                }
                catch (Exception) { }
            }
            workingTimers.Clear();
            AppDataUtil.SaveAppData(data, Config.DATA_PATH);
        }

        #endregion
    }
}
