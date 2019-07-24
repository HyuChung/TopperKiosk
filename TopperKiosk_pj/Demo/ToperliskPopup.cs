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
    public partial class ToperliskPopup : Form
    {
        string image_name = "None";
        int imageNum=0, pageNum, price;

        public ToperliskPopup(string image_name, int imageNum, int pageNum, int price)
        {
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


        private void next_pane_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            SettingPage newsettingPage = new SettingPage(image_name, price, imageNum, pageNum);
            newsettingPage.ShowDialog();
        }

        private void exit_pane_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
