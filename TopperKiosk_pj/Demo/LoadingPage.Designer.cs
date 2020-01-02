namespace Demo
{
    partial class LoadingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingPage));
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_UserInfoText = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
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
            this.label_UserInfoText.ForeColor = System.Drawing.Color.Red;
            this.label_UserInfoText.Name = "label_UserInfoText";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 2;
            this.bunifuCircleProgressbar1.animationSpeed = 8;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuCircleProgressbar1, "bunifuCircleProgressbar1");
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 5;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.bunifuCircleProgressbar1.Value = 30;
            // 
            // LoadingPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.label_UserInfoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tooltip_lbl);
            this.Name = "LoadingPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_UserInfoText;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
    }
}