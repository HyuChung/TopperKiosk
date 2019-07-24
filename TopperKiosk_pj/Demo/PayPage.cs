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
        int imageNum = 0, pageNum = 0, textindex_column_1 = 0, textindex_column_2 = 0, price;

        string[,] topperText = new string[2, 4] { { "세미콜론팀", "감사합니다", "사랑합니다" , "SemmiColon" } ,
                                                    {"화이팅","선생님","부모님","Team" } };


        public PayPage(string image_name, int price, int imageNum, int pageNum, int textindex_column_1, int textindex_column_2)
        {
            this.image_name = image_name;
            this.imageNum = imageNum;
            this.pageNum = pageNum;
            this.textindex_column_1 = textindex_column_1;
            this.textindex_column_2 = textindex_column_2;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거
            showingimageChage(imageNum ,pageNum);

            this.showingDesign.Top = (this.ClientSize.Height - showingDesign.Height) / 2;//중앙정렬(세로)
            this.disInfo_pane.Top = (this.ClientSize.Height - disInfo_pane.Height) / 2;//중앙정렬(세로)
            this.disDesginName_lbl.Text = image_name;
            this.disUserText_lbl.Text = topperText[0,textindex_column_1] +" "+ topperText[1,textindex_column_2];
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
            SettingPage newSettingPage = new SettingPage(image_name,price,imageNum, pageNum, textindex_column_1, textindex_column_2);
            newSettingPage.ShowDialog();
        }
    }
}
