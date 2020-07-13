namespace Simple_Backuper
{
    partial class BackupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.textBoxBackupDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBackupPath = new System.Windows.Forms.Button();
            this.numericUpDownBackupsAmount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBackupsAmount = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panelBackupsAmount = new System.Windows.Forms.Panel();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.labelTimer = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelStartWithWindow = new System.Windows.Forms.Panel();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.labelBoot = new System.Windows.Forms.Label();
            this.buttonMakeBackup = new System.Windows.Forms.Button();
            this.buttonStartBackuping = new System.Windows.Forms.Button();
            this.buttonStopBackuping = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.panelControls = new System.Windows.Forms.Panel();
            this.Backups = new System.Windows.Forms.TabPage();
            this.panelBackupManage = new System.Windows.Forms.Panel();
            this.listViewBackups = new System.Windows.Forms.ListView();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonDeleteBackup = new System.Windows.Forms.Button();
            this.comboBoxBackups = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupsAmount)).BeginInit();
            this.panelBackupsAmount.SuspendLayout();
            this.panelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.panelStartWithWindow.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Main.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.Backups.SuspendLayout();
            this.panelBackupManage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBackupDirectory
            // 
            this.textBoxBackupDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxBackupDirectory.Font = new System.Drawing.Font("Open Sans Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBackupDirectory.Location = new System.Drawing.Point(8, 29);
            this.textBoxBackupDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxBackupDirectory.Multiline = true;
            this.textBoxBackupDirectory.Name = "textBoxBackupDirectory";
            this.textBoxBackupDirectory.ReadOnly = true;
            this.textBoxBackupDirectory.Size = new System.Drawing.Size(306, 32);
            this.textBoxBackupDirectory.TabIndex = 0;
            this.textBoxBackupDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory to Backup";
            // 
            // buttonBackupPath
            // 
            this.buttonBackupPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackupPath.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackupPath.Location = new System.Drawing.Point(313, 29);
            this.buttonBackupPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBackupPath.Name = "buttonBackupPath";
            this.buttonBackupPath.Size = new System.Drawing.Size(107, 32);
            this.buttonBackupPath.TabIndex = 2;
            this.buttonBackupPath.Text = "Choose Path";
            this.buttonBackupPath.UseVisualStyleBackColor = false;
            this.buttonBackupPath.Click += new System.EventHandler(this.ButtonBackupPath_Click);
            // 
            // numericUpDownBackupsAmount
            // 
            this.numericUpDownBackupsAmount.Enabled = false;
            this.numericUpDownBackupsAmount.Location = new System.Drawing.Point(296, 23);
            this.numericUpDownBackupsAmount.Name = "numericUpDownBackupsAmount";
            this.numericUpDownBackupsAmount.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownBackupsAmount.TabIndex = 0;
            this.numericUpDownBackupsAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkBoxBackupsAmount
            // 
            this.checkBoxBackupsAmount.AutoSize = true;
            this.checkBoxBackupsAmount.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBackupsAmount.Name = "checkBoxBackupsAmount";
            this.checkBoxBackupsAmount.Size = new System.Drawing.Size(225, 27);
            this.checkBoxBackupsAmount.TabIndex = 2;
            this.checkBoxBackupsAmount.Text = "Custom Backups Amount";
            this.checkBoxBackupsAmount.UseVisualStyleBackColor = true;
            this.checkBoxBackupsAmount.CheckedChanged += new System.EventHandler(this.CheckBoxBackupsAmount_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Options";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Enabled = false;
            this.labelAmount.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmount.Location = new System.Drawing.Point(23, 31);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(270, 23);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "Choose new max backups amount";
            // 
            // panelBackupsAmount
            // 
            this.panelBackupsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackupsAmount.Controls.Add(this.checkBoxBackupsAmount);
            this.panelBackupsAmount.Controls.Add(this.numericUpDownBackupsAmount);
            this.panelBackupsAmount.Controls.Add(this.labelAmount);
            this.panelBackupsAmount.Location = new System.Drawing.Point(0, 35);
            this.panelBackupsAmount.Name = "panelBackupsAmount";
            this.panelBackupsAmount.Size = new System.Drawing.Size(412, 64);
            this.panelBackupsAmount.TabIndex = 6;
            // 
            // panelTimer
            // 
            this.panelTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimer.Controls.Add(this.checkBoxTimer);
            this.panelTimer.Controls.Add(this.numericUpDownTimer);
            this.panelTimer.Controls.Add(this.labelTimer);
            this.panelTimer.Location = new System.Drawing.Point(0, 105);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(412, 64);
            this.panelTimer.TabIndex = 7;
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Location = new System.Drawing.Point(3, 3);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(136, 27);
            this.checkBoxTimer.TabIndex = 2;
            this.checkBoxTimer.Text = "Backup Timer";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            this.checkBoxTimer.CheckedChanged += new System.EventHandler(this.CheckBoxTimer_CheckedChanged);
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Enabled = false;
            this.numericUpDownTimer.Location = new System.Drawing.Point(296, 23);
            this.numericUpDownTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownTimer.TabIndex = 0;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Enabled = false;
            this.labelTimer.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(23, 31);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(233, 23);
            this.labelTimer.TabIndex = 4;
            this.labelTimer.Text = "Choose timer delay (minutes)";
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.panelStartWithWindow);
            this.panelOptions.Controls.Add(this.label3);
            this.panelOptions.Controls.Add(this.panelTimer);
            this.panelOptions.Controls.Add(this.panelBackupsAmount);
            this.panelOptions.Enabled = false;
            this.panelOptions.Location = new System.Drawing.Point(8, 91);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(412, 240);
            this.panelOptions.TabIndex = 8;
            // 
            // panelStartWithWindow
            // 
            this.panelStartWithWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartWithWindow.Controls.Add(this.checkBoxAutoStart);
            this.panelStartWithWindow.Controls.Add(this.labelBoot);
            this.panelStartWithWindow.Location = new System.Drawing.Point(0, 175);
            this.panelStartWithWindow.Name = "panelStartWithWindow";
            this.panelStartWithWindow.Size = new System.Drawing.Size(412, 64);
            this.panelStartWithWindow.TabIndex = 8;
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Enabled = false;
            this.checkBoxAutoStart.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(323, 27);
            this.checkBoxAutoStart.TabIndex = 2;
            this.checkBoxAutoStart.Text = "Start With Windows (Not working now)";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxAutoStart.CheckedChanged += new System.EventHandler(this.CheckBoxAutoStart_CheckedChanged);
            // 
            // labelBoot
            // 
            this.labelBoot.AutoSize = true;
            this.labelBoot.Enabled = false;
            this.labelBoot.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBoot.Location = new System.Drawing.Point(23, 31);
            this.labelBoot.Name = "labelBoot";
            this.labelBoot.Size = new System.Drawing.Size(323, 23);
            this.labelBoot.TabIndex = 4;
            this.labelBoot.Text = "The application starts with Windows boot";
            // 
            // buttonMakeBackup
            // 
            this.buttonMakeBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeBackup.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakeBackup.Location = new System.Drawing.Point(0, 31);
            this.buttonMakeBackup.Name = "buttonMakeBackup";
            this.buttonMakeBackup.Size = new System.Drawing.Size(122, 45);
            this.buttonMakeBackup.TabIndex = 9;
            this.buttonMakeBackup.Text = "Make Backup";
            this.buttonMakeBackup.UseVisualStyleBackColor = true;
            this.buttonMakeBackup.Click += new System.EventHandler(this.ButtonMakeBackup_Click);
            // 
            // buttonStartBackuping
            // 
            this.buttonStartBackuping.Enabled = false;
            this.buttonStartBackuping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartBackuping.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartBackuping.Location = new System.Drawing.Point(135, 31);
            this.buttonStartBackuping.Name = "buttonStartBackuping";
            this.buttonStartBackuping.Size = new System.Drawing.Size(140, 45);
            this.buttonStartBackuping.TabIndex = 10;
            this.buttonStartBackuping.Text = "Start Backuping";
            this.buttonStartBackuping.UseVisualStyleBackColor = true;
            // 
            // buttonStopBackuping
            // 
            this.buttonStopBackuping.Enabled = false;
            this.buttonStopBackuping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopBackuping.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStopBackuping.Location = new System.Drawing.Point(274, 31);
            this.buttonStopBackuping.Name = "buttonStopBackuping";
            this.buttonStopBackuping.Size = new System.Drawing.Size(138, 45);
            this.buttonStopBackuping.TabIndex = 11;
            this.buttonStopBackuping.Text = "Stop Backuping";
            this.buttonStopBackuping.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Controls";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Main);
            this.tabControl.Controls.Add(this.Backups);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(438, 500);
            this.tabControl.TabIndex = 13;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // Main
            // 
            this.Main.Controls.Add(this.panelControls);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.textBoxBackupDirectory);
            this.Main.Controls.Add(this.buttonBackupPath);
            this.Main.Controls.Add(this.panelOptions);
            this.Main.Location = new System.Drawing.Point(4, 32);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(430, 464);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.label7);
            this.panelControls.Controls.Add(this.buttonStartBackuping);
            this.panelControls.Controls.Add(this.buttonStopBackuping);
            this.panelControls.Controls.Add(this.buttonMakeBackup);
            this.panelControls.Enabled = false;
            this.panelControls.Location = new System.Drawing.Point(8, 372);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(412, 83);
            this.panelControls.TabIndex = 13;
            // 
            // Backups
            // 
            this.Backups.Controls.Add(this.panel1);
            this.Backups.Controls.Add(this.panelBackupManage);
            this.Backups.Controls.Add(this.label8);
            this.Backups.Location = new System.Drawing.Point(4, 32);
            this.Backups.Name = "Backups";
            this.Backups.Padding = new System.Windows.Forms.Padding(3);
            this.Backups.Size = new System.Drawing.Size(430, 464);
            this.Backups.TabIndex = 1;
            this.Backups.Text = "Backups";
            this.Backups.UseVisualStyleBackColor = true;
            // 
            // panelBackupManage
            // 
            this.panelBackupManage.Controls.Add(this.listViewBackups);
            this.panelBackupManage.Controls.Add(this.buttonReplace);
            this.panelBackupManage.Controls.Add(this.buttonDeleteBackup);
            this.panelBackupManage.Enabled = false;
            this.panelBackupManage.Location = new System.Drawing.Point(31, 42);
            this.panelBackupManage.Name = "panelBackupManage";
            this.panelBackupManage.Size = new System.Drawing.Size(381, 426);
            this.panelBackupManage.TabIndex = 5;
            // 
            // listViewBackups
            // 
            this.listViewBackups.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewBackups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewBackups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBackups.HideSelection = false;
            this.listViewBackups.Location = new System.Drawing.Point(0, 5);
            this.listViewBackups.MultiSelect = false;
            this.listViewBackups.Name = "listViewBackups";
            this.listViewBackups.Size = new System.Drawing.Size(367, 364);
            this.listViewBackups.TabIndex = 2;
            this.listViewBackups.TileSize = new System.Drawing.Size(328, 50);
            this.listViewBackups.UseCompatibleStateImageBehavior = false;
            this.listViewBackups.View = System.Windows.Forms.View.SmallIcon;
            this.listViewBackups.VisibleChanged += new System.EventHandler(this.ListViewBackups_VisibleChanged);
            // 
            // buttonReplace
            // 
            this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplace.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReplace.Location = new System.Drawing.Point(111, 375);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(256, 36);
            this.buttonReplace.TabIndex = 4;
            this.buttonReplace.Text = "Replace Original With Backup";
            this.buttonReplace.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBackup
            // 
            this.buttonDeleteBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBackup.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteBackup.Location = new System.Drawing.Point(0, 375);
            this.buttonDeleteBackup.Name = "buttonDeleteBackup";
            this.buttonDeleteBackup.Size = new System.Drawing.Size(113, 36);
            this.buttonDeleteBackup.TabIndex = 3;
            this.buttonDeleteBackup.Text = "Delete";
            this.buttonDeleteBackup.UseVisualStyleBackColor = true;
            // 
            // comboBoxBackups
            // 
            this.comboBoxBackups.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxBackups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBackups.FormattingEnabled = true;
            this.comboBoxBackups.Location = new System.Drawing.Point(-1, 3);
            this.comboBoxBackups.Name = "comboBoxBackups";
            this.comboBoxBackups.Size = new System.Drawing.Size(254, 31);
            this.comboBoxBackups.TabIndex = 1;
            this.comboBoxBackups.SelectedValueChanged += new System.EventHandler(this.ComboBoxBackups_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select Backup";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxBackups);
            this.panel1.Location = new System.Drawing.Point(144, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 38);
            this.panel1.TabIndex = 6;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(436, 496);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Open Sans Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BackupForm";
            this.Text = "Simple Backuper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupsAmount)).EndInit();
            this.panelBackupsAmount.ResumeLayout(false);
            this.panelBackupsAmount.PerformLayout();
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.panelStartWithWindow.ResumeLayout(false);
            this.panelStartWithWindow.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.Backups.ResumeLayout(false);
            this.Backups.PerformLayout();
            this.panelBackupManage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBackupDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBackupPath;
        private System.Windows.Forms.NumericUpDown numericUpDownBackupsAmount;
        private System.Windows.Forms.CheckBox checkBoxBackupsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Panel panelBackupsAmount;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelStartWithWindow;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.Label labelBoot;
        private System.Windows.Forms.Button buttonMakeBackup;
        private System.Windows.Forms.Button buttonStartBackuping;
        private System.Windows.Forms.Button buttonStopBackuping;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Backups;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBackups;
        private System.Windows.Forms.ListView listViewBackups;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonDeleteBackup;
        private System.Windows.Forms.Panel panelBackupManage;
        private System.Windows.Forms.Panel panel1;
    }
}

