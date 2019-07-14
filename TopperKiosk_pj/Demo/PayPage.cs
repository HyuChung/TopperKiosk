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
    public partial class PayPage : Form
    {
        string image_name ="None", usertext ="None";
        int price;

        public PayPage(string imagename, string usertext, int price)
        {
            this.usertext = usertext;
            this.image_name = imagename;
            InitializeComponent();
            this.showingDesign2.Left = (this.ClientSize.Width - showingDesign2.Width) / 2;//중앙정렬
            this.disInfo_pane.Left = (this.ClientSize.Width - disInfo_pane.Width) / 2;//중앙정렬
            this.disDesginName_lbl.Text = image_name;
            this.disUserText_lbl.Text = usertext;
            this.dismoney_lbl.Text = price.ToString();
            
        }

        private void exit_pane_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SettingPage newSettingPage = new SettingPage(image_name, usertext ,price);
            newSettingPage.ShowDialog();
        }
    }
}
