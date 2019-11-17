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
    public partial class WatingPage : Form
    {

        #region 'Field'
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;

        System.Windows.Forms.Timer icontimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer Endtimer = new System.Windows.Forms.Timer();

        string image_name = "None", left_time_info = "예상 남은 시간 : ",left_time_min = "분 ", left_time_sec ="초";
        int imageNum = 0, pageNum = 0, textindex_column_1 = 0, textindex_column_2 = 0, price = 0;

        int icon_tic =0, end_time =10; // 기본 시간 2분

        MakingTopperImage ti;
        #endregion



        #region 'Init'
        public WatingPage(string image_name, int price, int imageNum, int pageNum,  MakingTopperImage ti)
        {
            this.image_name = image_name;
            this.imageNum = imageNum;
            this.pageNum = pageNum;
            this.price = price;
            this.ti = ti;

            icontimer.Tick += new EventHandler(icontimerHandler);
            icontimer.Interval = 2000;
            Endtimer.Tick += new EventHandler(endtimerHandler);
            Endtimer.Interval = 1000;

            InitializeComponent();
            thanks_pane.Left = 1100;
            thanks_pane.Top = 420;
            thanks_pane.Visible = false;
            imageDisplayMakeChager();
            expectTime();
            this.lazercuttingDis.Image = Icon.Images[0];
            icontimer.Enabled = true;
            Endtimer.Enabled = true;

            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거
            this.disDesginName_lbl.Text = ti.getimagename() ; // 이미지 이름
            this.disUserText_lbl.Text = ti.getImagetext(); // 이미지 텍스트
            //this.dismoney_lbl.Text = price.ToString();
            new Macro(ti.getSavedimagename()); // 매크로 시작
        }
        #endregion



        #region 'Propertise'
        private void imageDisplayMakeChager() // 만들어진 토퍼로 이미지 변경(임시)
        {
            ti.setImage2PB(showingDesign);
            //showingDesign.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/" + "new" + ".png"); // 상대주소로 변경 필요
        }

        private void expectTime() // 예상 대기시간 카운터
        {
            int min =0, sec=0; 

            if(end_time > 60)
            {
                min = end_time / 60;
                sec = end_time % 60;
                this.lefttime_lbl.Text = left_time_info + min + left_time_min + sec + left_time_sec;
            }
            else
            {
                this.lefttime_lbl.Text = left_time_info + end_time + left_time_sec;
            }
        }

        private void btncolorchanger(int index, int order) // 버튼 색상 변경(설문)
        {
            if(index == 0)
            {
                switch (order)
                {
                    case 1:
                        mansex_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        girlsex_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 2:
                        mansex_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        girlsex_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        break;
                }
            }else if(index == 1)
            {
                switch (order)
                {
                    case 1:
                        age10_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        age20_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age30_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age40_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age50_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age60_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 2:
                        age10_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age20_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        age30_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age40_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age50_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age60_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 3:
                        age10_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age20_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age30_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        age40_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age50_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age60_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 4:
                        age10_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age20_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age30_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age40_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        age50_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age60_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 5:
                        age10_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age20_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age30_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age40_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age50_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        age60_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 6:
                        age10_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age20_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age30_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age40_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age50_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        age60_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        break;
                }
            }
            else
            {
                switch (order)
                {
                    case 1:
                        certifiPurpose_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        monumentalPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        curiocityPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        collectionPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        annivercityPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 2:
                        certifiPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        monumentalPurpose_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        curiocityPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        collectionPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        annivercityPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 3:
                        certifiPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        monumentalPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        curiocityPurpose_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        collectionPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        annivercityPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 4:
                        certifiPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        monumentalPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        curiocityPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        collectionPurpose_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        annivercityPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 5:
                        certifiPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        monumentalPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        curiocityPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        collectionPurpose_btn.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        annivercityPurpose_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        break;
                }
            }
        }
        #endregion



        #region 'ServeyButton Setting'
        private void mansex_btn_Click(object sender, EventArgs e) 
        {
            btncolorchanger(0, 1);
        }

        private void girlsex_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(0, 2);
        }

        private void age10_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(1, 1);
        }

        private void age20_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(1, 2);
        }

        private void age30_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(1, 3);
        }

        private void age40_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(1, 4);
        }

        private void age50_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(1, 5);
        }

        private void age60_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(1, 6);
        }

        private void certifiPurpose_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(2, 1);
        }

        private void monumentalPurpose_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(2, 2);
        }

        private void curiocityPurpose_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(2, 3);
        }

        private void collectionPurpose_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(2, 4);
        }

        private void annivercityPurpose_btn_Click(object sender, EventArgs e)
        {
            btncolorchanger(2, 5);
        }

        private void sumit_btn_Click(object sender, EventArgs e)
        {

            survey_pane.Visible = false;
            thanks_pane.Visible = true;
        }
        #endregion



        #region 'Timer Setting'
        private void icontimerHandler(object sender, EventArgs e) // 레이져 아이콘 이미지 변경용 타이머
        {
            if (icon_tic == 0)
            {
                this.lazercuttingDis.Image = Icon.Images[1];
                icon_tic = 1;
            }
            else
            {
                this.lazercuttingDis.Image = Icon.Images[0];
                icon_tic = 0;
            }
            
        }

        private void endtimerHandler(object sender, EventArgs e) // 예상 대기시간 타이머
        {
            end_time--;
            expectTime();
            if(end_time == 0)
            {
                this.Visible = false;
                this.FormSendEvent(1);
            }
        }
        #endregion

    }
}
