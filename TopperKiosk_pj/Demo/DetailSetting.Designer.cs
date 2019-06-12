namespace Demo
{
    partial class DetailSetting
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pn_Contents = new System.Windows.Forms.Panel();
            this.pn_ContentsDown = new System.Windows.Forms.Panel();
            this.pb_Preview = new System.Windows.Forms.PictureBox();
            this.lbl_TextInfo = new System.Windows.Forms.Label();
            this.tpnl_SettingView = new System.Windows.Forms.TableLayoutPanel();
            this.pb_SelectedTopper = new System.Windows.Forms.PictureBox();
            this.tpnl_TextSetting = new System.Windows.Forms.TableLayoutPanel();
            this.tb_TextUp = new System.Windows.Forms.TextBox();
            this.tb_TextDown = new System.Windows.Forms.TextBox();
            this.tpnl_PreviousNext = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.pn_Contents.SuspendLayout();
            this.pn_ContentsDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Preview)).BeginInit();
            this.tpnl_SettingView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectedTopper)).BeginInit();
            this.tpnl_TextSetting.SuspendLayout();
            this.tpnl_PreviousNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Black;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(540, 76);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "상세 설정";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_Contents
            // 
            this.pn_Contents.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pn_Contents.Controls.Add(this.pn_ContentsDown);
            this.pn_Contents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Contents.Location = new System.Drawing.Point(0, 76);
            this.pn_Contents.Name = "pn_Contents";
            this.pn_Contents.Size = new System.Drawing.Size(540, 844);
            this.pn_Contents.TabIndex = 1;
            // 
            // pn_ContentsDown
            // 
            this.pn_ContentsDown.Controls.Add(this.pb_Preview);
            this.pn_ContentsDown.Controls.Add(this.lbl_TextInfo);
            this.pn_ContentsDown.Controls.Add(this.tpnl_SettingView);
            this.pn_ContentsDown.Controls.Add(this.tpnl_PreviousNext);
            this.pn_ContentsDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_ContentsDown.Location = new System.Drawing.Point(0, 0);
            this.pn_ContentsDown.Name = "pn_ContentsDown";
            this.pn_ContentsDown.Size = new System.Drawing.Size(540, 844);
            this.pn_ContentsDown.TabIndex = 1;
            // 
            // pb_Preview
            //
            this.pb_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Preview.Location = new System.Drawing.Point(0, 253);
            this.pb_Preview.Name = "pb_Preview";
            this.pb_Preview.Size = new System.Drawing.Size(540, 525);
            this.pb_Preview.TabIndex = 5;
            this.pb_Preview.TabStop = false;
            // 
            // lbl_TextInfo
            // 
            this.lbl_TextInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_TextInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TextInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_TextInfo.Location = new System.Drawing.Point(0, 200);
            this.lbl_TextInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_TextInfo.Name = "lbl_TextInfo";
            this.lbl_TextInfo.Size = new System.Drawing.Size(540, 53);
            this.lbl_TextInfo.TabIndex = 4;
            this.lbl_TextInfo.Text = "<글자 입력 정보>";
            this.lbl_TextInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpnl_SettingView
            // 
            this.tpnl_SettingView.ColumnCount = 2;
            this.tpnl_SettingView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.22222F));
            this.tpnl_SettingView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.77778F));
            this.tpnl_SettingView.Controls.Add(this.pb_SelectedTopper, 0, 0);
            this.tpnl_SettingView.Controls.Add(this.tpnl_TextSetting, 1, 0);
            this.tpnl_SettingView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnl_SettingView.Location = new System.Drawing.Point(0, 0);
            this.tpnl_SettingView.Name = "tpnl_SettingView";
            this.tpnl_SettingView.RowCount = 1;
            this.tpnl_SettingView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_SettingView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_SettingView.Size = new System.Drawing.Size(540, 200);
            this.tpnl_SettingView.TabIndex = 3;
            // 
            // pb_SelectedTopper
            // 
            this.pb_SelectedTopper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_SelectedTopper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_SelectedTopper.Location = new System.Drawing.Point(0, 0);
            this.pb_SelectedTopper.Margin = new System.Windows.Forms.Padding(0);
            this.pb_SelectedTopper.Name = "pb_SelectedTopper";
            this.pb_SelectedTopper.Size = new System.Drawing.Size(200, 200);
            this.pb_SelectedTopper.TabIndex = 0;
            this.pb_SelectedTopper.TabStop = false;
            // 
            // tpnl_TextSetting
            // 
            this.tpnl_TextSetting.ColumnCount = 1;
            this.tpnl_TextSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_TextSetting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_TextSetting.Controls.Add(this.tb_TextUp, 0, 0);
            this.tpnl_TextSetting.Controls.Add(this.tb_TextDown, 0, 1);
            this.tpnl_TextSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpnl_TextSetting.Location = new System.Drawing.Point(200, 0);
            this.tpnl_TextSetting.Margin = new System.Windows.Forms.Padding(0);
            this.tpnl_TextSetting.Name = "tpnl_TextSetting";
            this.tpnl_TextSetting.RowCount = 2;
            this.tpnl_TextSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_TextSetting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_TextSetting.Size = new System.Drawing.Size(340, 200);
            this.tpnl_TextSetting.TabIndex = 1;
            // 
            // tb_TextUp
            // 
            this.tb_TextUp.BackColor = System.Drawing.Color.DarkGray;
            this.tb_TextUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TextUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.tb_TextUp.Location = new System.Drawing.Point(0, 0);
            this.tb_TextUp.Margin = new System.Windows.Forms.Padding(0);
            this.tb_TextUp.Name = "tb_TextUp";
            this.tb_TextUp.Size = new System.Drawing.Size(340, 75);
            this.tb_TextUp.TabIndex = 0;
            this.tb_TextUp.Text = "Happy";
            this.tb_TextUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_TextDown
            // 
            this.tb_TextDown.BackColor = System.Drawing.Color.DarkGray;
            this.tb_TextDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TextDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_TextDown.Location = new System.Drawing.Point(0, 100);
            this.tb_TextDown.Margin = new System.Windows.Forms.Padding(0);
            this.tb_TextDown.Name = "tb_TextDown";
            this.tb_TextDown.Size = new System.Drawing.Size(340, 75);
            this.tb_TextDown.TabIndex = 1;
            this.tb_TextDown.Text = "Birthday";
            this.tb_TextDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpnl_PreviousNext
            // 
            this.tpnl_PreviousNext.ColumnCount = 2;
            this.tpnl_PreviousNext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_PreviousNext.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_PreviousNext.Controls.Add(this.btn_Previous, 0, 0);
            this.tpnl_PreviousNext.Controls.Add(this.btn_Next, 1, 0);
            this.tpnl_PreviousNext.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tpnl_PreviousNext.Location = new System.Drawing.Point(0, 778);
            this.tpnl_PreviousNext.Name = "tpnl_PreviousNext";
            this.tpnl_PreviousNext.RowCount = 1;
            this.tpnl_PreviousNext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_PreviousNext.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpnl_PreviousNext.Size = new System.Drawing.Size(540, 66);
            this.tpnl_PreviousNext.TabIndex = 1;
            // 
            // btn_Previous
            // 
            this.btn_Previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Previous.Location = new System.Drawing.Point(3, 3);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(264, 60);
            this.btn_Previous.TabIndex = 0;
            this.btn_Previous.Text = "이     전";
            this.btn_Previous.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Next.Location = new System.Drawing.Point(273, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(264, 60);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "다     음";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // form_DetailSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 920);
            this.Controls.Add(this.pn_Contents);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_DetailSetting";
            this.Text = "DetailSetting";
            this.pn_Contents.ResumeLayout(false);
            this.pn_ContentsDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Preview)).EndInit();
            this.tpnl_SettingView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_SelectedTopper)).EndInit();
            this.tpnl_TextSetting.ResumeLayout(false);
            this.tpnl_TextSetting.PerformLayout();
            this.tpnl_PreviousNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pn_Contents;
        private System.Windows.Forms.Panel pn_ContentsDown;
        private System.Windows.Forms.TableLayoutPanel tpnl_PreviousNext;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_TextInfo;
        private System.Windows.Forms.TableLayoutPanel tpnl_SettingView;
        private System.Windows.Forms.PictureBox pb_SelectedTopper;
        private System.Windows.Forms.TableLayoutPanel tpnl_TextSetting;
        private System.Windows.Forms.PictureBox pb_Preview;
        private System.Windows.Forms.TextBox tb_TextUp;
        private System.Windows.Forms.TextBox tb_TextDown;
    }
}

