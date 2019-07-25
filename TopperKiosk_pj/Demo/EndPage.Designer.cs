namespace Demo
{
    partial class EndPage
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
            this.tooltip_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_UserInfoText = new System.Windows.Forms.Label();
            this.label_PayTypeInfoText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitinfo_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tooltip_lbl
            // 
            this.tooltip_lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tooltip_lbl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tooltip_lbl.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold);
            this.tooltip_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.tooltip_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tooltip_lbl.Location = new System.Drawing.Point(-3, -4);
            this.tooltip_lbl.Name = "tooltip_lbl";
            this.tooltip_lbl.Size = new System.Drawing.Size(1920, 40);
            this.tooltip_lbl.TabIndex = 1;
            this.tooltip_lbl.Text = "TopperKiosk";
            this.tooltip_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1920, 101);
            this.label1.TabIndex = 21;
            this.label1.Text = "제작 완료";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_UserInfoText
            // 
            this.label_UserInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_UserInfoText.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_UserInfoText.Location = new System.Drawing.Point(0, 630);
            this.label_UserInfoText.Name = "label_UserInfoText";
            this.label_UserInfoText.Size = new System.Drawing.Size(1920, 63);
            this.label_UserInfoText.TabIndex = 22;
            this.label_UserInfoText.Text = "토퍼 양쪽 비닐을 제거하시면 더 깔끔합니다.";
            this.label_UserInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_PayTypeInfoText
            // 
            this.label_PayTypeInfoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_PayTypeInfoText.Location = new System.Drawing.Point(0, 490);
            this.label_PayTypeInfoText.Name = "label_PayTypeInfoText";
            this.label_PayTypeInfoText.Size = new System.Drawing.Size(1920, 63);
            this.label_PayTypeInfoText.TabIndex = 23;
            this.label_PayTypeInfoText.Text = "제작이 완료 되었습니다.";
            this.label_PayTypeInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1920, 63);
            this.label2.TabIndex = 24;
            this.label2.Text = "밑에서 완성된 토퍼를 수령해주세요 ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = global::Demo.Properties.Resources._checked;
            this.pictureBox1.InitialImage = global::Demo.Properties.Resources._checked;
            this.pictureBox1.Location = new System.Drawing.Point(835, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // exitinfo_lbl
            // 
            this.exitinfo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exitinfo_lbl.Location = new System.Drawing.Point(0, 1000);
            this.exitinfo_lbl.Name = "exitinfo_lbl";
            this.exitinfo_lbl.Size = new System.Drawing.Size(1920, 63);
            this.exitinfo_lbl.TabIndex = 26;
            this.exitinfo_lbl.Text = "15 초 후에 처음으로 돌아갑니다";
            this.exitinfo_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1064);
            this.ControlBox = false;
            this.Controls.Add(this.exitinfo_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_PayTypeInfoText);
            this.Controls.Add(this.label_UserInfoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tooltip_lbl);
            this.Name = "EndPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tooltip_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_UserInfoText;
        private System.Windows.Forms.Label label_PayTypeInfoText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exitinfo_lbl;
    }
}