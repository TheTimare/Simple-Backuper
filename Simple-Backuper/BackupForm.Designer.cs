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
            this.buttonStoragePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBackupStorage = new System.Windows.Forms.TextBox();
            this.numericUpDownBackupsAmount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBackupsAmount = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxTimer = new System.Windows.Forms.CheckBox();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.Backups = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxBackups = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonDeleteBackup = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupsAmount)).BeginInit();
            this.OptionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            this.Backups.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBackupDirectory
            // 
            this.textBoxBackupDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxBackupDirectory.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBackupDirectory.Location = new System.Drawing.Point(4, 29);
            this.textBoxBackupDirectory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxBackupDirectory.Multiline = true;
            this.textBoxBackupDirectory.Name = "textBoxBackupDirectory";
            this.textBoxBackupDirectory.ReadOnly = true;
            this.textBoxBackupDirectory.Size = new System.Drawing.Size(340, 32);
            this.textBoxBackupDirectory.TabIndex = 0;
            this.textBoxBackupDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Directory to Backup";
            // 
            // buttonBackupPath
            // 
            this.buttonBackupPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackupPath.Location = new System.Drawing.Point(343, 29);
            this.buttonBackupPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBackupPath.Name = "buttonBackupPath";
            this.buttonBackupPath.Size = new System.Drawing.Size(119, 32);
            this.buttonBackupPath.TabIndex = 2;
            this.buttonBackupPath.Text = "Choose Path";
            this.buttonBackupPath.UseVisualStyleBackColor = false;
            // 
            // buttonStoragePath
            // 
            this.buttonStoragePath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStoragePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStoragePath.Location = new System.Drawing.Point(343, 90);
            this.buttonStoragePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStoragePath.Name = "buttonStoragePath";
            this.buttonStoragePath.Size = new System.Drawing.Size(119, 32);
            this.buttonStoragePath.TabIndex = 5;
            this.buttonStoragePath.Text = "Choose Path";
            this.buttonStoragePath.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Backup Storage";
            // 
            // textBoxBackupStorage
            // 
            this.textBoxBackupStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxBackupStorage.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBackupStorage.Location = new System.Drawing.Point(4, 90);
            this.textBoxBackupStorage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxBackupStorage.Multiline = true;
            this.textBoxBackupStorage.Name = "textBoxBackupStorage";
            this.textBoxBackupStorage.ReadOnly = true;
            this.textBoxBackupStorage.Size = new System.Drawing.Size(340, 32);
            this.textBoxBackupStorage.TabIndex = 3;
            this.textBoxBackupStorage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownBackupsAmount
            // 
            this.numericUpDownBackupsAmount.Enabled = false;
            this.numericUpDownBackupsAmount.Location = new System.Drawing.Point(321, 23);
            this.numericUpDownBackupsAmount.Name = "numericUpDownBackupsAmount";
            this.numericUpDownBackupsAmount.Size = new System.Drawing.Size(120, 31);
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
            this.checkBoxBackupsAmount.Size = new System.Drawing.Size(229, 27);
            this.checkBoxBackupsAmount.TabIndex = 2;
            this.checkBoxBackupsAmount.Text = "Custom Backups Amount";
            this.checkBoxBackupsAmount.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(26, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Choose new max backups amount";
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsPanel.Controls.Add(this.checkBoxBackupsAmount);
            this.OptionsPanel.Controls.Add(this.numericUpDownBackupsAmount);
            this.OptionsPanel.Controls.Add(this.label4);
            this.OptionsPanel.Location = new System.Drawing.Point(0, 35);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(458, 64);
            this.OptionsPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxTimer);
            this.panel1.Controls.Add(this.numericUpDownTimer);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 64);
            this.panel1.TabIndex = 7;
            // 
            // checkBoxTimer
            // 
            this.checkBoxTimer.AutoSize = true;
            this.checkBoxTimer.Location = new System.Drawing.Point(3, 3);
            this.checkBoxTimer.Name = "checkBoxTimer";
            this.checkBoxTimer.Size = new System.Drawing.Size(139, 27);
            this.checkBoxTimer.TabIndex = 2;
            this.checkBoxTimer.Text = "Backup Timer";
            this.checkBoxTimer.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Enabled = false;
            this.numericUpDownTimer.Location = new System.Drawing.Point(321, 23);
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
            this.numericUpDownTimer.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownTimer.TabIndex = 0;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(26, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choose timer delay (minutes)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.OptionsPanel);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(4, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 240);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.checkBoxAutoStart);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(0, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 64);
            this.panel3.TabIndex = 8;
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(184, 27);
            this.checkBoxAutoStart.TabIndex = 2;
            this.checkBoxAutoStart.Text = "Start With Windows";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(26, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "The application starts with Windows boot";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Make Backup";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(165, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "Start Backuping";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(309, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Stop Backuping";
            this.button3.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.Backups);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 500);
            this.tabControl1.TabIndex = 13;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.panel4);
            this.Main.Controls.Add(this.label1);
            this.Main.Controls.Add(this.textBoxBackupDirectory);
            this.Main.Controls.Add(this.buttonBackupPath);
            this.Main.Controls.Add(this.textBoxBackupStorage);
            this.Main.Controls.Add(this.panel2);
            this.Main.Controls.Add(this.label2);
            this.Main.Controls.Add(this.buttonStoragePath);
            this.Main.Location = new System.Drawing.Point(4, 32);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(479, 464);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // Backups
            // 
            this.Backups.Controls.Add(this.buttonReplace);
            this.Backups.Controls.Add(this.buttonDeleteBackup);
            this.Backups.Controls.Add(this.listView1);
            this.Backups.Controls.Add(this.comboBoxBackups);
            this.Backups.Controls.Add(this.label8);
            this.Backups.Location = new System.Drawing.Point(4, 32);
            this.Backups.Name = "Backups";
            this.Backups.Padding = new System.Windows.Forms.Padding(3);
            this.Backups.Size = new System.Drawing.Size(479, 464);
            this.Backups.TabIndex = 1;
            this.Backups.Text = "Backups";
            this.Backups.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(4, 372);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 83);
            this.panel4.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Select Backup";
            // 
            // comboBoxBackups
            // 
            this.comboBoxBackups.FormattingEnabled = true;
            this.comboBoxBackups.Location = new System.Drawing.Point(152, 6);
            this.comboBoxBackups.Name = "comboBoxBackups";
            this.comboBoxBackups.Size = new System.Drawing.Size(287, 31);
            this.comboBoxBackups.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(32, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(407, 369);
            this.listView1.TabIndex = 2;
            this.listView1.TileSize = new System.Drawing.Size(328, 50);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // buttonDeleteBackup
            // 
            this.buttonDeleteBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteBackup.Location = new System.Drawing.Point(32, 418);
            this.buttonDeleteBackup.Name = "buttonDeleteBackup";
            this.buttonDeleteBackup.Size = new System.Drawing.Size(126, 36);
            this.buttonDeleteBackup.TabIndex = 3;
            this.buttonDeleteBackup.Text = "Delete";
            this.buttonDeleteBackup.UseVisualStyleBackColor = true;
            // 
            // buttonReplace
            // 
            this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReplace.Location = new System.Drawing.Point(157, 418);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(282, 36);
            this.buttonReplace.TabIndex = 4;
            this.buttonReplace.Text = "Replace Original With Backup";
            this.buttonReplace.UseVisualStyleBackColor = true;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(484, 499);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BackupForm";
            this.Text = "Simple Backuper";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBackupsAmount)).EndInit();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            this.Backups.ResumeLayout(false);
            this.Backups.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBackupDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBackupPath;
        private System.Windows.Forms.Button buttonStoragePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBackupStorage;
        private System.Windows.Forms.NumericUpDown numericUpDownBackupsAmount;
        private System.Windows.Forms.CheckBox checkBoxBackupsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxTimer;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.TabPage Backups;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBackups;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonDeleteBackup;
    }
}

