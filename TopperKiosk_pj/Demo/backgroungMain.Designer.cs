﻿namespace Demo
{
    partial class backgroungMain
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
            this.dispane = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dispane
            // 
            this.dispane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dispane.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dispane.Location = new System.Drawing.Point(1, 2);
            this.dispane.Name = "dispane";
            this.dispane.Size = new System.Drawing.Size(1920, 1080);
            this.dispane.TabIndex = 0;
            // 
            // backgroungMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1064);
            this.ControlBox = false;
            this.Controls.Add(this.dispane);
            this.Name = "backgroungMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dispane;
    }
}