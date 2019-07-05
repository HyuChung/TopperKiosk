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
    public partial class TopperList : Form
    {
        private int picPageManu =0, picPageNum=0;
        private string[,] picArr; 


        public TopperList()
        {
            InitializeComponent();
        }

        private void TopperList_Load(object sender, EventArgs e)
        {
            
        }

        private void exit_pane_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


        private void menu1_pane_MouseClick(object sender, MouseEventArgs e)
        {
            picPageManu = 0;
            changeManuColor(0);
        }

        private void menu2_pane_MouseClick(object sender, MouseEventArgs e)
        {
            picPageManu = 1;
            changeManuColor(1);
        }

        private void menu3_pane_MouseClick(object sender, MouseEventArgs e)
        {
            picPageManu = 2;
            changeManuColor(2);
        }

        private void menu4_pane_MouseClick(object sender, MouseEventArgs e)
        {
            picPageManu = 3;
            changeManuColor(3);
        }

        private void next_pane_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void right_image_nextpane_Click(object sender, EventArgs e)
        {
            picPageNum++;
        }

        private void left_image_nextpane_Click(object sender, EventArgs e)
        {
            if(picPageNum != 0)
            {
                picPageNum--;
            }
        }

        private void changeManuColor(int manuNum)
        {
            switch (manuNum)
            {
                case 0:
                    this.manu1_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

                    this.menu1_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    break;
                case 1:
                    this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu2_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

                    this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu2_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    break;
                case 2:
                    this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu3_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
                    this.manu4_lbl.ForeColor = System.Drawing.SystemColors.Control;

                    this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu3_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    this.menu4_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    break;
                case 3:
                    this.manu1_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu2_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu3_lbl.ForeColor = System.Drawing.SystemColors.Control;
                    this.manu4_lbl.ForeColor = System.Drawing.SystemColors.ControlText;

                    this.menu1_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu2_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu3_pane.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    this.menu4_pane.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                    break;
            }
                

        }
    }
}
