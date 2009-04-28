namespace MDEditor.Interface
{
    partial class GoldEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.i_copperIcon = new System.Windows.Forms.PictureBox();
            this.i_silverIcon = new System.Windows.Forms.PictureBox();
            this.i_goldIcon = new System.Windows.Forms.PictureBox();
            this.i_copperNumeric = new System.Windows.Forms.NumericUpDown();
            this.i_silverNumeric = new System.Windows.Forms.NumericUpDown();
            this.i_goldNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.i_copperIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_silverIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_goldIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_copperNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_silverNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_goldNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // i_copperIcon
            // 
            this.i_copperIcon.Image = global::MDEditor.Properties.Resources.coppericon;
            this.i_copperIcon.Location = new System.Drawing.Point(188, 7);
            this.i_copperIcon.Name = "i_copperIcon";
            this.i_copperIcon.Size = new System.Drawing.Size(17, 20);
            this.i_copperIcon.TabIndex = 4;
            this.i_copperIcon.TabStop = false;
            // 
            // i_silverIcon
            // 
            this.i_silverIcon.Image = global::MDEditor.Properties.Resources.silvericon;
            this.i_silverIcon.Location = new System.Drawing.Point(126, 7);
            this.i_silverIcon.Name = "i_silverIcon";
            this.i_silverIcon.Size = new System.Drawing.Size(17, 20);
            this.i_silverIcon.TabIndex = 2;
            this.i_silverIcon.TabStop = false;
            // 
            // i_goldIcon
            // 
            this.i_goldIcon.Image = global::MDEditor.Properties.Resources.goldicon;
            this.i_goldIcon.Location = new System.Drawing.Point(64, 7);
            this.i_goldIcon.Name = "i_goldIcon";
            this.i_goldIcon.Size = new System.Drawing.Size(17, 20);
            this.i_goldIcon.TabIndex = 0;
            this.i_goldIcon.TabStop = false;
            // 
            // i_copperNumeric
            // 
            this.i_copperNumeric.Location = new System.Drawing.Point(149, 7);
            this.i_copperNumeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.i_copperNumeric.Name = "i_copperNumeric";
            this.i_copperNumeric.Size = new System.Drawing.Size(33, 20);
            this.i_copperNumeric.TabIndex = 2;
            this.i_copperNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // i_silverNumeric
            // 
            this.i_silverNumeric.Location = new System.Drawing.Point(87, 7);
            this.i_silverNumeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.i_silverNumeric.Name = "i_silverNumeric";
            this.i_silverNumeric.Size = new System.Drawing.Size(33, 20);
            this.i_silverNumeric.TabIndex = 1;
            this.i_silverNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // i_goldNumeric
            // 
            this.i_goldNumeric.Location = new System.Drawing.Point(0, 7);
            this.i_goldNumeric.Maximum = new decimal(new int[] {
            230000,
            0,
            0,
            0});
            this.i_goldNumeric.Name = "i_goldNumeric";
            this.i_goldNumeric.Size = new System.Drawing.Size(58, 20);
            this.i_goldNumeric.TabIndex = 0;
            this.i_goldNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GoldEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.i_goldNumeric);
            this.Controls.Add(this.i_silverNumeric);
            this.Controls.Add(this.i_copperNumeric);
            this.Controls.Add(this.i_copperIcon);
            this.Controls.Add(this.i_silverIcon);
            this.Controls.Add(this.i_goldIcon);
            this.Name = "GoldEditor";
            this.Size = new System.Drawing.Size(207, 33);
            ((System.ComponentModel.ISupportInitialize)(this.i_copperIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_silverIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_goldIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_copperNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_silverNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_goldNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox i_goldIcon;
        private System.Windows.Forms.PictureBox i_silverIcon;
        private System.Windows.Forms.PictureBox i_copperIcon;
        private System.Windows.Forms.NumericUpDown i_copperNumeric;
        private System.Windows.Forms.NumericUpDown i_silverNumeric;
        private System.Windows.Forms.NumericUpDown i_goldNumeric;
    }
}
