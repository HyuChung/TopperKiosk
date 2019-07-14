namespace Demo
{
    partial class PayPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayPage));
            this.next_pane = new System.Windows.Forms.Panel();
            this.exit_pane = new System.Windows.Forms.Panel();
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.tooltip_pane = new System.Windows.Forms.Panel();
            this.showingDesign2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tooltip_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign2)).BeginInit();
            this.SuspendLayout();
            // 
            // next_pane
            // 
            resources.ApplyResources(this.next_pane, "next_pane");
            this.next_pane.BackgroundImage = global::Demo.Properties.Resources.next;
            this.next_pane.Name = "next_pane";
            // 
            // exit_pane
            // 
            resources.ApplyResources(this.exit_pane, "exit_pane");
            this.exit_pane.BackgroundImage = global::Demo.Properties.Resources.cancel;
            this.exit_pane.Name = "exit_pane";
            this.exit_pane.Click += new System.EventHandler(this.exit_pane_Click);
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
            // showingDesign2
            // 
            this.showingDesign2.Image = global::Demo.Properties.Resources._9321_shop1_297733;
            resources.ApplyResources(this.showingDesign2, "showingDesign2");
            this.showingDesign2.Name = "showingDesign2";
            this.showingDesign2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // PayPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showingDesign2);
            this.Controls.Add(this.tooltip_pane);
            this.Controls.Add(this.next_pane);
            this.Controls.Add(this.exit_pane);
            this.Name = "PayPage";
            this.tooltip_pane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel next_pane;
        private System.Windows.Forms.Panel exit_pane;
        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.Panel tooltip_pane;
        private System.Windows.Forms.PictureBox showingDesign2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}