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
            this.label1 = new System.Windows.Forms.Label();
            this.i_accountPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.i_accountUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.i_accountPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.i_accountHost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.i_worldPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.i_worldUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.i_worldPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.i_worldHost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.i_handle = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_accountPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_worldPort)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
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
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.i_accountPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.i_accountUsername);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.i_accountPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.i_accountHost);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 121);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Port";
            // 
            // i_accountPort
            // 
            this.i_accountPort.Location = new System.Drawing.Point(65, 40);
            this.i_accountPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.i_accountPort.Name = "i_accountPort";
            this.i_accountPort.Size = new System.Drawing.Size(51, 20);
            this.i_accountPort.TabIndex = 10;
            this.i_accountPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // i_accountUsername
            // 
            this.i_accountUsername.Location = new System.Drawing.Point(65, 66);
            this.i_accountUsername.Name = "i_accountUsername";
            this.i_accountUsername.Size = new System.Drawing.Size(139, 20);
            this.i_accountUsername.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // i_accountPassword
            // 
            this.i_accountPassword.Location = new System.Drawing.Point(65, 92);
            this.i_accountPassword.Name = "i_accountPassword";
            this.i_accountPassword.Size = new System.Drawing.Size(139, 20);
            this.i_accountPassword.TabIndex = 2;
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
            this.i_accountHost.TabIndex = 6;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(210, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "World Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port";
            // 
            // i_worldPort
            // 
            this.i_worldPort.Location = new System.Drawing.Point(65, 40);
            this.i_worldPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.i_worldPort.Name = "i_worldPort";
            this.i_worldPort.Size = new System.Drawing.Size(51, 20);
            this.i_worldPort.TabIndex = 10;
            this.i_worldPort.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // i_worldUsername
            // 
            this.i_worldUsername.Location = new System.Drawing.Point(65, 66);
            this.i_worldUsername.Name = "i_worldUsername";
            this.i_worldUsername.Size = new System.Drawing.Size(139, 20);
            this.i_worldUsername.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Username";
            // 
            // i_worldPassword
            // 
            this.i_worldPassword.Location = new System.Drawing.Point(65, 92);
            this.i_worldPassword.Name = "i_worldPassword";
            this.i_worldPassword.Size = new System.Drawing.Size(139, 20);
            this.i_worldPassword.TabIndex = 2;
            this.i_worldPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Host";
            // 
            // i_worldHost
            // 
            this.i_worldHost.AcceptsReturn = true;
            this.i_worldHost.Location = new System.Drawing.Point(65, 14);
            this.i_worldHost.Name = "i_worldHost";
            this.i_worldHost.Size = new System.Drawing.Size(139, 20);
            this.i_worldHost.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
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
            this.i_handle.Size = new System.Drawing.Size(139, 20);
            this.i_handle.TabIndex = 12;
            // 
            // DBProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 233);
            this.Controls.Add(this.i_handle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        [ObjectToObject(typeof(Database.DBProfile), "AccountPort", "Value")]
        private System.Windows.Forms.NumericUpDown i_accountPort;
        private System.Windows.Forms.Label label4;
        [ObjectToObject(typeof(Database.DBProfile), "AccountUsername", "Text")]
        private System.Windows.Forms.TextBox  i_accountUsername;
        private System.Windows.Forms.Label label5;
        [ObjectToObject(typeof(Database.DBProfile), "AccountPassword", "Text")]
        private System.Windows.Forms.TextBox  i_accountPassword;
        private System.Windows.Forms.Label label6;
        [ObjectToObject(typeof(Database.DBProfile), "AccountHost", "Text")]
        private System.Windows.Forms.TextBox  i_accountHost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        [ObjectToObject(typeof(Database.DBProfile), "WorldPort", "Value")]
        private System.Windows.Forms.NumericUpDown  i_worldPort;
        private System.Windows.Forms.Label label3;
        [ObjectToObject(typeof(Database.DBProfile), "WorldUsername", "Text")]
        private System.Windows.Forms.TextBox  i_worldUsername;
        private System.Windows.Forms.Label label7;
        [ObjectToObject(typeof(Database.DBProfile), "WorldPassword", "Text")]
        private System.Windows.Forms.TextBox  i_worldPassword;
        private System.Windows.Forms.Label label8;
        [ObjectToObject(typeof(Database.DBProfile), "WorldHost", "Text")]
        private System.Windows.Forms.TextBox  i_worldHost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        [ObjectToObject(typeof(Database.DBProfile), "Handle", "Text")]
        private System.Windows.Forms.TextBox i_handle;
    }
}