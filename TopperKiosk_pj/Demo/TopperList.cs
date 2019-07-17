using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Demo
{
    public partial class TopperList : Form
    {
        int valPage = 1, numpage = 1, listnum = 200;
        int[,] imageMap = new int[3, 3] { {0,0,0},{0,0,0},{0,0,0} };
        string selected_image ="None";
        int price = 0;

        public TopperList()
        {
            InitializeComponent();
        }

        public TopperList(int lenguage)
        {
            if (lenguage == 1) //다국어 처리
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh");
            }
            else if(lenguage == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja-JP");
            }
            else if(lenguage == 3)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
            else if(lenguage == 4)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ko");
            }
         
            InitializeComponent();
            insertpic(valPage, numpage); //이미지 초기화
           
        }


        private void insertpic(int valPage,int numpage) //이미지 박스 이미지 넣기
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
        }

        private void initimagemap() //이미지 맵 초기화
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    imageMap[i, j] = 0;
                }
            }
        }

        private void initimagepic() //이미지 박스 초기화
        {
            pic_1_1.Image = null;
            pic_1_2.Image = null;
            pic_1_3.Image = null;
            pic_2_1.Image = null;
            pic_2_2.Image = null;
            pic_2_3.Image = null;
            pic_3_1.Image = null;
            pic_3_2.Image = null;
            pic_3_3.Image = null;
        }

        private void initpicteg() //이미지 태그 초기화
        {
            pic_1_1.Tag = SystemColors.GradientInactiveCaption;
            pic_1_2.Tag = SystemColors.GradientInactiveCaption;
            pic_1_3.Tag = SystemColors.GradientInactiveCaption;
            pic_2_1.Tag = SystemColors.GradientInactiveCaption;
            pic_2_2.Tag = SystemColors.GradientInactiveCaption;
            pic_2_3.Tag = SystemColors.GradientInactiveCaption;
            pic_3_1.Tag = SystemColors.GradientInactiveCaption;
            pic_3_2.Tag = SystemColors.GradientInactiveCaption;
            pic_3_3.Tag = SystemColors.GradientInactiveCaption;
        }

        private void selectedImage()
        {
            for(int i=0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(imageMap[i,j] == 2)
                    {
                        listnum = i * 3 + j;
                    }
                }
            }
        }

        private void imagelistSerchAndChange(int listnum)
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
                        pic_2_2.Image = TourImagelist.Images[4];
                    }
                    else if (a < 7)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        pic_2_2.Image = TourImagelist.Images[4];
                        pic_2_3.Image = TourImagelist.Images[5];
                    }
                    else if (a < 8)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        pic_2_2.Image = TourImagelist.Images[4];
                        pic_2_3.Image = TourImagelist.Images[5];
                        pic_3_1.Image = TourImagelist.Images[6];
                    }
                    else if(a < 9)
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        pic_2_2.Image = TourImagelist.Images[4];
                        pic_2_3.Image = TourImagelist.Images[5];
                        pic_3_1.Image = TourImagelist.Images[6];
                        pic_3_2.Image = TourImagelist.Images[7];
                    }
                    else
                    {
                        pic_1_1.Image = TourImagelist.Images[0];
                        pic_1_2.Image = TourImagelist.Images[1];
                        pic_1_3.Image = TourImagelist.Images[2];
                        pic_2_1.Image = TourImagelist.Images[3];
                        pic_2_2.Image = TourImagelist.Images[4];
                        pic_2_3.Image = TourImagelist.Images[5];
                        pic_3_1.Image = TourImagelist.Images[6];
                        pic_3_2.Image = TourImagelist.Images[7];
                        pic_3_3.Image = TourImagelist.Images[8];
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
                        pic_2_2.Image = FoodImagelist.Images[4];
                    }
                    else if (a < 7)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        pic_2_2.Image = FoodImagelist.Images[4];
                        pic_2_3.Image = FoodImagelist.Images[5];
                    }
                    else if (a < 8)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        pic_2_2.Image = FoodImagelist.Images[4];
                        pic_2_3.Image = FoodImagelist.Images[5];
                        pic_3_1.Image = FoodImagelist.Images[6];
                    }
                    else if (a < 9)
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        pic_2_2.Image = FoodImagelist.Images[4];
                        pic_2_3.Image = FoodImagelist.Images[5];
                        pic_3_1.Image = FoodImagelist.Images[6];
                        pic_3_2.Image = FoodImagelist.Images[7];
                    }
                    else
                    {
                        pic_1_1.Image = FoodImagelist.Images[0];
                        pic_1_2.Image = FoodImagelist.Images[1];
                        pic_1_3.Image = FoodImagelist.Images[2];
                        pic_2_1.Image = FoodImagelist.Images[3];
                        pic_2_2.Image = FoodImagelist.Images[4];
                        pic_2_3.Image = FoodImagelist.Images[5];
                        pic_3_1.Image = FoodImagelist.Images[6];
                        pic_3_2.Image = FoodImagelist.Images[7];
                        pic_3_3.Image = FoodImagelist.Images[8];
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
                        pic_2_2.Image = MemorialImageList.Images[4];
                    }
                    else if (a < 7)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        pic_2_2.Image = MemorialImageList.Images[4];
                        pic_2_3.Image = MemorialImageList.Images[5];
                    }
                    else if (a < 8)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        pic_2_2.Image = MemorialImageList.Images[4];
                        pic_2_3.Image = MemorialImageList.Images[5];
                        pic_3_1.Image = MemorialImageList.Images[6];
                    }
                    else if (a < 9)
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        pic_2_2.Image = MemorialImageList.Images[4];
                        pic_2_3.Image = MemorialImageList.Images[5];
                        pic_3_1.Image = MemorialImageList.Images[6];
                        pic_3_2.Image = MemorialImageList.Images[7];
                    }
                    else
                    {
                        pic_1_1.Image = MemorialImageList.Images[0];
                        pic_1_2.Image = MemorialImageList.Images[1];
                        pic_1_3.Image = MemorialImageList.Images[2];
                        pic_2_1.Image = MemorialImageList.Images[3];
                        pic_2_2.Image = MemorialImageList.Images[4];
                        pic_2_3.Image = MemorialImageList.Images[5];
                        pic_3_1.Image = MemorialImageList.Images[6];
                        pic_3_2.Image = MemorialImageList.Images[7];
                        pic_3_3.Image = MemorialImageList.Images[8];
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
                        pic_2_3.Image = RecommendImagelist.Images[5];
                    }
                    else if (a < 8)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                        pic_2_2.Image = RecommendImagelist.Images[4];
                        pic_2_3.Image = RecommendImagelist.Images[5];
                        pic_3_1.Image = RecommendImagelist.Images[6];
                    }
                    else if (a < 9)
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                        pic_2_2.Image = RecommendImagelist.Images[4];
                        pic_2_3.Image = RecommendImagelist.Images[5];
                        pic_3_1.Image = RecommendImagelist.Images[6];
                        pic_3_2.Image = RecommendImagelist.Images[7];
                    }
                    else
                    {
                        pic_1_1.Image = RecommendImagelist.Images[0];
                        pic_1_2.Image = RecommendImagelist.Images[1];
                        pic_1_3.Image = RecommendImagelist.Images[2];
                        pic_2_1.Image = RecommendImagelist.Images[3];
                        pic_2_2.Image = RecommendImagelist.Images[4];
                        pic_2_3.Image = RecommendImagelist.Images[5];
                        pic_3_1.Image = RecommendImagelist.Images[6];
                        pic_3_2.Image = RecommendImagelist.Images[7];
                        pic_3_3.Image = RecommendImagelist.Images[8];
                    }
                    break;
            }
        }


        private void exit_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            MainPage newMain = new MainPage();
            newMain.ShowDialog();
            
        }

        private void next_pane_Click(object sender, EventArgs e)
        {
            selectedImage();

            if (selected_image.Equals("None") && (listnum != 200)) //이미지 선택 확인
            {
                this.Visible = false;
                SettingPage newsettingPage = new SettingPage(selected_image,price, listnum, valPage);
                newsettingPage.ShowDialog();
            }   
        }



        private void menu1_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.manu1_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;
           
            this.menu1_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;

            this.valPage = 1;
            insertpic(valPage, numpage);
        }

        private void menu2_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu2_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

            this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu2_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;

            this.valPage = 2;
            insertpic(valPage, numpage);
        }

        private void menu3_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu3_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

            this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu3_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;

            this.valPage = 3;
            insertpic(valPage, numpage);
        }

        private void menu4_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.manu4_lbl.ForeColor = System.Drawing.SystemColors.ControlText;

            this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menu4_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;

            this.valPage = 4;
            insertpic(valPage, numpage);
        }



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

        
        private void changePicColor(int x)
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

        private void allRefrash()
        {
            pic_1_1.Refresh();
            pic_1_2.Refresh();
            pic_1_3.Refresh();
            pic_2_1.Refresh();
            pic_2_2.Refresh();
            pic_2_3.Refresh();
            pic_3_1.Refresh();
            pic_3_2.Refresh();
            pic_3_3.Refresh();
        }


        private void pic_1_1_Click(object sender, EventArgs e)
        {
            if (imageMap[0, 0] !=0) {
                changePicColor(11);
                imageMap[0, 0]=2;
                allRefrash();
            }
           
        }

        private void pic_1_2_Click(object sender, EventArgs e)
        {
            if (imageMap[0, 1] != 0)
            {
                changePicColor(12);
                imageMap[0, 1]=2;
                allRefrash();
            }
        }

        private void pic_1_3_Click(object sender, EventArgs e)
        {
            if (imageMap[0, 2] != 0)
            {
                changePicColor(13);
                imageMap[0, 2]=2;
                allRefrash();
            }
        }

        private void pic_2_1_Click(object sender, EventArgs e)
        {
            if (imageMap[1, 0] != 0)
            {
                changePicColor(21);
                imageMap[1,0]=2;
                allRefrash();
            }
        }

        private void pic_2_2_Click(object sender, EventArgs e)
        {
            if (imageMap[1, 1] != 0)
            {
                changePicColor(22);
                imageMap[1,1]=2;
                allRefrash();
            }
        }

        private void pic_2_3_Click(object sender, EventArgs e)
        {
            if (imageMap[1, 2] != 0)
            {
                changePicColor(23);
                imageMap[1, 2]=2;
                allRefrash();
            }
        }

        private void pic_3_1_Click(object sender, EventArgs e)
        {
            if (imageMap[2, 0] != 0)
            {
                changePicColor(31);
                imageMap[2,0]=2;
                allRefrash();
            }
        }

        private void pic_3_2_Click(object sender, EventArgs e)
        {
            if (imageMap[2, 1] != 0)
            {
                changePicColor(32);
                imageMap[2,1]=2;
                allRefrash();
            }
        }

        private void pic_3_3_Click(object sender, EventArgs e)
        {
            if (imageMap[2, 2] != 0)
            {
                changePicColor(33);
                imageMap[2,2]=2;
                allRefrash();
            }
        }


    }
}
