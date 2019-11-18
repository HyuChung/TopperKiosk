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
            this.lbl_KO = new System.Windows.Forms.Label();
            this.lbl_CH = new System.Windows.Forms.Label();
            this.lbl_JP = new System.Windows.Forms.Label();
            this.lbl_EN = new System.Windows.Forms.Label();
            this.Main_lbl = new System.Windows.Forms.Label();
            this.translate_paneKo = new System.Windows.Forms.Panel();
            this.translate_paneCH = new System.Windows.Forms.Panel();
            this.translate_paneJP = new System.Windows.Forms.Panel();
            this.translate_paneEN = new System.Windows.Forms.Panel();
            this.ManInfo_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.translate_paneKo.SuspendLayout();
            this.translate_paneCH.SuspendLayout();
            this.translate_paneJP.SuspendLayout();
            this.translate_paneEN.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_KO
            // 
            this.lbl_KO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_KO.AutoSize = true;
            this.lbl_KO.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_KO.Location = new System.Drawing.Point(22, 20);
            this.lbl_KO.Name = "lbl_KO";
            this.lbl_KO.Size = new System.Drawing.Size(41, 12);
            this.lbl_KO.TabIndex = 1;
            this.lbl_KO.Text = "한국어";
            this.lbl_KO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneKO_MouseClick);
            // 
            // lbl_CH
            // 
            this.lbl_CH.AutoSize = true;
            this.lbl_CH.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_CH.Location = new System.Drawing.Point(22, 20);
            this.lbl_CH.Name = "lbl_CH";
            this.lbl_CH.Size = new System.Drawing.Size(41, 12);
            this.lbl_CH.TabIndex = 2;
            this.lbl_CH.Text = "中國語";
            this.lbl_CH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneCH_MouseClick);
            // 
            // lbl_JP
            // 
            this.lbl_JP.AutoSize = true;
            this.lbl_JP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_JP.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_JP.Location = new System.Drawing.Point(22, 20);
            this.lbl_JP.Name = "lbl_JP";
            this.lbl_JP.Size = new System.Drawing.Size(41, 12);
            this.lbl_JP.TabIndex = 3;
            this.lbl_JP.Text = "日本語";
            this.lbl_JP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneJP_MouseClick);
            this.lbl_JP.MouseEnter += new System.EventHandler(this.lbl_JP_MouseEnter);
            // 
            // lbl_EN
            // 
            this.lbl_EN.AutoSize = true;
            this.lbl_EN.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_EN.Location = new System.Drawing.Point(25, 20);
            this.lbl_EN.Name = "lbl_EN";
            this.lbl_EN.Size = new System.Drawing.Size(31, 12);
            this.lbl_EN.TabIndex = 4;
            this.lbl_EN.Text = "ENG";
            this.lbl_EN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneEN_MouseClick);
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
            // translate_paneKo
            // 
            this.translate_paneKo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translate_paneKo.BackColor = System.Drawing.Color.Transparent;
            this.translate_paneKo.BackgroundImage = global::Demo.Properties.Resources.the_button_859346_1280;
            this.translate_paneKo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.translate_paneKo.Controls.Add(this.lbl_KO);
            this.translate_paneKo.Location = new System.Drawing.Point(683, 3);
            this.translate_paneKo.Name = "translate_paneKo";
            this.translate_paneKo.Size = new System.Drawing.Size(86, 50);
            this.translate_paneKo.TabIndex = 6;
            this.translate_paneKo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneKO_MouseClick);
            this.translate_paneKo.MouseEnter += new System.EventHandler(this.translate_paneKo_MouseEnter);
            // 
            // translate_paneCH
            // 
            this.translate_paneCH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translate_paneCH.BackColor = System.Drawing.Color.Transparent;
            this.translate_paneCH.BackgroundImage = global::Demo.Properties.Resources.the_button_859346_1280;
            this.translate_paneCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.translate_paneCH.Controls.Add(this.lbl_CH);
            this.translate_paneCH.Location = new System.Drawing.Point(833, 3);
            this.translate_paneCH.Name = "translate_paneCH";
            this.translate_paneCH.Size = new System.Drawing.Size(86, 50);
            this.translate_paneCH.TabIndex = 7;
            this.translate_paneCH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneCH_MouseClick);
            this.translate_paneCH.MouseEnter += new System.EventHandler(this.translate_paneCH_MouseEnter);
            // 
            // translate_paneJP
            // 
            this.translate_paneJP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translate_paneJP.BackColor = System.Drawing.Color.Transparent;
            this.translate_paneJP.BackgroundImage = global::Demo.Properties.Resources.the_button_859346_1280;
            this.translate_paneJP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.translate_paneJP.Controls.Add(this.lbl_JP);
            this.translate_paneJP.Location = new System.Drawing.Point(983, 3);
            this.translate_paneJP.Name = "translate_paneJP";
            this.translate_paneJP.Size = new System.Drawing.Size(86, 50);
            this.translate_paneJP.TabIndex = 8;
            this.translate_paneJP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneJP_MouseClick);
            // 
            // translate_paneEN
            // 
            this.translate_paneEN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translate_paneEN.BackColor = System.Drawing.Color.Transparent;
            this.translate_paneEN.BackgroundImage = global::Demo.Properties.Resources.the_button_859346_1280;
            this.translate_paneEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.translate_paneEN.Controls.Add(this.lbl_EN);
            this.translate_paneEN.Location = new System.Drawing.Point(1133, 3);
            this.translate_paneEN.Name = "translate_paneEN";
            this.translate_paneEN.Size = new System.Drawing.Size(86, 50);
            this.translate_paneEN.TabIndex = 9;
            this.translate_paneEN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneEN_MouseClick);
            this.translate_paneEN.MouseEnter += new System.EventHandler(this.translate_paneEN_MouseEnter);
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
            this.panel1.Controls.Add(this.ManInfo_lbl);
            this.panel1.Controls.Add(this.translate_paneEN);
            this.panel1.Controls.Add(this.translate_paneKo);
            this.panel1.Controls.Add(this.translate_paneJP);
            this.panel1.Controls.Add(this.translate_paneCH);
            this.panel1.Location = new System.Drawing.Point(0, 765);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1905, 104);
            this.panel1.TabIndex = 11;
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
            this.translate_paneKo.ResumeLayout(false);
            this.translate_paneKo.PerformLayout();
            this.translate_paneCH.ResumeLayout(false);
            this.translate_paneCH.PerformLayout();
            this.translate_paneJP.ResumeLayout(false);
            this.translate_paneJP.PerformLayout();
            this.translate_paneEN.ResumeLayout(false);
            this.translate_paneEN.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KO;
        private System.Windows.Forms.Label lbl_CH;
        private System.Windows.Forms.Label lbl_JP;
        private System.Windows.Forms.Label lbl_EN;
        private System.Windows.Forms.Label Main_lbl;
        private System.Windows.Forms.Panel translate_paneKo;
        private System.Windows.Forms.Panel translate_paneCH;
        private System.Windows.Forms.Panel translate_paneJP;
        private System.Windows.Forms.Panel translate_paneEN;
        private System.Windows.Forms.Label ManInfo_lbl;
        private System.Windows.Forms.Panel panel1;
    }
}

