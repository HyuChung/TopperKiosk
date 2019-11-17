namespace Demo
{
    partial class EndPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndPage));
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_UserInfoText = new System.Windows.Forms.Label();
            this.label_PayTypeInfoText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitinfo_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tooltip_lbl
            // 
            this.tooltip_lbl.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.tooltip_lbl, "tooltip_lbl");
            this.tooltip_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tooltip_lbl.Name = "tooltip_lbl";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label_UserInfoText
            // 
            resources.ApplyResources(this.label_UserInfoText, "label_UserInfoText");
            this.label_UserInfoText.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_UserInfoText.Name = "label_UserInfoText";
            // 
            // label_PayTypeInfoText
            // 
            resources.ApplyResources(this.label_PayTypeInfoText, "label_PayTypeInfoText");
            this.label_PayTypeInfoText.Name = "label_PayTypeInfoText";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = global::Demo.Properties.Resources._checked;
            this.pictureBox1.InitialImage = global::Demo.Properties.Resources._checked;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // exitinfo_lbl
            // 
            resources.ApplyResources(this.exitinfo_lbl, "exitinfo_lbl");
            this.exitinfo_lbl.Name = "exitinfo_lbl";
            // 
            // EndPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.exitinfo_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_PayTypeInfoText);
            this.Controls.Add(this.label_UserInfoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tooltip_lbl);
            this.Name = "EndPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_UserInfoText;
        private System.Windows.Forms.Label label_PayTypeInfoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exitinfo_lbl;
    }
}