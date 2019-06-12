namespace Demo
{
    partial class uc_KeyBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.spc_Font = new System.Windows.Forms.SplitContainer();
            this.lbl_SetFont = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_SetFont = new System.Windows.Forms.ComboBox();
            this.pn_Keyboard = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Font)).BeginInit();
            this.spc_Font.Panel1.SuspendLayout();
            this.spc_Font.Panel2.SuspendLayout();
            this.spc_Font.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.spc_Font);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 46);
            this.panel1.TabIndex = 0;
            // 
            // spc_Font
            // 
            this.spc_Font.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Font.Location = new System.Drawing.Point(0, 0);
            this.spc_Font.Name = "spc_Font";
            // 
            // spc_Font.Panel1
            // 
            this.spc_Font.Panel1.Controls.Add(this.lbl_SetFont);
            // 
            // spc_Font.Panel2
            // 
            this.spc_Font.Panel2.Controls.Add(this.button1);
            this.spc_Font.Panel2.Controls.Add(this.cb_SetFont);
            this.spc_Font.Size = new System.Drawing.Size(538, 44);
            this.spc_Font.SplitterDistance = 248;
            this.spc_Font.SplitterWidth = 15;
            this.spc_Font.TabIndex = 0;
            // 
            // lbl_SetFont
            // 
            this.lbl_SetFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SetFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_SetFont.ForeColor = System.Drawing.Color.White;
            this.lbl_SetFont.Location = new System.Drawing.Point(0, 0);
            this.lbl_SetFont.Name = "lbl_SetFont";
            this.lbl_SetFont.Size = new System.Drawing.Size(248, 44);
            this.lbl_SetFont.TabIndex = 0;
            this.lbl_SetFont.Text = "폰트 선택";
            this.lbl_SetFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(232, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cb_SetFont
            // 
            this.cb_SetFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_SetFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_SetFont.FormattingEnabled = true;
            this.cb_SetFont.Location = new System.Drawing.Point(3, 4);
            this.cb_SetFont.Name = "cb_SetFont";
            this.cb_SetFont.Size = new System.Drawing.Size(136, 37);
            this.cb_SetFont.TabIndex = 0;
            this.cb_SetFont.Text = "굴림체";
            // 
            // pn_Keyboard
            // 
            this.pn_Keyboard.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pn_Keyboard.BackgroundImage = global::Demo.Properties.Resources.Android_Keyboard;
            this.pn_Keyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_Keyboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Keyboard.Location = new System.Drawing.Point(0, 46);
            this.pn_Keyboard.Name = "pn_Keyboard";
            this.pn_Keyboard.Size = new System.Drawing.Size(540, 354);
            this.pn_Keyboard.TabIndex = 1;
            // 
            // uc_KeyBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_Keyboard);
            this.Controls.Add(this.panel1);
            this.Name = "uc_KeyBoard";
            this.Size = new System.Drawing.Size(540, 400);
            this.panel1.ResumeLayout(false);
            this.spc_Font.Panel1.ResumeLayout(false);
            this.spc_Font.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Font)).EndInit();
            this.spc_Font.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer spc_Font;
        private System.Windows.Forms.Label lbl_SetFont;
        private System.Windows.Forms.ComboBox cb_SetFont;
        private System.Windows.Forms.Panel pn_Keyboard;
        private System.Windows.Forms.Button button1;
    }
}
