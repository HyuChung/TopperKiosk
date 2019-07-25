using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class EndPage : Form
    {
        System.Windows.Forms.Timer Endtimer = new System.Windows.Forms.Timer();
        int end_time = 15;
        string endinfo = " 초 후에 처음으로 돌아갑니다";

        public EndPage()
        {
            Endtimer.Tick += new EventHandler(endtimerHandler);
            Endtimer.Interval = 1000;
            InitializeComponent();

            Endtimer.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거
        }

        private void countdown()
        {
            exitinfo_lbl.Text = end_time + endinfo;
        }


        private void endtimerHandler(object sender, EventArgs e)
        {
            end_time--;
            countdown();
            if (end_time == 0)
            {
                this.Visible = false;
                MainPage mp = new MainPage();
                mp.ShowDialog();
            }
        }


    }
}
