using System;
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
            UpdateStatus();
            if (!Directory.Exists(".\\storage"))
            {
                Directory.CreateDirectory(".\\storage");
            }
        }

        private void UpdateStatus()
        {
            Config config = Config.LoadConfig("config.dat");
            textBoxBackupDirectory.Text = config.BackupedFolder;
            if (!string.IsNullOrEmpty(config.BackupedFolder))
            {
                panelOptions.Enabled = true;
                panelControls.Enabled = true;
                LoadBackupOptions(config.BackupedFolder);
            }
        }

        #endregion

        #region backups managing

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
            if (comboBoxBackups.SelectedItem != null)
            {
                UpdateListView();
            }
            else
            {
                listViewBackups.Items.Clear();
            }
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

        // delete choosen backup
        private void ButtonDeleteBackup_Click(object sender, EventArgs e)
        {
            if (listViewBackups.SelectedItems.Count == 0)
            {
                return;
            }
            string selected = listViewBackups.SelectedItems[0].Text.Replace(':','-');

            // removing selected backup
            Directory.Delete(".\\storage\\" + comboBoxBackups.SelectedItem + "\\" + selected, true);
            BackupData data = BackupData.ReadBackupData(".\\storage\\" + comboBoxBackups.SelectedItem + "\\backups.dat");
            // find first date corresponding with selected date and delete it
            for(int i = 0; i < data.Backups.Count; i++)
            {
                // parsing string format date to usual date and find the same date
                if (data.Backups[i].ToString().Equals(DateTime.ParseExact(selected, "dd.MM.yyyy HH-mm-ss", null).ToString()))
                {
                    data.Backups.RemoveAt(i);
                    break;
                }
            }
            // save changed data
            BackupData.SaveBackupData(data, ".\\storage\\" + comboBoxBackups.SelectedItem + "\\backups.dat");
            // remove deleted backup from list view
            listViewBackups.Items.Remove(listViewBackups.SelectedItems[0]);
            }

        // delete original directory and replace it with backup files
        private void ButtonReplace_Click(object sender, EventArgs e)
        {
            if (listViewBackups.SelectedItems.Count == 0)
            {
                return;
            }
            BackupData data = BackupData.ReadBackupData(".\\storage\\" + comboBoxBackups.SelectedItem + "\\backups.dat");
            try
            {
                Directory.Delete(data.OriginalPath, true);
            }
            catch (DirectoryNotFoundException) { }
            DirectoryUtil.DirectoryCopy(".\\storage\\" + comboBoxBackups.SelectedItem + "\\"
                + listViewBackups.SelectedItems[0].Text.Replace(':','-'), data.OriginalPath, true);

            MessageBox.Show("The original was successfully replaced by a backup");
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

        #region backup timer



        #endregion

        #region Backup choosing and making

        // set backup path
        private void ButtonBackupPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxBackupDirectory.Text))
            {
                UpdateBackupOptions(".\\storage\\" + DirectoryUtil.GetDirectoryName(textBoxBackupDirectory.Text)
                + "\\backups.dat");
            }
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
                    LoadBackupOptions(folderDialog.SelectedPath);
                }
            }
        }

        private void LoadBackupOptions(string path)
        {
            if (!Directory.Exists(".\\storage\\" + DirectoryUtil.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(".\\storage\\" + DirectoryUtil.GetDirectoryName(path));
            }
            BackupData data = BackupData.ReadBackupData(".\\storage\\"
                       + DirectoryUtil.GetDirectoryName(path) + "\\backups.dat");
            checkBoxBackupsAmount.Checked = data.CustomBackupsEnabled;
            numericUpDownBackupsAmount.Value = data.BackupsAmount;
            checkBoxTimer.Checked = data.TimerEnabled;
            numericUpDownTimer.Value = data.TimerDelay;
        }

        private void UpdateBackupOptions(string backupPath)
        {
            BackupData data = BackupData.ReadBackupData(backupPath);
            data.CustomBackupsEnabled = checkBoxBackupsAmount.Checked;
            data.BackupsAmount = (int)numericUpDownBackupsAmount.Value;
            data.TimerEnabled = checkBoxTimer.Checked;
            data.TimerDelay = (int)numericUpDownTimer.Value;
            BackupData.SaveBackupData(data, backupPath);
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
            data.OriginalPath = textBoxBackupDirectory.Text;

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
            DirectoryUtil.DirectoryCopy(data.OriginalPath, backupPath + "\\" + now.ToString().Replace(':', '-'), true);
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
            config.AutoStart = checkBoxAutoStart.Checked;
            Config.SaveConfig(config, "config.dat");
            UpdateBackupOptions(".\\storage\\" + DirectoryUtil.GetDirectoryName(textBoxBackupDirectory.Text)
                + "\\backups.dat");
        }

        #endregion
    }
}
