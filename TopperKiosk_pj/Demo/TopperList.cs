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
    public partial class TopperList : Form
    {
        int valPage = 1, numpage = 1;
        string selected_image ="None";
        

        public TopperList()
        {
            InitializeComponent();
        }

        private void TopperList_Load(object sender, EventArgs e)
        {

        }

        private void exit_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            MainPage newMain = new MainPage();
            newMain.ShowDialog();
            
        }

        private void next_pane_Click(object sender, EventArgs e)
        {
            if (selected_image.Equals("None")) //이미지 선택 x
            {
                this.Visible = false;
                SettingPage newsettingPage = new SettingPage(selected_image);
                newsettingPage.ShowDialog();
            }
            else // 이미지 선택 o
            {
                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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
        }
    }
}
