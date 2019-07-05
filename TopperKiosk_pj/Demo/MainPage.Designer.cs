namespace Demo
{
    partial class ToperKiosk_Sys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToperKiosk_Sys));
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
            this.translate_paneKo.SuspendLayout();
            this.translate_paneCH.SuspendLayout();
            this.translate_paneJP.SuspendLayout();
            this.translate_paneEN.SuspendLayout();
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
            this.Main_lbl.Location = new System.Drawing.Point(137, 102);
            this.Main_lbl.Name = "Main_lbl";
            this.Main_lbl.Size = new System.Drawing.Size(247, 48);
            this.Main_lbl.TabIndex = 5;
            this.Main_lbl.Text = "Topper KIOSK";
            this.Main_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // translate_paneKo
            // 
            this.translate_paneKo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translate_paneKo.BackColor = System.Drawing.Color.Transparent;
            this.translate_paneKo.BackgroundImage = global::Demo.Properties.Resources.the_button_859346_1280;
            this.translate_paneKo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.translate_paneKo.Controls.Add(this.lbl_KO);
            this.translate_paneKo.Location = new System.Drawing.Point(70, 667);
            this.translate_paneKo.Name = "translate_paneKo";
            this.translate_paneKo.Size = new System.Drawing.Size(86, 50);
            this.translate_paneKo.TabIndex = 6;
            this.translate_paneKo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneKO_MouseClick);
            // 
            // translate_paneCH
            // 
            this.translate_paneCH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translate_paneCH.BackColor = System.Drawing.Color.Transparent;
            this.translate_paneCH.BackgroundImage = global::Demo.Properties.Resources.the_button_859346_1280;
            this.translate_paneCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.translate_paneCH.Controls.Add(this.lbl_CH);
            this.translate_paneCH.Location = new System.Drawing.Point(170, 667);
            this.translate_paneCH.Name = "translate_paneCH";
            this.translate_paneCH.Size = new System.Drawing.Size(86, 50);
            this.translate_paneCH.TabIndex = 7;
            this.translate_paneCH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneCH_MouseClick);
            // 
            // translate_paneJP
            // 
            this.translate_paneJP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.translate_paneJP.BackColor = System.Drawing.Color.Transparent;
            this.translate_paneJP.BackgroundImage = global::Demo.Properties.Resources.the_button_859346_1280;
            this.translate_paneJP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.translate_paneJP.Controls.Add(this.lbl_JP);
            this.translate_paneJP.Location = new System.Drawing.Point(270, 667);
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
            this.translate_paneEN.Location = new System.Drawing.Point(370, 667);
            this.translate_paneEN.Name = "translate_paneEN";
            this.translate_paneEN.Size = new System.Drawing.Size(86, 50);
            this.translate_paneEN.TabIndex = 9;
            this.translate_paneEN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.translate_paneEN_MouseClick);
            // 
            // ManInfo_lbl
            // 
            this.ManInfo_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManInfo_lbl.AutoSize = true;
            this.ManInfo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ManInfo_lbl.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ManInfo_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManInfo_lbl.Location = new System.Drawing.Point(98, 861);
            this.ManInfo_lbl.Name = "ManInfo_lbl";
            this.ManInfo_lbl.Size = new System.Drawing.Size(328, 24);
            this.ManInfo_lbl.TabIndex = 10;
            this.ManInfo_lbl.Text = "언어를 선택하여 다음으로 넘어가기";
            // 
            // ToperKiosk_Sys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::Demo.Properties.Resources.Beauty_Nature_1_Wallpaper_1080x1920_768x1365;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 941);
            this.Controls.Add(this.ManInfo_lbl);
            this.Controls.Add(this.translate_paneEN);
            this.Controls.Add(this.translate_paneJP);
            this.Controls.Add(this.translate_paneCH);
            this.Controls.Add(this.translate_paneKo);
            this.Controls.Add(this.Main_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ToperKiosk_Sys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToperKiosk_SYS";
            this.Load += new System.EventHandler(this.ToperKiosk_Sys_Load);
            this.translate_paneKo.ResumeLayout(false);
            this.translate_paneKo.PerformLayout();
            this.translate_paneCH.ResumeLayout(false);
            this.translate_paneCH.PerformLayout();
            this.translate_paneJP.ResumeLayout(false);
            this.translate_paneJP.PerformLayout();
            this.translate_paneEN.ResumeLayout(false);
            this.translate_paneEN.PerformLayout();
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
    }
}

