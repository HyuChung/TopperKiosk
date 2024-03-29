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
    public partial class MainPage : Form
    {

        #region 'Field'
        public delegate void FormSendDataHandler(object obj);
        public event FormSendDataHandler FormSendEvent;
        #endregion



        #region 'init'
        public MainPage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // 폼 태두리 제거
            this.ManInfo_lbl.Left = (this.ClientSize.Width - ManInfo_lbl.Width) / 2;  // 중앙정렬
        }
        #endregion



        #region 'Propertise'
        private void translate_paneKo_MouseEnter(object sender, EventArgs e) // 팁 텍스트 변환(한국어)
        {
            ManInfo_lbl.Text = "언어를 선택하여 다음으로 넘어가기";
        }

        private void translate_paneCH_MouseEnter(object sender, EventArgs e) // 팁 텍스트 변환(중국어)
        {
            ManInfo_lbl.Text = "选择语言向后过渡";
        }

        private void lbl_JP_MouseEnter(object sender, EventArgs e) // 팁 텍스트 변환(일본어)
        {
            ManInfo_lbl.Text = "語を選んで次に移る";
        }

        private void translate_paneEN_MouseEnter(object sender, EventArgs e) // 팁 텍스트 변환(영어)
        {
            ManInfo_lbl.Text = "Select a language to move next page";
        }
        #endregion



        #region 'Next/Exit Setting' 
        private void translate_paneKO_MouseClick(object sender, MouseEventArgs e) // 한국어 다음 화면
        {
            this.FormSendEvent(4);
            this.Visible = false;
            
        }

        private void translate_paneCH_MouseClick(object sender, MouseEventArgs e) // 중국어 다음 화면
        {
            this.FormSendEvent(1);
            this.Visible = false;
        }

        private void translate_paneJP_MouseClick(object sender, MouseEventArgs e) // 일본어 다음 화면
        {
            this.FormSendEvent(2);
            this.Visible = false;
        }

        private void translate_paneEN_MouseClick(object sender, MouseEventArgs e) // 영어 다음 화면
        {
            this.FormSendEvent(3);
            this.Visible = false;
        }
        #endregion

    }
}
