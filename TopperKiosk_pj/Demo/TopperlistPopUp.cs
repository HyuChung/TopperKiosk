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
    public partial class TopperlistPopUp : Form
    {

        #region 'Field'
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;
        string image_name ;
        int imageNum=0, pageNum, price;
        #endregion



        #region 'Init'
        public TopperlistPopUp(string image_name, int imageNum, int pageNum, int price)
        {
            this.price = price;
            this.image_name = image_name;
            this.imageNum = imageNum;
            this.pageNum = pageNum;

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거

            showingimageChage(this.imageNum, this.pageNum);
            this.showingDesign.Left = (this.ClientSize.Width - showingDesign.Width) / 2;
            this.disInfo_pane.Left = (this.ClientSize.Width - disInfo_pane.Width) / 2;

            this.disDesginName_lbl.Text = image_name;
            this.dismoney_lbl.Text = price.ToString();
        }
        #endregion



        #region 'Propertise'
        public void showingimageChage(int imageNum, int pageNum)//보여지는 이미지 가져오기
        {
            TopperList topper = new TopperList();

            switch (pageNum)
            {
                case 1:
                    this.showingDesign.Image = topper.TourImagelist.Images[imageNum];
                    break;
                case 2:
                    this.showingDesign.Image = topper.FoodImagelist.Images[imageNum];
                    break;
                case 3:
                    this.showingDesign.Image = topper.MemorialImageList.Images[imageNum];
                    break;
                case 4:
                    this.showingDesign.Image = topper.RecommendImagelist.Images[imageNum];
                    break;
            }
        }
        #endregion



        #region 'Next/Exit Setting'
        private void next_pane_Click(object sender, EventArgs e)
        {
            this.FormSendEvent(1);
            this.Visible = false;
        }

        private void exit_pane_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
