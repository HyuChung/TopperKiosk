namespace Demo
{
    partial class TopperlistPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopperlistPopUp));
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.showingDesign = new System.Windows.Forms.PictureBox();
            this.disInfo_pane = new System.Windows.Forms.TableLayoutPanel();
            this.designName_lbl = new System.Windows.Forms.Label();
            this.disDesginName_lbl = new System.Windows.Forms.Label();
            this.exit_pane = new System.Windows.Forms.Panel();
            this.next_pane = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign)).BeginInit();
            this.disInfo_pane.SuspendLayout();
            this.SuspendLayout();
            // 
            // tooltip_lbl
            // 
            resources.ApplyResources(this.tooltip_lbl, "tooltip_lbl");
            this.tooltip_lbl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tooltip_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tooltip_lbl.Name = "tooltip_lbl";
            // 
            // showingDesign
            // 
            resources.ApplyResources(this.showingDesign, "showingDesign");
            this.showingDesign.Name = "showingDesign";
            this.showingDesign.TabStop = false;
            // 
            // disInfo_pane
            // 
            resources.ApplyResources(this.disInfo_pane, "disInfo_pane");
            this.disInfo_pane.Controls.Add(this.designName_lbl, 0, 0);
            this.disInfo_pane.Controls.Add(this.disDesginName_lbl, 1, 0);
            this.disInfo_pane.Name = "disInfo_pane";
            // 
            // designName_lbl
            // 
            resources.ApplyResources(this.designName_lbl, "designName_lbl");
            this.designName_lbl.Name = "designName_lbl";
            // 
            // disDesginName_lbl
            // 
            resources.ApplyResources(this.disDesginName_lbl, "disDesginName_lbl");
            this.disDesginName_lbl.Name = "disDesginName_lbl";
            // 
            // exit_pane
            // 
            resources.ApplyResources(this.exit_pane, "exit_pane");
            this.exit_pane.BackgroundImage = global::Demo.Properties.Resources.cancel;
            this.exit_pane.Name = "exit_pane";
            this.exit_pane.Click += new System.EventHandler(this.exit_pane_Click);
            // 
            // next_pane
            // 
            resources.ApplyResources(this.next_pane, "next_pane");
            this.next_pane.BackgroundImage = global::Demo.Properties.Resources.next;
            this.next_pane.Name = "next_pane";
            this.next_pane.Click += new System.EventHandler(this.next_pane_Click);
            // 
            // TopperlistPopUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.next_pane);
            this.Controls.Add(this.exit_pane);
            this.Controls.Add(this.disInfo_pane);
            this.Controls.Add(this.showingDesign);
            this.Controls.Add(this.tooltip_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopperlistPopUp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign)).EndInit();
            this.disInfo_pane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.PictureBox showingDesign;
        private System.Windows.Forms.TableLayoutPanel disInfo_pane;
        private System.Windows.Forms.Label designName_lbl;
        private System.Windows.Forms.Label disDesginName_lbl;
        private System.Windows.Forms.Panel exit_pane;
        private System.Windows.Forms.Panel next_pane;
    }
}