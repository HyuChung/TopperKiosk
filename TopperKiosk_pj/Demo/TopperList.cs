using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Runtime.InteropServices;

namespace Demo
{
    public partial class TopperList : Form
    {

        #region 'Field'
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;
        int valPage = 1, numpage = 1, listnum = 200;
        int[,] imageMap = new int[3, 3] { {0,0,0},{0,0,0},{0,0,0} }; //이미지 위치 확인용 배열
        string selected_image ="None";
        int price = 6000;
        #endregion



        #region 'init'
        public TopperList() // 이미지 리스트 블러오기용 초기화
        {
            InitializeComponent();
       
        }

        public TopperList(int lenguage) // 실제 폼 초기화
        {
            localization(lenguage); // 다국어
            
            InitializeComponent();

            //left_arrow.Visible = false; //처음 패이지 왼쪽화살표 삭제

            this.FormBorderStyle = FormBorderStyle.None; //폼 태두리 제거
            roundRectPicBox();
            //roundPicBox(); //원형 이미지 박스 (tag작동안함)
            //menuIconChanger(1);
            //insertpic(valPage, numpage); //이미지 초기화
            imagedisplay();
            
        }
        #endregion



        #region 'Propertise'

        private void localization(int lenguage) // 다국어 처리
        {
            if (lenguage == 1) //다국어 처리
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh");
            }
            else if (lenguage == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
            }
            else if (lenguage == 3)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
            else if (lenguage == 4)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ko");
            }
        }

        /*private void insertpic(int valPage,int numpage) // 이미지 박스 이미지 넣기
        {
            switch (valPage)
            {
                case 1:
                    imagelistSerchAndChange(1);
                    break;
                case 2:
                    imagelistSerchAndChange(2);
                    break;
                case 3:
                    imagelistSerchAndChange(3);
                    break;
                case 4:
                    imagelistSerchAndChange(4);
                    break;
            }
        }*/

        private void initimagemap() // 이미지 맵 초기화
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    imageMap[i, j] = 0;
                }
            }
        }

        private void initselectimagemap() // 이미지 선택 초기화
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (imageMap[i, j] == 2)
                    {
                        imageMap[i, j] = 1;
                    }
                }
            }
        }

        private void initimagepic() // 이미지 박스 초기화
        {
            pic_1_1.Image = null;
            pic_1_2.Image = null;
            pic_1_3.Image = null;
            pic_2_1.Image = null;
            //pic_2_2.Image = null;
            //pic_2_3.Image = null;
            //pic_3_1.Image = null;
            //pic_3_2.Image = null;
            //pic_3_3.Image = null;
        }

        private void initpicteg() // 이미지 태그 초기화
        {
            pic_1_1.Tag = SystemColors.GradientInactiveCaption;
            pic_1_2.Tag = SystemColors.GradientInactiveCaption;
            pic_1_3.Tag = SystemColors.GradientInactiveCaption;
            pic_2_1.Tag = SystemColors.GradientInactiveCaption;
            pic_2_2.Tag = SystemColors.GradientInactiveCaption;
            //pic_2_3.Tag = SystemColors.GradientInactiveCaption;
            //pic_3_1.Tag = SystemColors.GradientInactiveCaption;
            //pic_3_2.Tag = SystemColors.GradientInactiveCaption;
            //pic_3_3.Tag = SystemColors.GradientInactiveCaption;
        }

        private void roundPicBox() // 이미지 박스 원형 박스변경(태그작동 x)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pic_1_1.Width - 3, pic_1_1.Height - 3);
            Region rg = new Region(gp);
            pic_1_1.Region = rg;
            pic_1_2.Region = rg;
            pic_1_3.Region = rg;
            pic_2_1.Region = rg;
            pic_2_2.Region = rg;
            //pic_2_3.Region = rg;
            //pic_3_1.Region = rg;
            //pic_3_2.Region = rg;
            //pic_3_3.Region = rg;
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

        private void roundRectPicBox() // 이미지 박스 둥근 사각형 박스변경(태그작동 x)
        {

            Region rg = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_1_1.Width - 3, pic_1_1.Height - 3, 20, 20));
            pic_1_1.Region = rg;
            pic_1_2.Region = rg;
            pic_1_3.Region = rg;
            pic_2_1.Region = rg;
            pic_2_2.Region = rg;
            //pic_2_3.Region = rg;
            //pic_3_1.Region = rg;
            //pic_3_2.Region = rg;
            //pic_3_3.Region = rg;
        }

        /*private void selectedImage() // 선택되어있는 이미지 번호, 이름 가져오기
        {
            for(int i=0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(imageMap[i,j] == 2)
                    {
                        listnum = i * 3 + j;
                        switch (valPage)
                        {
                            case 1:
                                this.selected_image = TourImagelist.Images.Keys[this.listnum].ToString();
                                break;
                            case 2:
                                this.selected_image = FoodImagelist.Images.Keys[this.listnum].ToString();
                                break;
                            case 3:
                                this.selected_image = MemorialImageList.Images.Keys[this.listnum].ToString();
                                break;
                            case 4:
                                this.selected_image = RecommendImagelist.Images.Keys[this.listnum].ToString();
                                break;
                            
                            
                        }
                    }
                }
            }
        }*/

        private void imagedisplay()
        {
            pic_1_1.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/TopperImage/TestImages/동명대_Photo.png");
            pic_1_2.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/TopperImage/TestImages/동명대_love.png");
            pic_1_3.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/TopperImage/TestImages/동명대_movie.png");
            pic_2_1.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/TopperImage/TestImages/동명대_computer.png");
            pic_2_2.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/TopperImage/TestImages/Mytu.png");
        }

        /*private void imagelistSerchAndChange(int listnum) // 이미지 박스에 넣을 이미지 찾고 넣기 (이미지 리스트 사용)
        {
            int a;
            switch (listnum)
            {
                case 1:
                    initimagemap();
                    initimagepic();
                    initpicteg();
                    a = TourImagelist.Images.Count;

                    for (int i = 0; i <= a / 3; i++)
                    {
                         if (i == a / 3)
                        {
                            for (int j = 0; j < a % 3; j++)
                            {
                                imageMap[i, j] = 1;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                imageMap[i, j] = 1;
                            }
                        }
                    }

                    if (a < 2)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                    }
                    else if (a < 3)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                    }
                    else if( a< 4)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                    }
                    else if (a < 5)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                    }
                    else if (a < 6)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        //pic_2_2.Image = TourImagelist.Images[4];
                    }
                    else if (a < 7)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        //pic_2_2.Image = TourImagelist.Images[4];
                        //pic_2_3.Image = TourImagelist.Images[5];
                    }
                    else if (a < 8)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        //pic_2_2.Image = TourImagelist.Images[4];
                        //pic_2_3.Image = TourImagelist.Images[5];
                        //pic_3_1.Image = TourImagelist.Images[6];
                    }
                    else if(a < 9)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        //pic_2_2.Image = TourImagelist.Images[4];
                        //pic_2_3.Image = TourImagelist.Images[5];
                        //pic_3_1.Image = TourImagelist.Images[6];
                        //pic_3_2.Image = TourImagelist.Images[7];
                    }
                    else
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        //pic_2_2.Image = TourImagelist.Images[4];
                        //pic_2_3.Image = TourImagelist.Images[5];
                        //pic_3_1.Image = TourImagelist.Images[6];
                        //pic_3_2.Image = TourImagelist.Images[7];
                        //pic_3_3.Image = TourImagelist.Images[8];
                    }
                    break;
                case 2:
                    initimagemap();
                    initimagepic();
                    initpicteg();
                    a = FoodImagelist.Images.Count;

                    for (int i = 0; i <= a / 3; i++)
                    {
                        if (i == a / 3)
                        {
                            for (int j = 0; j < a % 3; j++)
                            {
                                imageMap[i, j] = 1;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                imageMap[i, j] = 1;
                            }
                        }
                    }

                    if (a < 2)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                    }
                    else if (a < 3)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                    }
                    else if (a < 4)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                    }
                    else if (a < 5)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                    }
                    else if (a < 6)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        //pic_2_2.Image = FoodImagelist.Images[4];
                    }
                    else if (a < 7)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        //pic_2_2.Image = FoodImagelist.Images[4];
                        //pic_2_3.Image = FoodImagelist.Images[5];
                    }
                    else if (a < 8)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        //pic_2_2.Image = FoodImagelist.Images[4];
                        //pic_2_3.Image = FoodImagelist.Images[5];
                        //pic_3_1.Image = FoodImagelist.Images[6];
                    }
                    else if (a < 9)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        //pic_2_2.Image = FoodImagelist.Images[4];
                        //pic_2_3.Image = FoodImagelist.Images[5];
                        //pic_3_1.Image = FoodImagelist.Images[6];
                        //pic_3_2.Image = FoodImagelist.Images[7];
                    }
                    else
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        pic_2_2.Image = FoodImagelist.Images[4];
                        //pic_2_3.Image = FoodImagelist.Images[5];
                        //pic_3_1.Image = FoodImagelist.Images[6];
                        //pic_3_2.Image = FoodImagelist.Images[7];
                        //pic_3_3.Image = FoodImagelist.Images[8];
                    }
                    break;
                case 3:
                    initimagemap();
                    initimagepic();
                    initpicteg();
                    a = MemorialImageList.Images.Count;

                    for (int i = 0; i <= a / 3; i++)
                    {
                        if (i == a / 3)
                        {
                            for (int j = 0; j < a % 3; j++)
                            {
                                imageMap[i, j] = 1;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                imageMap[i, j] = 1;
                            }
                        }
                    }
                    for (int i = 0; i <= a / 3; i++)
                    {
                        for (int j = 0; j <= a % 3; j++)
                        {
                            imageMap[i, j] = 1;
                        }
                    }

                    if (a < 2)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                    }
                    else if (a < 3)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                    }
                    else if (a < 4)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                    }
                    else if (a < 5)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                    }
                    else if (a < 6)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        //pic_2_2.Image = MemorialImageList.Images[4];
                    }
                    else if (a < 7)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        //pic_2_2.Image = MemorialImageList.Images[4];
                        //pic_2_3.Image = MemorialImageList.Images[5];
                    }
                    else if (a < 8)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        //pic_2_2.Image = MemorialImageList.Images[4];
                        //pic_2_3.Image = MemorialImageList.Images[5];
                        //pic_3_1.Image = MemorialImageList.Images[6];
                    }
                    else if (a < 9)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        pic_2_2.Image = MemorialImageList.Images[4];
                        //pic_2_3.Image = MemorialImageList.Images[5];
                        //pic_3_1.Image = MemorialImageList.Images[6];
                        //pic_3_2.Image = MemorialImageList.Images[7];
                    }
                    else
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        pic_2_2.Image = MemorialImageList.Images[4];
                        //pic_2_3.Image = MemorialImageList.Images[5];
                        //pic_3_1.Image = MemorialImageList.Images[6];
                        //pic_3_2.Image = MemorialImageList.Images[7];
                        //pic_3_3.Image = MemorialImageList.Images[8];
                    }
                    break;
                case 4:
                    initimagemap();
                    initimagepic();
                    initpicteg();
                    a = RecommendImagelist.Images.Count;

                    for (int i = 0; i <= a / 3; i++)
                    {
                        if (i == a / 3)
                        {
                            for (int j = 0; j < a % 3; j++)
                            {
                                imageMap[i, j] = 1;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                imageMap[i, j] = 1;
                            }
                        }
                    }

                    if (a < 2)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                    }
                    else if (a < 3)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                    }
                    else if (a < 4)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                    }
                    else if (a < 5)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                    }
                    else if (a < 6)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                        pic_2_2.Image = RecommendImagelist.Images[4];
                    }
                    else if (a < 7)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                        pic_2_2.Image = RecommendImagelist.Images[4];
                        //.Image = RecommendImagelist.Images[5];
                    }
                    else if (a < 8)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                        pic_2_2.Image = RecommendImagelist.Images[4];
                        //pic_2_3.Image = RecommendImagelist.Images[5];
                        //pic_3_1.Image = RecommendImagelist.Images[6];
                    }
                    else if (a < 9)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                        pic_2_2.Image = RecommendImagelist.Images[4];
                        //pic_2_3.Image = RecommendImagelist.Images[5];
                        //pic_3_1.Image = RecommendImagelist.Images[6];
                        //pic_3_2.Image = RecommendImagelist.Images[7];
                    }
                    else
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                        pic_2_2.Image = RecommendImagelist.Images[4];
                        //pic_2_3.Image = RecommendImagelist.Images[5];
                        //pic_3_1.Image = RecommendImagelist.Images[6];
                        //pic_3_2.Image = RecommendImagelist.Images[7];
                        //pic_3_3.Image = RecommendImagelist.Images[8];
                    }
                    break;
            }
        }*/

        private void allRefrashPic() // 모든 이미지 목록 리프레시
        {
            pic_1_1.Refresh();
            pic_1_2.Refresh();
            pic_1_3.Refresh();
            pic_2_1.Refresh();
            pic_2_2.Refresh();
            //pic_2_3.Refresh();
            //pic_3_1.Refresh();
            //pic_3_2.Refresh();
            //pic_3_3.Refresh();
        }

        /*private void chagearrow(int valPage) // 화살표 전환
        {
            switch (valPage)
            {
                case 1:
                    right_arrow.Visible = true;
                    left_arrow.Visible = false;
                    break;
                case 2:
                    right_arrow.Visible = true;
                    left_arrow.Visible = true;
                    break;
                case 3:
                    right_arrow.Visible = true;
                    left_arrow.Visible = true;
                    break;
                case 4:
                    right_arrow.Visible = false;
                    left_arrow.Visible = true;
                    break;
            }
        }*/

        private void DieaseUpdateEventMethod(object sender) // 백그라운드에 이벤트,변수 전달
        {
            ((BackgroungMain)(this.Owner)).image_name = selected_image;
            ((BackgroungMain)(this.Owner)).imageNum = listnum;
            ((BackgroungMain)(this.Owner)).pageNum = valPage;
            ((BackgroungMain)(this.Owner)).price= price;
            this.Visible = false;
            this.FormSendEvent(1);
        }
        #endregion



        #region 'Menu Settting'
        /*private void menuColorChager(int menuNum) // 메뉴 색깔 변경
        {
            switch (menuNum)
            {
                case 1:
                    this.manu1_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

                    this.menu1_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    this.menu2_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu3_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu4_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    break;
                case 2:
                    this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu2_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

                    this.menu1_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu2_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    this.menu3_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu4_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    break;
                case 3:
                    this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu3_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

                    this.menu1_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu2_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu3_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    this.menu4_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    break;
                case 4:
                    this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu4_lbl.ForeColor = System.Drawing.SystemColors.ControlText;

                    this.menu1_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu2_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu3_pane.BackColor = System.Drawing.Color.DeepSkyBlue;
                    this.menu4_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    break;

            }
        }

        private void menu1_pane_MouseClick(object sender, MouseEventArgs e) // 메뉴1(관광) 클릭
        {
            menuColorChager(1);
            this.valPage = 1;
            menuIconChanger(1);
            //chagearrow(valPage);
            insertpic(valPage, numpage);
        }

        private void menu2_pane_MouseClick(object sender, MouseEventArgs e) // 메뉴2(음식) 클릭
        {
            menuColorChager(2);
            this.valPage = 2;
            menuIconChanger(2);
            //chagearrow(valPage);
            insertpic(valPage, numpage);
        }

        private void menu3_pane_MouseClick(object sender, MouseEventArgs e) // 메뉴3(기념) 클릭
        {
            menuColorChager(3);
            this.valPage = 3;
            menuIconChanger(3);
            //chagearrow(valPage);
            insertpic(valPage, numpage);
        }

        private void menu4_pane_MouseClick(object sender, MouseEventArgs e) // 메뉴4(추천) 클릭
        {
            menuColorChager(4);
            this.valPage = 4;
            menuIconChanger(4);
            //chagearrow(valPage);
            insertpic(valPage, numpage);
        }

        private void menuIconChanger(int numMenu)
        {
            switch (numMenu)
            {
                case 1:
                    menuicon_pic1.Image = menuiconlist.Images[1];
                    menuicon_pic2.Image = menuiconlist.Images[2];
                    menuicon_pic3.Image = menuiconlist.Images[4];
                    menuicon_pic4.Image = menuiconlist.Images[6];
                    break;
                case 2:
                    menuicon_pic1.Image = menuiconlist.Images[0];
                    menuicon_pic2.Image = menuiconlist.Images[3];
                    menuicon_pic3.Image = menuiconlist.Images[4];
                    menuicon_pic4.Image = menuiconlist.Images[6];
                    break;
                case 3:
                    menuicon_pic1.Image = menuiconlist.Images[0];
                    menuicon_pic2.Image = menuiconlist.Images[2];
                    menuicon_pic3.Image = menuiconlist.Images[5];
                    menuicon_pic4.Image = menuiconlist.Images[6];
                    break;
                case 4:
                    menuicon_pic1.Image = menuiconlist.Images[0];
                    menuicon_pic2.Image = menuiconlist.Images[2];
                    menuicon_pic3.Image = menuiconlist.Images[4];
                    menuicon_pic4.Image = menuiconlist.Images[7];
                    break;

            }
        }*/
        #endregion



        #region 'PicTag Setting(NOT USE)'
        /*
         * README!
         * 하이라이트를 위한 픽쳐박스 설정이였으나 새창을 띄우는것으로 변경해 코드만 남김
         * 
        private void pic_1_1_Paint(object sender, PaintEventArgs e)
        {
            if (pic_1_1.Tag == null) { pic_1_1.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_1_1.ClientRectangle, (Color)pic_1_1.Tag, ButtonBorderStyle.Solid);
        }
        
        private void pic_1_2_Paint(object sender, PaintEventArgs e)
        {
            if (pic_1_2.Tag == null) { pic_1_2.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_1_2.ClientRectangle, (Color)pic_1_2.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_1_3_Paint(object sender, PaintEventArgs e)
        {
            if (pic_1_3.Tag == null) { pic_1_3.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_1_3.ClientRectangle, (Color)pic_1_3.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_2_1_Paint(object sender, PaintEventArgs e)
        {
            if (pic_2_1.Tag == null) { pic_2_1.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_2_1.ClientRectangle, (Color)pic_2_1.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_2_2_Paint(object sender, PaintEventArgs e)
        {
            if (pic_2_2.Tag == null) { pic_2_2.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_2_2.ClientRectangle, (Color)pic_2_2.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_2_3_Paint(object sender, PaintEventArgs e)
        {
            if (pic_2_3.Tag == null) { pic_2_3.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_2_3.ClientRectangle, (Color)pic_2_3.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_3_1_Paint(object sender, PaintEventArgs e)
        {
            if (pic_3_1.Tag == null) { pic_3_1.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_3_1.ClientRectangle, (Color)pic_3_1.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_3_2_Paint(object sender, PaintEventArgs e)
        {
            if (pic_3_2.Tag == null) { pic_3_2.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_3_2.ClientRectangle, (Color)pic_3_2.Tag, ButtonBorderStyle.Solid);
        }

        private void pic_3_3_Paint(object sender, PaintEventArgs e)
        {
            if (pic_3_3.Tag == null) { pic_3_3.Tag = SystemColors.GradientInactiveCaption; } //Sets a default color 
            ControlPaint.DrawBorder(e.Graphics, pic_3_3.ClientRectangle, (Color)pic_3_3.Tag, ButtonBorderStyle.Solid);
        }

        private void changePicColor(int x)//이미지 목록 선택시 색깔 변경
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (imageMap[i, j] == 2)
                    {
                        imageMap[i, j] = 1;
                    } 
                }
            }

            switch (x)
            {
                case 11:
                    pic_1_1.Tag = Color.Red;
                    pic_1_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_3.Tag = SystemColors.GradientInactiveCaption;
                    break;
                case 12:
                    pic_1_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_2.Tag = Color.Red;
                    pic_1_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_3.Tag = SystemColors.GradientInactiveCaption;
                    break;
                case 13:
                    pic_1_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_3.Tag = Color.Red;
                    pic_2_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_3.Tag = SystemColors.GradientInactiveCaption;
                    break;
                case 21:
                    pic_1_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_1.Tag = Color.Red;
                    pic_2_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_3.Tag = SystemColors.GradientInactiveCaption;
                    break;
                case 22:
                    pic_1_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_2.Tag = Color.Red;
                    pic_2_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_3.Tag = SystemColors.GradientInactiveCaption;
                    break;
                case 23:
                    pic_1_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_3.Tag = Color.Red;
                    pic_3_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_3.Tag = SystemColors.GradientInactiveCaption;
                    break;
                case 31:
                    pic_1_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_1.Tag = Color.Red;
                    pic_3_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_3.Tag = SystemColors.GradientInactiveCaption;
                    break;
                case 32:
                    pic_1_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_2.Tag = Color.Red;
                    pic_3_3.Tag = SystemColors.GradientInactiveCaption;
                    break;
                case 33:
                    pic_1_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_1_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_2_3.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_1.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_2.Tag = SystemColors.GradientInactiveCaption;
                    pic_3_3.Tag = Color.Red;
                    break;
            }
        }
        */
        #endregion 



        #region 'PicClick Setting'
        private void pic_1_1_Click(object sender, EventArgs e)
        { 
            allRefrashPic();
            this.listnum = 1;
            this.selected_image = "동명대_Photo";
            TopperlistPopUp popup = new TopperlistPopUp("동명대_Photo", 1, price);
            popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
            initselectimagemap();
            popup.ShowDialog();               
        }

        private void pic_1_2_Click(object sender, EventArgs e)
        {
            allRefrashPic();
            this.listnum = 2;
            this.selected_image = "동명대_love";
            TopperlistPopUp popup = new TopperlistPopUp("동명대_love", 2, price);
            popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
            initselectimagemap();
            popup.ShowDialog();           
        }

        private void pic_1_3_Click(object sender, EventArgs e)
        {
            allRefrashPic();
            this.listnum = 3;
            this.selected_image = "동명대_movie";
            TopperlistPopUp popup = new TopperlistPopUp("동명대_movie", 3, price);
            popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
            initselectimagemap();
            popup.ShowDialog();           
        }

        private void pic_2_1_Click(object sender, EventArgs e)
        {
            allRefrashPic();
            this.listnum = 4;
            this.selected_image = "동명대_computer";
            TopperlistPopUp popup = new TopperlistPopUp("동명대_computer", 4, price);
            popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
            initselectimagemap();
            popup.ShowDialog();
        }

        private void pic_2_2_Click(object sender, EventArgs e)
        {
            allRefrashPic();
            this.listnum = 5;
            this.selected_image = "Mytu";
            TopperlistPopUp popup = new TopperlistPopUp("Mytu", 5, price);
            popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
            initselectimagemap();
            popup.ShowDialog();
        }

        /*private void pic_2_3_Click(object sender, EventArgs e)
        {
            if (imageMap[1, 2] != 0)
            {
                //changePicColor(23);
                imageMap[1, 2]=2;
                allRefrashPic();

                selectedImage();
                TopperlistPopUp popup = new TopperlistPopUp(selected_image, listnum, valPage, price);
                popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
                initselectimagemap();
                popup.ShowDialog();
            }
        }

        private void pic_3_1_Click(object sender, EventArgs e)
        {
            if (imageMap[2, 0] != 0)
            {
                //changePicColor(31);
                imageMap[2,0]=2;
                allRefrashPic();

                selectedImage();
                TopperlistPopUp popup = new TopperlistPopUp(selected_image, listnum, valPage, price);
                popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
                initselectimagemap();
                popup.ShowDialog();
            }
        }

        private void pic_3_2_Click(object sender, EventArgs e)
        {
            if (imageMap[2, 1] != 0)
            {
                //changePicColor(32);
                imageMap[2,1]=2;
                allRefrashPic();

                selectedImage();
                TopperlistPopUp popup = new TopperlistPopUp(selected_image, listnum, valPage, price);
                popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
                initselectimagemap();
                popup.ShowDialog();
            }
        }
        
        private void pic_3_3_Click(object sender, EventArgs e)
        {
            if (imageMap[2, 2] != 0)
            {
                //changePicColor(33);
                imageMap[2,2]=2;
                allRefrashPic();

                selectedImage();
                TopperlistPopUp popup = new TopperlistPopUp(selected_image, listnum, valPage, price);
                popup.FormSendEvent += new TopperlistPopUp.FormSendDataHandler(DieaseUpdateEventMethod);
                initselectimagemap();
                popup.ShowDialog();
            }
        }*/
        #endregion



        #region 'Arrow Setting'
        /*private void left_arrow_Click(object sender, EventArgs e)//왼쪽 화살표 동작
        {
            if(valPage != 1)
            {
                right_arrow.Visible = true;
                valPage--;
                menuIconChanger(valPage);
                menuColorChager(valPage);
                insertpic(valPage, numpage);
                if (valPage == 1)
                {
                    left_arrow.Visible = false;
                }
            }
            
        }*/

        /*private void right_arrow_Click(object sender, EventArgs e)//오른쪽 화살표 동작
        {
            if (valPage != 4)
            {
                left_arrow.Visible = true;
                valPage++;
                menuIconChanger(valPage);
                menuColorChager(valPage);
                insertpic(valPage, numpage);
                if (valPage == 4)
                {
                    right_arrow.Visible = false;
                }
            }
        
        }*/
        #endregion



        #region 'Next/Exit Setting'
        private void exit_pane_MouseClick(object sender, MouseEventArgs e) // 이전 화면
        {
            this.FormSendEvent(0);
            this.Visible = false;

        }
        #endregion

    }
}
