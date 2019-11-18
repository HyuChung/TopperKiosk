using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Demo
{
    public class MakingTopperImage
    {


        #region 'Field'
        string fontName, imageName, inputText, savedimagename;
        int desineType, fontsize;
        Point location;
        PrivateFontCollection pfcoll;
        FontFamily ff;
        Bitmap bitmap;
        #endregion



        #region 'Init'
        public MakingTopperImage(int desineType)
        {
            setting();
            init(desineType);
        }

        public MakingTopperImage(string imageName, int desineType)
        {
            setting(imageName);
            init(desineType);
        }

        public MakingTopperImage(string imageName, string inputText, int desineType)
        {
            setting(imageName, inputText);
            init(desineType);
        }

        public MakingTopperImage(string imageName, string inputText, int fontsize, Point location, int desineType)
        {
            setting(imageName, inputText, fontsize);
            this.location = location;
            init(desineType);
        }

        void setting(string imageName = "TestTopperImage.png", string inputText = "기본 문구 입니다." ,int fontsize =30 ,string fontName = "NanumGothic.ttf")
        {
            this.imageName = imageName;
            this.inputText = inputText;
            this.fontsize = fontsize;
            this.fontName = fontName;
        }

        void init(int desineType)
        {
            if(desineType == 1)
            {
                makingTopper_Desine_1();
                saveImage();
            }
            else
            {
                //디자인 타입에 따라 넣기 (추후 작업 필요)
            }
        }
        #endregion



        #region 'Propertise'
        private void loadImage() // 이미지 불러오기
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    bitmap = (Bitmap)System.Drawing.Image.FromFile("D:/Temp Workspace/Kiosk/TopperKiosk_pj" + "/TopperImage/TestImages/" + imageName +".png");
                    //"D:/Temp Workspace\Kiosk/TopperKiosk_pj"
                    // Application.StartupPath
                }
            }
            catch (Exception e)
            {
                throw new System.Exception("Fail to load Image", e);
            }
        }


        private void loadFont() // 폰트 불러오기
        {
            try
            {
                pfcoll = new PrivateFontCollection();
                pfcoll.AddFontFile("D:/Temp Workspace/Kiosk/TopperKiosk_pj" + "/TopperImage/Fonts/" + fontName); // 임시 절대위치
                // "D:/Temp Workspace/Kiosk/TopperKiosk_pj"
                // Application.StartupPath
                //pfcoll.AddFontFile("~/Fonts/" + fontName);
                ff = pfcoll.Families[0];
            }
            catch (Exception e)
            {
                throw new System.Exception("Fail to load Fonts", e);
            }
          
        }


        private void makingTopper_Desine_1() // 디자인 패턴 1 만들기
        {
            try
            {
                loadFont();
                loadImage();

                // 1번 위치 (55, 255)
                // 2번 위치 (,)
                // 3번 위치(, )
                // 4번 위치(, )
                // 5번 위치(, )

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font f = new Font(ff, fontsize, FontStyle.Bold))
                    {
                        graphics.DrawString(inputText, f, Brushes.White, location);
                        //Brushes.White
                    }
                }
                
            }catch(Exception e)
            {
                throw new System.Exception("Fail to making Image (Desine1)", e);
            }
        }

        
        private void saveImage() // 이미지 저장
        {
            try
            {
                savedimagename = "new_" + inputText + "_" + new Random().Next(1, 1000) +".png";
                bitmap.Save("D:/Temp Workspace/Kiosk/TopperKiosk_pj/" + savedimagename);
                //Application.StartupPath
                bitmap.Dispose();
                pfcoll.Dispose();
                ff.Dispose();
            }
            catch (Exception e)
            {
                throw new System.Exception("Fail to save Image", e);
            }
            
        }
        public string getimagename() // 이미지 이름
        {
            return imageName;
        }

        public string getSavedimagename() // 저장된 이미지 파일 이름 
        {
            return savedimagename;
        }


        public string getImagetext() // 이미지에 들어간 텍스트 
        {
            return inputText;
        }

        public void setImage2PB(PictureBox sd) // 디자이너에 출력
        {
            sd.Load("D:/Temp Workspace/Kiosk/TopperKiosk_pj/" + savedimagename);    
            // Application.StartupPath
            sd.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        #endregion


    }
}
