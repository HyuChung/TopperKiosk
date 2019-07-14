using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Demo
{
    public partial class TopperList : Form
    {
        int valPage = 1, numpage = 1;
        int[,] initimage = new int[3, 3] { {0,0,0},{0,0,0},{0,0,0} };
        string selected_image ="None";
        int price = 0;
 
        public TopperList(int lenguage)
        {

            
            if (lenguage == 1) //다국어 처리
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh");
            }
            else if(lenguage == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
            }
            else if(lenguage == 3)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ko");
            }
            InitializeComponent();
            
        }

        private void TopperList_Load(object sender, EventArgs e)
        {

        }

        private void exit_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            MainPage newMain = new MainPage();
            newMain.ShowDialog();
            
        }

        private void next_pane_Click(object sender, EventArgs e)
        {
            if (selected_image.Equals("None")) //이미지 선택 확인
            {
                this.Visible = false;
                SettingPage newsettingPage = new SettingPage(selected_image,price);
                newsettingPage.ShowDialog();
            }
            else 
            {
                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void menu1_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.manu1_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;
           
            this.menu1_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
        }

        private void menu2_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu2_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

            this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu2_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
        }

        private void menu3_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu3_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

            this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu3_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
        }

        private void pic_1_1_Paint(object sender, PaintEventArgs e)
        {
            if (pic_1_1.Tag == null) { pic_1_1.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_1_1.ClientRectangle, (Color)pic_1_1.Tag, ButtonBorderStyle.Solid);
        }
        
        private void pic_1_2_Paint(object sender, PaintEventArgs e)
        {
            if (pic_1_2.Tag == null) { pic_1_2.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_1_2.ClientRectangle, (Color)pic_1_2.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_1_3_Paint(object sender, PaintEventArgs e)
        {
            if (pic_1_3.Tag == null) { pic_1_3.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_1_3.ClientRectangle, (Color)pic_1_3.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_2_1_Paint(object sender, PaintEventArgs e)
        {
            if (pic_2_1.Tag == null) { pic_2_1.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_2_1.ClientRectangle, (Color)pic_2_1.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_2_2_Paint(object sender, PaintEventArgs e)
        {
            if (pic_2_2.Tag == null) { pic_2_2.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_2_2.ClientRectangle, (Color)pic_2_2.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_2_3_Paint(object sender, PaintEventArgs e)
        {
            if (pic_2_3.Tag == null) { pic_2_3.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_2_3.ClientRectangle, (Color)pic_2_3.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_3_1_Paint(object sender, PaintEventArgs e)
        {
            if (pic_3_1.Tag == null) { pic_3_1.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_3_1.ClientRectangle, (Color)pic_3_1.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_3_2_Paint(object sender, PaintEventArgs e)
        {
            if (pic_3_2.Tag == null) { pic_3_2.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_3_2.ClientRectangle, (Color)pic_3_2.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_3_3_Paint(object sender, PaintEventArgs e)
        {
            if (pic_3_3.Tag == null) { pic_3_3.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_3_3.ClientRectangle, (Color)pic_3_3.Tag, ButtonBorderStyle.Solid);
        }


        private void pic_1_1_Click(object sender, EventArgs e)
        {
            if ((Color)pic_1_1.Tag == SystemColors.GradientInactiveCaption) { pic_1_1.Tag = Color.Red; }
            pic_1_1.Refresh();
        }

        

        private void menu4_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu4_lbl.ForeColor = System.Drawing.SystemColors.ControlText;

            this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu4_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }
    }
}
