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
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.tooltip_pane = new System.Windows.Forms.Panel();
            this.designName_lbl = new System.Windows.Forms.Label();
            this.userTextName_lbl = new System.Windows.Forms.Label();
            this.disDesginName_lbl = new System.Windows.Forms.Label();
            this.disUserText_lbl = new System.Windows.Forms.Label();
            this.chargeMoney_lbl = new System.Windows.Forms.Label();
            this.dismoney_lbl = new System.Windows.Forms.Label();
            this.disInfo_pane = new System.Windows.Forms.TableLayoutPanel();
            this.showingDesign2 = new System.Windows.Forms.PictureBox();
            this.next_pane = new System.Windows.Forms.Panel();
            this.exit_pane = new System.Windows.Forms.Panel();
            this.tooltip_pane.SuspendLayout();
            this.disInfo_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign2)).BeginInit();
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
            // designName_lbl
            // 
            resources.ApplyResources(this.designName_lbl, "designName_lbl");
            this.designName_lbl.Name = "designName_lbl";
            // 
            // userTextName_lbl
            // 
            resources.ApplyResources(this.userTextName_lbl, "userTextName_lbl");
            this.userTextName_lbl.Name = "userTextName_lbl";
            // 
            // disDesginName_lbl
            // 
            resources.ApplyResources(this.disDesginName_lbl, "disDesginName_lbl");
            this.disDesginName_lbl.Name = "disDesginName_lbl";
            // 
            // disUserText_lbl
            // 
            resources.ApplyResources(this.disUserText_lbl, "disUserText_lbl");
            this.disUserText_lbl.Name = "disUserText_lbl";
            // 
            // chargeMoney_lbl
            // 
            resources.ApplyResources(this.chargeMoney_lbl, "chargeMoney_lbl");
            this.chargeMoney_lbl.Name = "chargeMoney_lbl";
            // 
            // dismoney_lbl
            // 
            resources.ApplyResources(this.dismoney_lbl, "dismoney_lbl");
            this.dismoney_lbl.Name = "dismoney_lbl";
            // 
            // disInfo_pane
            // 
            resources.ApplyResources(this.disInfo_pane, "disInfo_pane");
            this.disInfo_pane.Controls.Add(this.designName_lbl, 0, 0);
            this.disInfo_pane.Controls.Add(this.dismoney_lbl, 1, 2);
            this.disInfo_pane.Controls.Add(this.userTextName_lbl, 0, 1);
            this.disInfo_pane.Controls.Add(this.disUserText_lbl, 1, 1);
            this.disInfo_pane.Controls.Add(this.chargeMoney_lbl, 0, 2);
            this.disInfo_pane.Controls.Add(this.disDesginName_lbl, 1, 0);
            this.disInfo_pane.Name = "disInfo_pane";
            // 
            // showingDesign2
            // 
            resources.ApplyResources(this.showingDesign2, "showingDesign2");
            this.showingDesign2.Image = global::Demo.Properties.Resources._9321_shop1_297733;
            this.showingDesign2.Name = "showingDesign2";
            this.showingDesign2.TabStop = false;
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
            // PayPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.disInfo_pane);
            this.Controls.Add(this.showingDesign2);
            this.Controls.Add(this.tooltip_pane);
            this.Controls.Add(this.next_pane);
            this.Controls.Add(this.exit_pane);
            this.Name = "PayPage";
            this.tooltip_pane.ResumeLayout(false);
            this.disInfo_pane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel next_pane;
        private System.Windows.Forms.Panel exit_pane;
        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.Panel tooltip_pane;
        private System.Windows.Forms.PictureBox showingDesign2;
        private System.Windows.Forms.Label designName_lbl;
        private System.Windows.Forms.Label userTextName_lbl;
        private System.Windows.Forms.Label disDesginName_lbl;
        private System.Windows.Forms.Label disUserText_lbl;
        private System.Windows.Forms.Label chargeMoney_lbl;
        private System.Windows.Forms.Label dismoney_lbl;
        private System.Windows.Forms.TableLayoutPanel disInfo_pane;
    }
}