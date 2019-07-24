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
        string image_name ="None", usertext ="None";
        int imageNum , pageNum , price;

       
        public PayPage(string imagename, string usertext, int price, int imageNum, int pageNum)
        {
            this.usertext = usertext;
            this.image_name = imagename;
            this.imageNum = imageNum;
            this.pageNum = pageNum;

            InitializeComponent();
            showingimageChage(imageNum ,pageNum);

            this.showingDesign.Left = (this.ClientSize.Width - showingDesign.Width) / 2;//중앙정렬
            this.disInfo_pane.Left = (this.ClientSize.Width - disInfo_pane.Width) / 2;//중앙정렬
            this.disDesginName_lbl.Text = image_name;
            this.disUserText_lbl.Text = usertext;
            this.dismoney_lbl.Text = price.ToString();
            
        }

        public void showingimageChage(int imageNum, int pageNum)//보여지는 이미지 가져오기
        {
            TopperList topper = new TopperList();

            switch (pageNum)
            {
                case 1:
                    this.showingDesign.Image = topper.TourImagelist.Images[imageNum];
                    image_name = topper.TourImagelist.Images.Keys[imageNum].ToString();
                    break;
                case 2:
                    this.showingDesign.Image = topper.FoodImagelist.Images[imageNum];
                    image_name = topper.FoodImagelist.Images.Keys[imageNum].ToString();
                    break;
                case 3:
                    this.showingDesign.Image = topper.MemorialImageList.Images[imageNum];
                    image_name = topper.MemorialImageList.Images.Keys[imageNum].ToString();
                    break;
                case 4:
                    this.showingDesign.Image = topper.RecommendImagelist.Images[imageNum];
                    image_name = topper.RecommendImagelist.Images.Keys[imageNum].ToString();
                    break;
            }
        }


        private void next_pane_Click(object sender, EventArgs e)//다음 화면
        {
            this.Visible = false;
            WatingPage newSettingPage = new WatingPage(imageNum, pageNum);
            newSettingPage.ShowDialog();
        }

        private void exit_pane_Click(object sender, EventArgs e)//이전 화면
        {
            this.Visible = false;
            SettingPage newSettingPage = new SettingPage(image_name, usertext ,price,imageNum, pageNum);
            newSettingPage.ShowDialog();
        }
    }
}
