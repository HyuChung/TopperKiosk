﻿using System;
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
        string imageName ;
        int imageNum = 0, pageNum = 0, textindex_column_1 =9, textindex_column_2 = 9, price;

        string[,] topperText = new string[2, 4] { { "세미콜론팀", "사랑합니다", "감사합니다", "SemmiColon" } ,
                                                    {"화이팅","선생님","부모님","Team" } };


        public SettingPage(string imageName, int price, int imageNum, int pageNum) // 이미지 선택 창에서 넘어올때
        {
            this.imageName = imageName;
            this.price = price;
            this.imageNum = imageNum;
            this.pageNum = pageNum;

            InitializeComponent();

            roundimagebox();
            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거
            showingimageChage(pageNum, imageNum);
            this.showingDesign.Top = (this.ClientSize.Height - showingDesign.Height) / 2;  //중앙정렬
        }

        public SettingPage(string imageName,int price,int imageNum, int pageNum, int textindex_column_1, int textindex_column_2) // 결재창에서 넘어올때
        {
            this.imageName = imageName;
            this.imageNum = imageNum;
            this.pageNum = pageNum;
            this.textindex_column_1 = textindex_column_1;
            this.textindex_column_2 = textindex_column_2;

            InitializeComponent();

            roundimagebox();
            showingimageChage(pageNum, imageNum);
            this.showingDesign.Top = (this.ClientSize.Height - showingDesign.Height) / 2;  //중앙정렬
        }


        private void roundimagebox()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, showingDesign.Width - 3, showingDesign.Height - 3);
            Region rg = new Region(gp);

            showingDesign.Region = rg;
        }

        private void showingimageChage(int pageNum, int imageNum)//보여지는 이미지 가져오기
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


        #region 'TextSslectBtn Setting'
        private void textselect_btn_1_1_Click(object sender, EventArgs e)
        {
            textindex_column_1 = 0;
        }

        private void textselect_btn_1_2_Click(object sender, EventArgs e)
        {
            textindex_column_1 = 1;
        }

        private void textselect_btn_1_3_Click(object sender, EventArgs e)
        {
            textindex_column_1 = 2;
        }

        private void textselect_btn_1_4_Click(object sender, EventArgs e)
        {
            textindex_column_1 = 3;
        }

        private void textselect_btn_2_1_Click(object sender, EventArgs e)
        {
            textindex_column_2 = 0;
        }

        private void textselect_btn_2_2_Click(object sender, EventArgs e)
        {
            textindex_column_2 = 1;
        }

        private void textselect_btn_2_3_Click(object sender, EventArgs e)
        {
            textindex_column_2 = 2;
        }

        private void textselect_btn_2_4_Click(object sender, EventArgs e)
        {
            textindex_column_2 = 3;
        }
        #endregion



        private void exit_pane_Click(object sender, EventArgs e)//이전 화면
        {
            this.Visible = false;
            TopperList newTopperlist = new TopperList(9);
            newTopperlist.ShowDialog();
        }

        private void next_pane_Click(object sender, EventArgs e)//다음화면
        {
            if (textindex_column_1 != 9 && textindex_column_2 != 9)
            {
                this.Visible = false;
                PayPage newPayPage = new PayPage(imageName, price, imageNum, pageNum,textindex_column_1,textindex_column_2);
                newPayPage.ShowDialog();
            }
        }
    }
}
