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
        string imageName , userText = "None";
        int imageNum = 0, pageNum = 0, price;

        public SettingPage(string imageName, int price, int imageNum, int pageNum) // 이미지 선택 창에서 넘어올때
        {
            this.imageName = imageName;
            this.price = price;
            this.imageNum = imageNum;
            this.pageNum = pageNum;

            InitializeComponent();

            showingimageChage(pageNum, imageNum);
            this.showingDesign.Left = (this.ClientSize.Width - showingDesign.Width) / 2;  //중앙정렬
        }

        public SettingPage(string imageName,string userText,int price,int imageNum, int pageNum) // 결재창에서 넘어올때
        {
            this.imageName = imageName;
            this.userText = userText;
            this.imageNum = imageNum;
            this.pageNum = pageNum;

            InitializeComponent();

            showingimageChage(pageNum, imageNum);
            this.showingDesign.Left = (this.ClientSize.Width - showingDesign.Width) / 2;  //중앙정렬
        }

        public void showingimageChage(int pageNum, int imageNum)
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

        private void exit_pane_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TopperList newTopperlist = new TopperList();
            newTopperlist.ShowDialog();
        }

        private void next_pane_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PayPage newPayPage = new PayPage(imageName, userText, price, imageNum, pageNum);
            newPayPage.ShowDialog();
        }
    }
}
