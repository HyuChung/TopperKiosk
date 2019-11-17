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
        MakingTopperImage ti;

        #endregion



        #region 'Init'
        public PayPage(string image_name, int price, int imageNum, int pageNum, MakingTopperImage ti)
        {
            this.image_name = image_name;
            this.imageNum = imageNum;
            this.pageNum = pageNum;
            this.price = price;
            this.ti = ti;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거

            imageDisplayMakeChager();
            this.showingDesign.Top = (this.ClientSize.Height - showingDesign.Height) / 2; // 중앙정렬(세로)
            this.disInfo_pane.Top = (this.ClientSize.Height - disInfo_pane.Height) / 2; // 중앙정렬(세로)
            this.disDesginName_lbl.Text = ti.getimagename(); // 이미지 이름
            this.disUserText_lbl.Text = ti.getImagetext(); // 이미지 텍스트
            //this.dismoney_lbl.Text = price.ToString();

        }
        #endregion



        #region 'Propertise'
        private void imageDisplayMakeChager() // 만들어진 토퍼로 이미지 변경
        {
            ti.setImage2PB(showingDesign);
        }
        #endregion



        #region 'Next/Exit Setting'
        private void next_pane_Click(object sender, EventArgs e) // 다음 화면
        {
            this.FormSendEvent(1);
            this.Visible = false;
            
        }

        private void exit_pane_Click(object sender, EventArgs e) // 이전 화면
        {
            this.FormSendEvent(0);
            this.Visible = false;

        }
        #endregion

    }
}
