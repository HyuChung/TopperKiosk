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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.ManInfo_lbl.Left = (this.ClientSize.Width - ManInfo_lbl.Width) / 2;  //중앙정렬
        }

        private void translate_paneKO_MouseClick(object sender, MouseEventArgs e)//한국어 다음 화면
        {
            this.Visible = false;
            TopperList newKoForm = new TopperList(4);
            newKoForm.ShowDialog();
        }

        private void translate_paneCH_MouseClick(object sender, MouseEventArgs e)//중국어 다음 화면
        {
            this.Visible = false;
            TopperList newCHForm = new TopperList(1);
            newCHForm.ShowDialog();
        }

        private void translate_paneJP_MouseClick(object sender, MouseEventArgs e)//일본어 다음 화면
        {
            this.Visible = false;
            TopperList newJPForm = new TopperList(2);
            newJPForm.ShowDialog();
        }

        private void translate_paneEN_MouseClick(object sender, MouseEventArgs e)//영어 다음 화면
        {
            this.Visible = false;
            TopperList newENForm = new TopperList(3);
            newENForm.ShowDialog();
        }

        private void translate_paneKo_MouseEnter(object sender, EventArgs e)//팁 텍스트 변환(한국어)
        {
            ManInfo_lbl.Text = "언어를 선택하여 다음으로 넘어가기";
        }

        private void translate_paneCH_MouseEnter(object sender, EventArgs e)//팁 텍스트 변환(중국어)
        {
            ManInfo_lbl.Text = "选择语言向后过渡";
        }

        private void lbl_JP_MouseEnter(object sender, EventArgs e)//팁 텍스트 변환(일본어)
        {
            ManInfo_lbl.Text = "語を選んで次に移る";
        }

        private void translate_paneEN_MouseEnter(object sender, EventArgs e)//팁 텍스트 변환(영어)
        {
            ManInfo_lbl.Text = "Select a language to move next page";
        }

        
    }
}
