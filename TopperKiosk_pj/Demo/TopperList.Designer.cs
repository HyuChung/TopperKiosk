namespace Demo
{
    partial class TopperList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopperList));
            this.picture_layout_pane = new System.Windows.Forms.TableLayoutPanel();
            this.pic_2_2 = new System.Windows.Forms.PictureBox();
            this.pic_1_1 = new System.Windows.Forms.PictureBox();
            this.pic_1_2 = new System.Windows.Forms.PictureBox();
            this.pic_1_3 = new System.Windows.Forms.PictureBox();
            this.pic_2_1 = new System.Windows.Forms.PictureBox();
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.info_lbl = new System.Windows.Forms.Label();
            this.picture_layout_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2_1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_layout_pane
            // 
            resources.ApplyResources(this.picture_layout_pane, "picture_layout_pane");
            this.picture_layout_pane.Controls.Add(this.pic_2_2, 4, 0);
            this.picture_layout_pane.Controls.Add(this.pic_1_1, 0, 0);
            this.picture_layout_pane.Controls.Add(this.pic_1_2, 1, 0);
            this.picture_layout_pane.Controls.Add(this.pic_1_3, 2, 0);
            this.picture_layout_pane.Controls.Add(this.pic_2_1, 3, 0);
            this.picture_layout_pane.Name = "picture_layout_pane";
            // 
            // pic_2_2
            // 
            resources.ApplyResources(this.pic_2_2, "pic_2_2");
            this.pic_2_2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_2_2.Name = "pic_2_2";
            this.pic_2_2.TabStop = false;
            this.pic_2_2.Click += new System.EventHandler(this.pic_2_2_Click);
            // 
            // pic_1_1
            // 
            resources.ApplyResources(this.pic_1_1, "pic_1_1");
            this.pic_1_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_1_1.Name = "pic_1_1";
            this.pic_1_1.TabStop = false;
            this.pic_1_1.Click += new System.EventHandler(this.pic_1_1_Click);
            // 
            // pic_1_2
            // 
            resources.ApplyResources(this.pic_1_2, "pic_1_2");
            this.pic_1_2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_1_2.Name = "pic_1_2";
            this.pic_1_2.TabStop = false;
            this.pic_1_2.Click += new System.EventHandler(this.pic_1_2_Click);
            // 
            // pic_1_3
            // 
            resources.ApplyResources(this.pic_1_3, "pic_1_3");
            this.pic_1_3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_1_3.Name = "pic_1_3";
            this.pic_1_3.TabStop = false;
            this.pic_1_3.Click += new System.EventHandler(this.pic_1_3_Click);
            // 
            // pic_2_1
            // 
            resources.ApplyResources(this.pic_2_1, "pic_2_1");
            this.pic_2_1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_2_1.Name = "pic_2_1";
            this.pic_2_1.TabStop = false;
            this.pic_2_1.Click += new System.EventHandler(this.pic_2_1_Click);
            // 
            // tooltip_lbl
            // 
            this.tooltip_lbl.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.tooltip_lbl, "tooltip_lbl");
            this.tooltip_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tooltip_lbl.Name = "tooltip_lbl";
            // 
            // info_lbl
            // 
            resources.ApplyResources(this.info_lbl, "info_lbl");
            this.info_lbl.Name = "info_lbl";
            // 
            // TopperList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.tooltip_lbl);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.picture_layout_pane);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TopperList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.picture_layout_pane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel picture_layout_pane;
        private System.Windows.Forms.PictureBox pic_2_1;
        private System.Windows.Forms.PictureBox pic_1_3;
        private System.Windows.Forms.PictureBox pic_1_2;
        private System.Windows.Forms.PictureBox pic_1_1;
        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.PictureBox pic_2_2;
    }
}