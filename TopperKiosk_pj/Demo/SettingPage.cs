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
    public partial class SettingPage : Form
    {
        string imageName , userText;

        public SettingPage(string imageName) // 이미지 선택 창에서 넘어올때
        {
            this.imageName = imageName;
            InitializeComponent();
            this.showingDesign.Left = (this.ClientSize.Width - showingDesign.Width) / 2;  //중앙정렬
        }

        public SettingPage(string imageName,string userText) // 결재창에서 넘어올때
        {
            this.imageName = imageName;
            this.userText = userText;
            InitializeComponent();
            this.showingDesign.Left = (this.ClientSize.Width - showingDesign.Width) / 2;  //중앙정렬
        }

        private void exit_pane_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TopperList newTopperlist = new TopperList();
            newTopperlist.ShowDialog();
        }

        private void next_pane_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PayPage newPayPage = new PayPage(imageName, userText);
            newPayPage.ShowDialog();
        }
    }
}
