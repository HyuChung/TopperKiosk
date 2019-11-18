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
    public partial class SettingPage : Form
    {

        #region 'Field'
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;

        System.Windows.Forms.Timer icontimer = new System.Windows.Forms.Timer();
        string imageName,insertText ;
        int imageNum = 0, pageNum = 0, price;

        string[] btnstring = {"세상을 바꾸자!" ,"Change world!", "생각을 바꾸자!", "Think Creative"};

        MakingTopperImage ti;
        #endregion



        #region 'init'
        public SettingPage() // 이미지 가져오기용
        {
            InitializeComponent();
        }

        public SettingPage(string imageName, int price, int imageNum, int pageNum) // 이미지 선택 창에서 넘어올때
        {
            this.imageName = imageName;
            this.price = price;
            this.imageNum = imageNum;
            this.pageNum = pageNum;

            InitializeComponent();

            timerInit();
            showingimageChage(pageNum, imageNum);
            roundimagebox();
            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거
            this.next_pane.Visible = false;


        }

        public SettingPage(string imageName,int price,int imageNum, int pageNum, MakingTopperImage ti) // 결재창에서 넘어올때
        {
            this.price = price;
            this.imageName = imageName;
            this.imageNum = imageNum;
            this.pageNum = pageNum;
            this.ti = ti;

            InitializeComponent();

            timerInit();
            showingimageChage(pageNum, imageNum);
            roundimagebox();

            imageDisplayMakeChager();
        }
        #endregion



        #region 'Propertise'
        private void roundimagebox()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, showingDesign.Width -2 , showingDesign.Height -2);
            Region rg = new Region(gp);

            showingDesign.Region = rg;
        }

        private void showingimageChage(int pageNum, int imageNum) // 보여지는 이미지 가져오기
        {
            this.showingDesign.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/TopperImage/TestImages/" + imageName + ".png");
        }

        /*private void transTextselectBtnColorChanger(int row,int textindex_column) //버튼 클릭시 흰색 고정
        {
            if (row == 0)
            {
                switch (textindex_column)
                {
                    case 0:
                        textselect_btn_1_1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        textselect_btn_1_2.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_3.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_4.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 1:
                        textselect_btn_1_1.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        textselect_btn_1_3.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_4.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 2:
                        textselect_btn_1_1.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_2.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        textselect_btn_1_4.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        break;
                    case 3:
                        textselect_btn_1_1.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_2.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_3.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
                        textselect_btn_1_4.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
                        break;
                }
            }
        }*/

        private void imageDisplayMakeChager() //만들어진 토퍼로 이미지 변경(임시)  ==> 변결 필요 
        {
            ti.setImage2PB(showingDesign);
        }

        private void initselectedbtn()//선택 초기화
        {
            textselect_btn_1_1.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            textselect_btn_1_2.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            textselect_btn_1_3.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            textselect_btn_1_4.IdleFillColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }

        private void timerInit()
        {
            icontimer.Tick += new EventHandler(IcontimerHandler);
            icontimer.Interval = 2000;
        }

        private void IcontimerHandler(object sender, EventArgs e)
        {
            imageDisplayMakeChager();
          
        }
        #endregion



        #region 'TextSslectBtn Setting'
        private void textselect_btn_1_1_Click(object sender, EventArgs e)
        {
            initselectedbtn();
            //transTextselectBtnColorChanger(0, textindex_column_1);
            insertTB.ResetText();
            insertTB.AppendText(btnstring[0]);

        }

        private void textselect_btn_1_2_Click(object sender, EventArgs e)
        {
            initselectedbtn();
            //transTextselectBtnColorChanger(0, textindex_column_1);
            insertTB.ResetText();
            insertTB.AppendText(btnstring[1]);
        }

        private void textselect_btn_1_3_Click(object sender, EventArgs e)
        {
            initselectedbtn();
            //transTextselectBtnColorChanger(0, textindex_column_1);
            insertTB.ResetText();
            insertTB.AppendText(btnstring[2]);
        }

        private void textselect_btn_1_4_Click(object sender, EventArgs e)
        {
            initselectedbtn();
            //transTextselectBtnColorChanger(0, textindex_column_1);
            insertTB.ResetText();
            insertTB.AppendText(btnstring[3]);
        }

        private void insertBtn_Click(object sender, EventArgs e) // 이미지 생성
        {
            insertText = insertTB.Text;
            if (imageNum == 1)
            {
                ti = new MakingTopperImage(imageName, insertText, 40, new Point(230, 590), 1);
            }
            else if (imageNum == 2)
            {
                ti = new MakingTopperImage(imageName, insertText, 40, new Point(230, 500), 1);
            }
            else if (imageNum == 3)
            {
                ti = new MakingTopperImage(imageName, insertText, 40, new Point(230, 585), 1);
            }
            else
            {
                ti = new MakingTopperImage(imageName, insertText, 40, new Point(230, 570), 1);
            }
            ti.setImage2PB(showingDesign);
            this.next_pane.Visible = true;

        }
        #endregion



        #region 'Next/Exit Setting'
        private void exit_pane_Click(object sender, EventArgs e)//이전 화면
        {
            this.FormSendEvent(0);
            this.Visible = false;

        }

        private void next_pane_Click(object sender, EventArgs e)//다음화면
        {
            ((BackgroungMain)(this.Owner)).ti = ti;
            this.FormSendEvent(1);
            this.Visible = false;
        }
        #endregion

    }
}
