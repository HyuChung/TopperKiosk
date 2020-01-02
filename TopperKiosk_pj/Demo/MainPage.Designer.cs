namespace Demo
{
    partial class MainPage
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Main_lbl = new System.Windows.Forms.Label();
            this.ManInfo_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mansex_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_lbl
            // 
            this.Main_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Main_lbl.AutoSize = true;
            this.Main_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Main_lbl.Font = new System.Drawing.Font("AR CHRISTY", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_lbl.ForeColor = System.Drawing.Color.White;
            this.Main_lbl.Location = new System.Drawing.Point(827, 164);
            this.Main_lbl.Name = "Main_lbl";
            this.Main_lbl.Size = new System.Drawing.Size(243, 48);
            this.Main_lbl.TabIndex = 5;
            this.Main_lbl.Text = "Topper Maker";
            this.Main_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManInfo_lbl
            // 
            this.ManInfo_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManInfo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ManInfo_lbl.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ManInfo_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManInfo_lbl.Location = new System.Drawing.Point(780, 70);
            this.ManInfo_lbl.Name = "ManInfo_lbl";
            this.ManInfo_lbl.Size = new System.Drawing.Size(328, 24);
            this.ManInfo_lbl.TabIndex = 10;
            this.ManInfo_lbl.Text = "언어를 선택하여 다음으로 넘어가기";
            this.ManInfo_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.mansex_btn);
            this.panel1.Controls.Add(this.ManInfo_lbl);
            this.panel1.Location = new System.Drawing.Point(0, 765);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1905, 104);
            this.panel1.TabIndex = 11;
            // 
            // mansex_btn
            // 
            this.mansex_btn.ActiveBorderThickness = 1;
            this.mansex_btn.ActiveCornerRadius = 15;
            this.mansex_btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.mansex_btn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.mansex_btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.mansex_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mansex_btn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mansex_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mansex_btn.BackgroundImage")));
            this.mansex_btn.ButtonText = "한국어";
            this.mansex_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mansex_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.mansex_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.mansex_btn.IdleBorderThickness = 2;
            this.mansex_btn.IdleCornerRadius = 10;
            this.mansex_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mansex_btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.mansex_btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.mansex_btn.Location = new System.Drawing.Point(646, 10);
            this.mansex_btn.Margin = new System.Windows.Forms.Padding(5);
            this.mansex_btn.Name = "mansex_btn";
            this.mansex_btn.Size = new System.Drawing.Size(120, 45);
            this.mansex_btn.TabIndex = 65;
            this.mansex_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mansex_btn.Click += new System.EventHandler(this.translate_paneKO_MouseClick);
            this.mansex_btn.MouseEnter += new System.EventHandler(this.translate_paneKo_MouseEnter);
            this.mansex_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneKO_MouseClick);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 15;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "日本語";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 10;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(806, 10);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(120, 45);
            this.bunifuThinButton21.TabIndex = 66;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.translate_paneJP_MouseClick);
            this.bunifuThinButton21.MouseEnter += new System.EventHandler(this.lbl_JP_MouseEnter);
            this.bunifuThinButton21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneJP_MouseClick);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 15;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "中國語";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton22.IdleBorderThickness = 2;
            this.bunifuThinButton22.IdleCornerRadius = 10;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(966, 10);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(120, 45);
            this.bunifuThinButton22.TabIndex = 67;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.translate_paneCH_MouseClick);
            this.bunifuThinButton22.MouseEnter += new System.EventHandler(this.translate_paneCH_MouseEnter);
            this.bunifuThinButton22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneCH_MouseClick);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 15;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.bunifuThinButton23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "ENG";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton23.IdleBorderThickness = 2;
            this.bunifuThinButton23.IdleCornerRadius = 10;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.bunifuThinButton23.Location = new System.Drawing.Point(1126, 10);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(120, 45);
            this.bunifuThinButton23.TabIndex = 67;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.translate_paneEN_MouseClick);
            this.bunifuThinButton23.MouseEnter += new System.EventHandler(this.translate_paneEN_MouseEnter);
            this.bunifuThinButton23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneEN_MouseClick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Demo.Properties.Resources.gwangan_bridge_806949_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1064);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Main_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Main_lbl;
        private System.Windows.Forms.Label ManInfo_lbl;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 mansex_btn;
    }
}

