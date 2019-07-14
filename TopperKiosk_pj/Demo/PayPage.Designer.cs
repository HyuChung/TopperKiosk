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
            this.next_pane = new System.Windows.Forms.Panel();
            this.exit_pane = new System.Windows.Forms.Panel();
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.tooltip_pane = new System.Windows.Forms.Panel();
            this.showingDesign = new System.Windows.Forms.PictureBox();
            this.tooltip_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // next_pane
            // 
            this.next_pane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next_pane.BackgroundImage = global::Demo.Properties.Resources.next;
            this.next_pane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next_pane.Location = new System.Drawing.Point(382, 847);
            this.next_pane.Name = "next_pane";
            this.next_pane.Size = new System.Drawing.Size(83, 82);
            this.next_pane.TabIndex = 5;
            // 
            // exit_pane
            // 
            this.exit_pane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_pane.BackgroundImage = global::Demo.Properties.Resources.cancel;
            this.exit_pane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_pane.Location = new System.Drawing.Point(56, 847);
            this.exit_pane.Name = "exit_pane";
            this.exit_pane.Size = new System.Drawing.Size(83, 82);
            this.exit_pane.TabIndex = 4;
            this.exit_pane.Click += new System.EventHandler(this.exit_pane_Click);
            // 
            // tooltip_lbl
            // 
            this.tooltip_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tooltip_lbl.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tooltip_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tooltip_lbl.Location = new System.Drawing.Point(0, 0);
            this.tooltip_lbl.Name = "tooltip_lbl";
            this.tooltip_lbl.Size = new System.Drawing.Size(525, 41);
            this.tooltip_lbl.TabIndex = 0;
            this.tooltip_lbl.Text = "결과물을 최종 확인해 주세요";
            this.tooltip_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tooltip_pane
            // 
            this.tooltip_pane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tooltip_pane.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tooltip_pane.Controls.Add(this.tooltip_lbl);
            this.tooltip_pane.Location = new System.Drawing.Point(0, 0);
            this.tooltip_pane.Name = "tooltip_pane";
            this.tooltip_pane.Size = new System.Drawing.Size(525, 41);
            this.tooltip_pane.TabIndex = 6;
            // 
            // showingDesign
            // 
            this.showingDesign.Image = global::Demo.Properties.Resources._9321_shop1_297733;
            this.showingDesign.Location = new System.Drawing.Point(120, 47);
            this.showingDesign.Name = "showingDesign";
            this.showingDesign.Size = new System.Drawing.Size(269, 299);
            this.showingDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showingDesign.TabIndex = 8;
            this.showingDesign.TabStop = false;
            // 
            // PayPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(524, 941);
            this.ControlBox = false;
            this.Controls.Add(this.showingDesign);
            this.Controls.Add(this.tooltip_pane);
            this.Controls.Add(this.next_pane);
            this.Controls.Add(this.exit_pane);
            this.Name = "PayPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tooltip_pane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showingDesign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel next_pane;
        private System.Windows.Forms.Panel exit_pane;
        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.Panel tooltip_pane;
        private System.Windows.Forms.PictureBox showingDesign;
    }
}