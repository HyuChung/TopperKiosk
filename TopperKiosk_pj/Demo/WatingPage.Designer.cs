namespace Demo
{
    partial class WatingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatingPage));
            this.showingDesign = new System.Windows.Forms.PictureBox();
            this.tooltip_pane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign)).BeginInit();
            this.tooltip_pane.SuspendLayout();
            this.SuspendLayout();
            // 
            // showingDesign
            // 
            resources.ApplyResources(this.showingDesign, "showingDesign");
            this.showingDesign.Name = "showingDesign";
            this.showingDesign.TabStop = false;
            // 
            // tooltip_pane
            // 
            resources.ApplyResources(this.tooltip_pane, "tooltip_pane");
            this.tooltip_pane.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tooltip_pane.Controls.Add(this.label1);
            this.tooltip_pane.Name = "tooltip_pane";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // WatingPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.tooltip_pane);
            this.Controls.Add(this.showingDesign);
            this.Name = "WatingPage";
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign)).EndInit();
            this.tooltip_pane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox showingDesign;
        private System.Windows.Forms.Panel tooltip_pane;
        private System.Windows.Forms.Label label1;
    }
}