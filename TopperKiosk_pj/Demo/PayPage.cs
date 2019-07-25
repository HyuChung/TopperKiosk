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
    public partial class PayPage : Form
    {

        #region 'Field'
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;
        string image_name ="None";
        int imageNum = 0, pageNum = 0, textindex_column_1 = 0, textindex_column_2 = 0, price=0;

        string[,] topperText = new string[2, 4] { { "세미콜론팀", "감사합니다", "사랑합니다" , "SemmiColon" } ,
                                                    {"화이팅","선생님","부모님","Team" } };
        #endregion



        #region 'Init'
        public PayPage(string image_name, int price, int imageNum, int pageNum, int textindex_column_1, int textindex_column_2)
        {
            this.image_name = image_name;
            this.imageNum = imageNum;
            this.pageNum = pageNum;
            this.price = price;
            this.textindex_column_1 = textindex_column_1;
            this.textindex_column_2 = textindex_column_2;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거

            imageDisplayMakeChager();
            this.showingDesign.Top = (this.ClientSize.Height - showingDesign.Height) / 2;//중앙정렬(세로)
            this.disInfo_pane.Top = (this.ClientSize.Height - disInfo_pane.Height) / 2;//중앙정렬(세로)
            this.disDesginName_lbl.Text = image_name;
            this.disUserText_lbl.Text = topperText[0,textindex_column_1] +" "+ topperText[1,textindex_column_2];
            this.dismoney_lbl.Text = price.ToString();

        }
        #endregion



        #region 'Propertise'
        private void imageDisplayMakeChager() //만들어진 토퍼로 이미지 변경(임시)
        {
            SettingPage sp = new SettingPage();

            if (textindex_column_1 == 0 && textindex_column_2 == 0)
            {
                this.showingDesign.Image = sp.makedimage.Images[0];
            }
            else if (textindex_column_1 == 1 && textindex_column_2 == 1)
            {
                this.showingDesign.Image = sp.makedimage.Images[1];
            }
            else if (textindex_column_1 == 1 && textindex_column_2 == 2)
            {
                this.showingDesign.Image = sp.makedimage.Images[2];
            }
            else if (textindex_column_1 == 2 && textindex_column_2 == 1)
            {
                this.showingDesign.Image = sp.makedimage.Images[3];
            }
            else if (textindex_column_1 == 2 && textindex_column_2 == 2)
            {
                this.showingDesign.Image = sp.makedimage.Images[4];
            }
            else if (textindex_column_1 == 3 && textindex_column_2 == 3)
            {
                this.showingDesign.Image = sp.makedimage.Images[5];
            }
        }
        #endregion



        #region 'Next/Exit Setting'
        private void next_pane_Click(object sender, EventArgs e)//다음 화면
        {
            this.FormSendEvent(1);
            this.Visible = false;
            
        }

        private void exit_pane_Click(object sender, EventArgs e)//이전 화면
        {
            this.FormSendEvent(0);
            this.Visible = false;

        }
        #endregion

    }
}
