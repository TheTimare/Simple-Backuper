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

        #region tab updating 

        private void TabControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.TabIndex == 1)
            {
                UpdateBackupsList();
            }
        }

        private void UpdateBackupsList()
        {

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
