using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Backuper
{
    public partial class BackupForm : Form
    {
        public BackupForm()
        {
            InitializeComponent();

            Config config = LoadConfig();
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

        // saves config file to the .exe directory
        private void SaveConfig()
        {
            using (FileStream fs = new FileStream("config.dat", FileMode.Create))
            {
                Config config = new Config();
                config.BackupedFolder = textBoxBackupDirectory.Text;
                config.CustomBackupsEnabled = checkBoxBackupsAmount.Checked;
                config.BackupsAmount = (int)numericUpDownBackupsAmount.Value;
                config.TimerEnabled = checkBoxTimer.Checked;
                config.TimerDelay = (int)numericUpDownTimer.Value;

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, config);
            }
        }
        private Config LoadConfig()
        {
            using (FileStream fs = new FileStream("config.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Config config = (Config)formatter.Deserialize(fs);
                    return config;
                }
                catch(Exception)
                {
                    return new Config();
                }
            }
        }

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

        #region Check boxes

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

        private void ButtonMakeBackup_Click(object sender, EventArgs e)
        {
            string[] splittedPath = textBoxBackupDirectory.Text.Split('\\');
            string backupName = splittedPath[splittedPath.Count() - 1];
            string backupPath = Application.StartupPath + "\\storage\\" + backupName;
            Directory.CreateDirectory(backupPath);

        }

        private void ReadBackups(string path)
        {

        }

        #endregion

        // save config on closure
        private void BackupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveConfig();
        }
    }
}
