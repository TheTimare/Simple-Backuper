using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Simple_Backuper
{
    public partial class BackupForm : Form
    {
        #region initializtion

        public BackupForm()
        {
            InitializeComponent();
            UpdateConfig();
        }

        private void UpdateConfig()
        {
            Config config = Config.LoadConfig("config.dat");
            textBoxBackupDirectory.Text = config.BackupedFolder;
            if (!string.IsNullOrEmpty(config.BackupedFolder))
            {
                panelOptions.Enabled = true;
                panelControls.Enabled = true;
            }
            checkBoxBackupsAmount.Checked = config.CustomBackupsEnabled;
            numericUpDownBackupsAmount.Value = config.BackupsAmount;
            checkBoxTimer.Checked = config.TimerEnabled;
            numericUpDownTimer.Value = config.TimerDelay;
        }

        #endregion

        #region backups list

        // update backup list when user goes to the second tab
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                UpdateBackupsList();
            }
        }

        private void UpdateBackupsList()
        {
            string[] backups = Directory.GetDirectories(".\\storage");
            for(int i = 0; i < backups.Length; i++)
            {
                string[] splittedPath = backups[i].Split('\\');
                backups[i] = splittedPath[splittedPath.Length - 1];
            }

            // if one of values is changed, than update the list
            bool needUpdate = false;
            foreach(string backup in backups)
            {
                if (!comboBoxBackups.Items.Contains(backup))
                {
                    needUpdate = true;
                    break;
                }
            }
            if (needUpdate)
            { 
                comboBoxBackups.Items.Clear();
                comboBoxBackups.Items.AddRange(backups);
            }
        }

        // when user switch backup in combobox
        private void ComboBoxBackups_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!panelBackupManage.Enabled) {
                panelBackupManage.Enabled = true;
            }
            UpdateListView();
        }

        // update list view after users visit to another tab
        private void ListViewBackups_VisibleChanged(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            string dataPath = ".\\storage\\" + comboBoxBackups.SelectedItem + "\\backups.dat";
            BackupData data = BackupData.ReadBackupData(dataPath);

            listViewBackups.Items.Clear();
            foreach (DateTime date in data.Backups)
            {
                listViewBackups.Items.Add(date.ToString());
            }
        }



        #endregion

        #region Check boxes changing

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
        }

        #endregion

        #region Backup making

        // set backup path
        private void ButtonBackupPath_Click(object sender, EventArgs e)
        {
            // get backup folder path
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder to backup its content.\r\n"
                    + "\r\nPath should contain only latin characters.";
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(folderDialog.SelectedPath))
                {
                    textBoxBackupDirectory.Text = folderDialog.SelectedPath;
                    panelOptions.Enabled = true;
                    panelControls.Enabled = true;
                }
            }
        }

        // create Backup of choosen directory according to the config
        private void ButtonMakeBackup_Click(object sender, EventArgs e)
        {
            CreateBackup();
            MessageBox.Show("Backup created successfully");
        }

        private void CreateBackup()
        {
            // get backup directory name
            string[] splittedPath = textBoxBackupDirectory.Text.Split('\\');
            string backupName = splittedPath[splittedPath.Count() - 1];
            // build path to backups storage
            string backupPath = Application.StartupPath + "\\storage\\" + backupName;
            Directory.CreateDirectory(backupPath);

            // read previous backups data
            BackupData data = BackupData.ReadBackupData(backupPath + "\\backups.dat");
            data.BackupPath = textBoxBackupDirectory.Text;

            // check if backups limit excessed
            DateTime now = DateTime.Now;
            if (data.Backups.Count() < numericUpDownBackupsAmount.Value)
            {
                data.Backups.Add(now);
            }
            else
            {
                // find min datetime among all backups
                DateTime timeToReplace = data.Backups.OrderBy(time => time.Ticks).First();
                // delete previous backup
                Directory.Delete(backupPath + "\\" + timeToReplace.ToString().Replace(':', '-'), true);
                data.Backups[data.Backups.IndexOf(timeToReplace)] = now;
            }
            // copy source directory to backup directory named by time
            DirectoryUtil.DirectoryCopy(data.BackupPath, backupPath + "\\" + now.ToString().Replace(':', '-'), true);
            // update backup data
            BackupData.SaveBackupData(data, backupPath + "\\backups.dat");
        }

        #endregion

        #region exiting

        // save config on closure
        private void BackupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config config = new Config();
            config.BackupedFolder = textBoxBackupDirectory.Text;
            config.CustomBackupsEnabled = checkBoxBackupsAmount.Checked;
            config.BackupsAmount = (int)numericUpDownBackupsAmount.Value;
            config.TimerEnabled = checkBoxTimer.Checked;
            config.TimerDelay = (int)numericUpDownTimer.Value;

            Config.SaveConfig(config, "config.dat");
        }


        #endregion
    }
}
