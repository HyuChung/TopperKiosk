using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
        public TopperlistPopUp(string image_name, int imageNum, int price) 
        {
            this.price = price;
            this.image_name = image_name;
            this.imageNum = imageNum;

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거

            showingimageChage();
            this.showingDesign.Left = (this.ClientSize.Width - showingDesign.Width) / 2;
            this.disInfo_pane.Left = (this.ClientSize.Width - disInfo_pane.Width) / 2;

            this.disDesginName_lbl.Text = image_name;
            roundRectPicBox();
            //this.dismoney_lbl.Text = price.ToString();
        }
        #endregion



        #region 'Propertise'
        public void showingimageChage() // 보여지는 이미지 가져오기
        {
            this.showingDesign.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/TopperImage/TestImages/"+image_name+".png");
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void roundRectPicBox() // 이미지 박스 둥근 사각형
        {
            showingDesign.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, showingDesign.Width - 3, showingDesign.Height - 3, 30, 30));
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
