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
    public partial class LoadingPage : Form
    {
        #region 'Field'
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;

        System.Windows.Forms.Timer Endtimer = new System.Windows.Forms.Timer();
        int end_time = 7;
        #endregion


        #region 'Init'
        public LoadingPage(MakingTopperImage ti)
        {
            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거
            Endtimer.Tick += new EventHandler(endtimerHandler);
            Endtimer.Interval = 1000;
            InitializeComponent();

            Endtimer.Enabled = true;
            //new Macro(ti.getSavedimagename()); // 매크로 시작 (임시로 막아둠 ==> 주석문 풀면 해제)
        }
        #endregion



        #region 'Propertise'
    
        private void endtimerHandler(object sender, EventArgs e)
        {
            end_time--;

            if (end_time == 0)
            {
                this.Visible = false;
                this.FormSendEvent(1);
            }
        }
        #endregion
    }
}
