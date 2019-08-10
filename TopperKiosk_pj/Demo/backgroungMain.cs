using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * README!
 * 
 * 폼 바인딩을 위한 백그라운드
 * 이벤트를 주고 받으면서 이동
 * 
 * 폼 이동시 패이드인아웃 작업 필요
 * 전체적인 변수명 통일 필요
 * 
*/

namespace Demo
{
    public partial class backgroungMain : Form
    {

        #region 'Field' 
        public string image_name = "None";
        public int pramiter, imageNum = 0, pageNum = 0, textindex_column_1 = 0, textindex_column_2 = 0, price = 6000;

        public string[,] topperText = new string[2, 4] { { "세미콜론팀", "감사합니다", "사랑합니다" , "SemmiColon" } ,
                                                    {"화이팅","선생님","부모님","Team" } };
        #endregion



        #region 'Init'
        public backgroungMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거

            MainPage mp = new MainPage();
            mp.FormSendEvent += new MainPage.FormSendDataHandler(mainfromlisner);
            mp.Owner = this;
            AddForms2Panel(mp);

            this.dispane.Left = (this.ClientSize.Width - this.dispane.Width) / 2;
            this.dispane.Top = (this.ClientSize.Height - this.ClientSize.Height) / 2;
        }
        #endregion



        #region 'Properties'
        private void AddForms2Panel(Form form) // 폼 패널에 붙이기
        {
            form.TopLevel = false;
            dispane.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        #endregion



        #region 'Binding Propertise'
        private void mainfromlisner(object sender) // 메인 이동 (메인->토퍼리스트)
        {
            this.pramiter = (int)sender;
            TopperList TL = new TopperList(pramiter);
            TL.FormSendEvent += new TopperList.FormSendDataHandler(topperlistlisner);
            TL.Owner = this;
            AddForms2Panel(TL);
        }

        private void topperlistlisner(object sender) // 토퍼 리스트 이동 (메인<-토퍼리스트->토퍼 설정)
        {
            if ((int)sender == 1) // 다음-이전
            {
                SettingPage SP = new SettingPage(image_name, price, imageNum, pageNum);
                SP.FormSendEvent += new SettingPage.FormSendDataHandler(settinglisner);
                SP.Owner = this;
                AddForms2Panel(SP);
            }
            else
            {
                MainPage mp = new MainPage();
                mp.FormSendEvent += new MainPage.FormSendDataHandler(mainfromlisner);
                mp.Owner = this;
                AddForms2Panel(mp);
            }

        }

        private void settinglisner(object sender) // 토퍼 설정 이동 (토퍼리스트<-토퍼 설정->결재)
        {
            if((int)sender == 1) // 다음-이전 
            {
                PayPage PP = new PayPage(image_name, price, imageNum, pageNum, textindex_column_1, textindex_column_2);
                PP.FormSendEvent += new PayPage.FormSendDataHandler(paylisner);
                PP.Owner = this;
                AddForms2Panel(PP);
            }
            else
            {
                TopperList TL = new TopperList(9);
                TL.FormSendEvent += new TopperList.FormSendDataHandler(topperlistlisner);
                TL.Owner = this;
                AddForms2Panel(TL);
            }
            
        }

        private void paylisner(object sender) // 결제(확인) 이동 (토퍼 설정<-결재->대기)
        {
            if ((int)sender == 1) // 다음-이전
            {
                WatingPage wp = new WatingPage(image_name, price, imageNum, pageNum, textindex_column_1, textindex_column_2);
                wp.FormSendEvent += new WatingPage.FormSendDataHandler(watinglisner);
                wp.Owner = this;
                AddForms2Panel(wp);
            }
            else
            {
                SettingPage SP = new SettingPage(image_name, price, imageNum, pageNum);
                SP.FormSendEvent += new SettingPage.FormSendDataHandler(settinglisner);
                SP.Owner = this;
                AddForms2Panel(SP);
            }
        }

        private void watinglisner(object sender) // 대기 이동 (대기->끝)
        {
            EndPage ep = new EndPage();
            ep.FormSendEvent += new EndPage.FormSendDataHandler(endpagelisner);
            ep.Owner = this;
            AddForms2Panel(ep);
        }

        private void endpagelisner(object sender) // 끝 이동 (끝->메인)
        {
            MainPage mp = new MainPage();
            mp.FormSendEvent += new MainPage.FormSendDataHandler(mainfromlisner);
            mp.Owner = this;
            AddForms2Panel(mp);
        }
        #endregion


    }
}
