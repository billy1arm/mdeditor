namespace MDEditor.Interface
{
    partial class SplashInterface
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.i_createFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.i_profileSelection = new System.Windows.Forms.ComboBox();
            this.i_editButton = new System.Windows.Forms.Button();
            this.i_deleteButton = new System.Windows.Forms.Button();
            this.i_connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // i_createFirst
            // 
            this.i_createFirst.Location = new System.Drawing.Point(171, 181);
            this.i_createFirst.Name = "i_createFirst";
            this.i_createFirst.Size = new System.Drawing.Size(75, 23);
            this.i_createFirst.TabIndex = 1;
            this.i_createFirst.Tag = "false";
            this.i_createFirst.Text = "Create";
            this.i_createFirst.UseVisualStyleBackColor = true;
            this.i_createFirst.Click += new System.EventHandler(this.i_createFirst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 26);
            this.label1.TabIndex = 2;
            this.label1.Tag = "false";
            this.label1.Text = "You do not have any databases setup.\r\nTo use this tool you must create a database" +
                " profile to connect to.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // i_profileSelection
            // 
            this.i_profileSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.i_profileSelection.FormattingEnabled = true;
            this.i_profileSelection.Location = new System.Drawing.Point(30, 24);
            this.i_profileSelection.Name = "i_profileSelection";
            this.i_profileSelection.Size = new System.Drawing.Size(149, 21);
            this.i_profileSelection.TabIndex = 3;
            this.i_profileSelection.Tag = "true";
            this.i_profileSelection.Visible = false;
            this.i_profileSelection.SelectionChangeCommitted += new System.EventHandler(this.i_profileSelection_SelectionChangeCommitted);
            // 
            // i_editButton
            // 
            this.i_editButton.Enabled = false;
            this.i_editButton.Location = new System.Drawing.Point(185, 22);
            this.i_editButton.Name = "i_editButton";
            this.i_editButton.Size = new System.Drawing.Size(46, 23);
            this.i_editButton.TabIndex = 4;
            this.i_editButton.Tag = "true";
            this.i_editButton.Text = "Edit";
            this.i_editButton.UseVisualStyleBackColor = true;
            this.i_editButton.Visible = false;
            this.i_editButton.Click += new System.EventHandler(this.i_editButton_Click);
            // 
            // i_deleteButton
            // 
            this.i_deleteButton.Enabled = false;
            this.i_deleteButton.Location = new System.Drawing.Point(237, 22);
            this.i_deleteButton.Name = "i_deleteButton";
            this.i_deleteButton.Size = new System.Drawing.Size(46, 23);
            this.i_deleteButton.TabIndex = 5;
            this.i_deleteButton.Tag = "true";
            this.i_deleteButton.Text = "Delete";
            this.i_deleteButton.UseVisualStyleBackColor = true;
            this.i_deleteButton.Visible = false;
            this.i_deleteButton.Click += new System.EventHandler(this.i_deleteButton_Click);
            // 
            // i_connectButton
            // 
            this.i_connectButton.Enabled = false;
            this.i_connectButton.Location = new System.Drawing.Point(30, 51);
            this.i_connectButton.Name = "i_connectButton";
            this.i_connectButton.Size = new System.Drawing.Size(75, 23);
            this.i_connectButton.TabIndex = 6;
            this.i_connectButton.Tag = "true";
            this.i_connectButton.Text = "Connect";
            this.i_connectButton.UseVisualStyleBackColor = true;
            // 
            // SplashInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 291);
            this.Controls.Add(this.i_connectButton);
            this.Controls.Add(this.i_deleteButton);
            this.Controls.Add(this.i_editButton);
            this.Controls.Add(this.i_profileSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.i_createFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SplashInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpashInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button i_createFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox i_profileSelection;
        private System.Windows.Forms.Button i_editButton;
        private System.Windows.Forms.Button i_deleteButton;
        private System.Windows.Forms.Button i_connectButton;
    }
}