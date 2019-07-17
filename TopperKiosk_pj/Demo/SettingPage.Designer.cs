namespace Demo
{
    partial class SettingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingPage));
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.tooltip_pane = new System.Windows.Forms.Panel();
            this.insertUserText = new System.Windows.Forms.TextBox();
            this.showingDesign = new System.Windows.Forms.PictureBox();
            this.next_pane = new System.Windows.Forms.Panel();
            this.exit_pane = new System.Windows.Forms.Panel();
            this.tooltip_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // tooltip_lbl
            // 
            resources.ApplyResources(this.tooltip_lbl, "tooltip_lbl");
            this.tooltip_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tooltip_lbl.Name = "tooltip_lbl";
            // 
            // tooltip_pane
            // 
            resources.ApplyResources(this.tooltip_pane, "tooltip_pane");
            this.tooltip_pane.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tooltip_pane.Controls.Add(this.tooltip_lbl);
            this.tooltip_pane.Name = "tooltip_pane";
            // 
            // insertUserText
            // 
            resources.ApplyResources(this.insertUserText, "insertUserText");
            this.insertUserText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.insertUserText.Name = "insertUserText";
            // 
            // showingDesign
            // 
            resources.ApplyResources(this.showingDesign, "showingDesign");
            this.showingDesign.Name = "showingDesign";
            this.showingDesign.TabStop = false;
            // 
            // next_pane
            // 
            resources.ApplyResources(this.next_pane, "next_pane");
            this.next_pane.BackgroundImage = global::Demo.Properties.Resources.next;
            this.next_pane.Name = "next_pane";
            this.next_pane.Click += new System.EventHandler(this.next_pane_Click);
            // 
            // exit_pane
            // 
            resources.ApplyResources(this.exit_pane, "exit_pane");
            this.exit_pane.BackgroundImage = global::Demo.Properties.Resources.cancel;
            this.exit_pane.Name = "exit_pane";
            this.exit_pane.Click += new System.EventHandler(this.exit_pane_Click);
            // 
            // SettingPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.insertUserText);
            this.Controls.Add(this.showingDesign);
            this.Controls.Add(this.tooltip_pane);
            this.Controls.Add(this.next_pane);
            this.Controls.Add(this.exit_pane);
            this.Name = "SettingPage";
            this.tooltip_pane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel next_pane;
        private System.Windows.Forms.Panel exit_pane;
        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.Panel tooltip_pane;
        private System.Windows.Forms.PictureBox showingDesign;
        private System.Windows.Forms.TextBox insertUserText;
    }
}