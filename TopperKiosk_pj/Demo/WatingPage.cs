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
    public partial class WatingPage : Form
    {

        int imageNum = 0 ,pageNum =0;


        public WatingPage(int imageNum , int pageNum)
        {
            this.imageNum = imageNum;
            this.pageNum = pageNum;

            InitializeComponent();
            showingimageChage(pageNum, imageNum);
            this.showingDesign.Left = (this.ClientSize.Width - showingDesign.Width) / 2;
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
    }
}
