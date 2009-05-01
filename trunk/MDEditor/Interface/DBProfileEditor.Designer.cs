using MDEditor.Interface.Attributes;

namespace MDEditor.Interface
{
    partial class DBProfileEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.i_accountSqlType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.i_accountDatabase = new System.Windows.Forms.TextBox();
            this.i_accountPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.i_accountUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.i_accountPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.i_accountHost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.i_worldSqlType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.i_worldDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.i_worldPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.i_worldUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.i_worldPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.i_worldHost = new System.Windows.Forms.TextBox();
            this.i_saveButton = new System.Windows.Forms.Button();
            this.i_connectButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.i_handle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.i_characterSqlType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.i_characterDatabase = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.i_characterPort = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.i_characterUsername = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.i_characterPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.i_characterHost = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_accountPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_worldPort)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_characterPort)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.i_accountSqlType);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.i_accountDatabase);
            this.groupBox2.Controls.Add(this.i_accountPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.i_accountUsername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.i_accountPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.i_accountHost);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 187);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Database";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 155);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "DB Type";
            // 
            // i_accountSqlType
            // 
            this.i_accountSqlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.i_accountSqlType.FormattingEnabled = true;
            this.i_accountSqlType.Location = new System.Drawing.Point(65, 152);
            this.i_accountSqlType.Name = "i_accountSqlType";
            this.i_accountSqlType.Size = new System.Drawing.Size(139, 21);
            this.i_accountSqlType.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Port";
            // 
            // i_accountDatabase
            // 
            this.i_accountDatabase.AcceptsReturn = true;
            this.i_accountDatabase.Location = new System.Drawing.Point(65, 45);
            this.i_accountDatabase.Name = "i_accountDatabase";
            this.i_accountDatabase.Size = new System.Drawing.Size(139, 20);
            this.i_accountDatabase.TabIndex = 14;
            // 
            // i_accountPort
            // 
            this.i_accountPort.Location = new System.Drawing.Point(65, 73);
            this.i_accountPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.i_accountPort.Name = "i_accountPort";
            this.i_accountPort.Size = new System.Drawing.Size(51, 20);
            this.i_accountPort.TabIndex = 2;
            this.i_accountPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // i_accountUsername
            // 
            this.i_accountUsername.Location = new System.Drawing.Point(65, 99);
            this.i_accountUsername.Name = "i_accountUsername";
            this.i_accountUsername.Size = new System.Drawing.Size(139, 20);
            this.i_accountUsername.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // i_accountPassword
            // 
            this.i_accountPassword.Location = new System.Drawing.Point(65, 125);
            this.i_accountPassword.Name = "i_accountPassword";
            this.i_accountPassword.Size = new System.Drawing.Size(139, 20);
            this.i_accountPassword.TabIndex = 4;
            this.i_accountPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Host";
            // 
            // i_accountHost
            // 
            this.i_accountHost.Location = new System.Drawing.Point(65, 14);
            this.i_accountHost.Name = "i_accountHost";
            this.i_accountHost.Size = new System.Drawing.Size(139, 20);
            this.i_accountHost.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.i_worldSqlType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.i_worldDatabase);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.i_worldPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.i_worldUsername);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.i_worldPassword);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.i_worldHost);
            this.groupBox1.Location = new System.Drawing.Point(228, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "World Database";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "DB Type";
            // 
            // i_worldSqlType
            // 
            this.i_worldSqlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.i_worldSqlType.FormattingEnabled = true;
            this.i_worldSqlType.Location = new System.Drawing.Point(65, 151);
            this.i_worldSqlType.Name = "i_worldSqlType";
            this.i_worldSqlType.Size = new System.Drawing.Size(139, 21);
            this.i_worldSqlType.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Database";
            // 
            // i_worldDatabase
            // 
            this.i_worldDatabase.AcceptsReturn = true;
            this.i_worldDatabase.Location = new System.Drawing.Point(65, 45);
            this.i_worldDatabase.Name = "i_worldDatabase";
            this.i_worldDatabase.Size = new System.Drawing.Size(139, 20);
            this.i_worldDatabase.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port";
            // 
            // i_worldPort
            // 
            this.i_worldPort.Location = new System.Drawing.Point(65, 73);
            this.i_worldPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.i_worldPort.Name = "i_worldPort";
            this.i_worldPort.Size = new System.Drawing.Size(51, 20);
            this.i_worldPort.TabIndex = 6;
            this.i_worldPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // i_worldUsername
            // 
            this.i_worldUsername.Location = new System.Drawing.Point(65, 99);
            this.i_worldUsername.Name = "i_worldUsername";
            this.i_worldUsername.Size = new System.Drawing.Size(139, 20);
            this.i_worldUsername.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Username";
            // 
            // i_worldPassword
            // 
            this.i_worldPassword.Location = new System.Drawing.Point(65, 125);
            this.i_worldPassword.Name = "i_worldPassword";
            this.i_worldPassword.Size = new System.Drawing.Size(139, 20);
            this.i_worldPassword.TabIndex = 8;
            this.i_worldPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Host";
            // 
            // i_worldHost
            // 
            this.i_worldHost.AcceptsReturn = true;
            this.i_worldHost.Location = new System.Drawing.Point(65, 19);
            this.i_worldHost.Name = "i_worldHost";
            this.i_worldHost.Size = new System.Drawing.Size(139, 20);
            this.i_worldHost.TabIndex = 5;
            // 
            // i_saveButton
            // 
            this.i_saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.i_saveButton.Location = new System.Drawing.Point(593, 253);
            this.i_saveButton.Name = "i_saveButton";
            this.i_saveButton.Size = new System.Drawing.Size(61, 23);
            this.i_saveButton.TabIndex = 10;
            this.i_saveButton.Text = "Save";
            this.i_saveButton.UseVisualStyleBackColor = true;
            this.i_saveButton.Click += new System.EventHandler(this.i_saveButton_Click);
            // 
            // i_connectButton
            // 
            this.i_connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.i_connectButton.Location = new System.Drawing.Point(509, 253);
            this.i_connectButton.Name = "i_connectButton";
            this.i_connectButton.Size = new System.Drawing.Size(78, 23);
            this.i_connectButton.TabIndex = 9;
            this.i_connectButton.Text = "Connect";
            this.i_connectButton.UseVisualStyleBackColor = true;
            this.i_connectButton.Click += new System.EventHandler(this.i_connectButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Handle";
            // 
            // i_handle
            // 
            this.i_handle.Location = new System.Drawing.Point(77, 32);
            this.i_handle.Name = "i_handle";
            this.i_handle.Size = new System.Drawing.Size(210, 20);
            this.i_handle.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.i_characterSqlType);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.i_characterDatabase);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.i_characterPort);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.i_characterUsername);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.i_characterPassword);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.i_characterHost);
            this.groupBox3.Location = new System.Drawing.Point(444, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 187);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Character Database";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 155);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "DB Type";
            // 
            // i_characterSqlType
            // 
            this.i_characterSqlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.i_characterSqlType.FormattingEnabled = true;
            this.i_characterSqlType.Location = new System.Drawing.Point(65, 152);
            this.i_characterSqlType.Name = "i_characterSqlType";
            this.i_characterSqlType.Size = new System.Drawing.Size(139, 21);
            this.i_characterSqlType.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Database";
            // 
            // i_characterDatabase
            // 
            this.i_characterDatabase.AcceptsReturn = true;
            this.i_characterDatabase.Location = new System.Drawing.Point(65, 45);
            this.i_characterDatabase.Name = "i_characterDatabase";
            this.i_characterDatabase.Size = new System.Drawing.Size(139, 20);
            this.i_characterDatabase.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Port";
            // 
            // i_characterPort
            // 
            this.i_characterPort.Location = new System.Drawing.Point(65, 73);
            this.i_characterPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.i_characterPort.Name = "i_characterPort";
            this.i_characterPort.Size = new System.Drawing.Size(51, 20);
            this.i_characterPort.TabIndex = 6;
            this.i_characterPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Password";
            // 
            // i_characterUsername
            // 
            this.i_characterUsername.Location = new System.Drawing.Point(65, 99);
            this.i_characterUsername.Name = "i_characterUsername";
            this.i_characterUsername.Size = new System.Drawing.Size(139, 20);
            this.i_characterUsername.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Username";
            // 
            // i_characterPassword
            // 
            this.i_characterPassword.Location = new System.Drawing.Point(65, 125);
            this.i_characterPassword.Name = "i_characterPassword";
            this.i_characterPassword.Size = new System.Drawing.Size(139, 20);
            this.i_characterPassword.TabIndex = 8;
            this.i_characterPassword.UseSystemPasswordChar = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Host";
            // 
            // i_characterHost
            // 
            this.i_characterHost.AcceptsReturn = true;
            this.i_characterHost.Location = new System.Drawing.Point(65, 19);
            this.i_characterHost.Name = "i_characterHost";
            this.i_characterHost.Size = new System.Drawing.Size(139, 20);
            this.i_characterHost.TabIndex = 5;
            // 
            // DBProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 288);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.i_handle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.i_connectButton);
            this.Controls.Add(this.i_saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBProfileEditor";
            this.Text = "DBProfileEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_accountPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_worldPort)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_characterPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        [ObjectToObject(typeof(Database.DBProfile), "AccountPort", "Value", true)]
        private System.Windows.Forms.NumericUpDown i_accountPort;
        private System.Windows.Forms.Label label4;
        [RequiredField("Text", "", 2)]
        [ObjectToObject(typeof(Database.DBProfile), "AccountUsername", "Text")]
        private System.Windows.Forms.TextBox  i_accountUsername;
        private System.Windows.Forms.Label label5;
        [RequiredField("Text", "", 2)]
        [ObjectToObject(typeof(Database.DBProfile), "AccountPassword", "Text")]
        private System.Windows.Forms.TextBox  i_accountPassword;
        private System.Windows.Forms.Label label6;
        [RequiredField("Text", "", 2)]
        [ObjectToObject(typeof(Database.DBProfile), "AccountHost", "Text")]
        private System.Windows.Forms.TextBox  i_accountHost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        [ObjectToObject(typeof(Database.DBProfile), "WorldPort", "Value", true)]
        private System.Windows.Forms.NumericUpDown  i_worldPort;
        private System.Windows.Forms.Label label3;
        [RequiredField("Text", "", 1)]
        [ObjectToObject(typeof(Database.DBProfile), "WorldUsername", "Text")]
        private System.Windows.Forms.TextBox  i_worldUsername;
        private System.Windows.Forms.Label label7;
        [RequiredField("Text", "", 1)]
        [ObjectToObject(typeof(Database.DBProfile), "WorldPassword", "Text")]
        private System.Windows.Forms.TextBox  i_worldPassword;
        private System.Windows.Forms.Label label8;
        [RequiredField("Text", "", 1)]
        [ObjectToObject(typeof(Database.DBProfile), "WorldHost", "Text")]
        private System.Windows.Forms.TextBox  i_worldHost;
        private System.Windows.Forms.Button i_saveButton;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button i_connectButton;
        private System.Windows.Forms.Label label9;
        [RequiredField("Text", "Please enter the name you wish to designate this profile")]
        [ObjectToObject(typeof(Database.DBProfile), "Handle", "Text")]
        private System.Windows.Forms.TextBox i_handle;
        private System.Windows.Forms.Label label11;
        [RequiredField("Text", "", 2)]
        [ObjectToObject(typeof(Database.DBProfile), "AccountDatabase", "Text")]
        private System.Windows.Forms.TextBox i_accountDatabase;
        private System.Windows.Forms.Label label10;
        [RequiredField("Text", "", 1)]
        [ObjectToObject(typeof(Database.DBProfile), "WorldDatabase", "Text")]
        private System.Windows.Forms.TextBox i_worldDatabase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        [RequiredField("Text", "", 3)]
        [ObjectToObject(typeof(Database.DBProfile), "CharacterDatabase", "Text")]
        private System.Windows.Forms.TextBox i_characterDatabase;
        private System.Windows.Forms.Label label13;
        [ObjectToObject(typeof(Database.DBProfile), "CharacterPort", "Value", true)]
        private System.Windows.Forms.NumericUpDown i_characterPort;
        private System.Windows.Forms.Label label14;
        [RequiredField("Text", "", 3)]
        [ObjectToObject(typeof(Database.DBProfile), "CharacterUsername", "Text")]
        private System.Windows.Forms.TextBox i_characterUsername;
        private System.Windows.Forms.Label label15;
        [RequiredField("Text", "", 3)]
        [ObjectToObject(typeof(Database.DBProfile), "CharacterPassword", "Text")]
        private System.Windows.Forms.TextBox i_characterPassword;
        private System.Windows.Forms.Label label16;
        [RequiredField("Text", "", 3)]
        [ObjectToObject(typeof(Database.DBProfile), "CharacterHost", "Text")]
        private System.Windows.Forms.TextBox i_characterHost;
        [ObjectToObject(typeof(Database.DBProfile), "AccountDatabaseType", "SelectedItem")]
        private System.Windows.Forms.ComboBox i_accountSqlType;
        [ObjectToObject(typeof(Database.DBProfile), "WorldDatabaseType", "SelectedItem")]
        private System.Windows.Forms.ComboBox i_worldSqlType;
        [ObjectToObject(typeof(Database.DBProfile), "CharacterDatabaseType", "SelectedItem")]
        private System.Windows.Forms.ComboBox i_characterSqlType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}