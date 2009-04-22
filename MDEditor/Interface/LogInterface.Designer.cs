namespace MDEditor.Interface
{
    partial class LogInterface
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
            this.i_logWindow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // i_logWindow
            // 
            this.i_logWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.i_logWindow.BackColor = System.Drawing.SystemColors.MenuBar;
            this.i_logWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.i_logWindow.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.i_logWindow.Location = new System.Drawing.Point(12, 12);
            this.i_logWindow.Name = "i_logWindow";
            this.i_logWindow.ReadOnly = true;
            this.i_logWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.i_logWindow.Size = new System.Drawing.Size(638, 474);
            this.i_logWindow.TabIndex = 0;
            this.i_logWindow.Text = "";
            // 
            // LogInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 498);
            this.Controls.Add(this.i_logWindow);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "LogInterface";
            this.Text = "Logs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInterface_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox i_logWindow;
    }
}