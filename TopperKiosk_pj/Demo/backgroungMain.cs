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
    public partial class backgroungMain : Form
    {

        string image_name = "None";
        int imageNum = 0, pageNum = 0, textindex_column_1 = 0, textindex_column_2 = 0, price = 0;

        string[,] topperText = new string[2, 4] { { "세미콜론팀", "감사합니다", "사랑합니다" , "SemmiColon" } ,
                                                    {"화이팅","선생님","부모님","Team" } };



        public backgroungMain()
        {
            InitializeComponent();

            MainPage mp = new MainPage();
            mp.FormSendEvent += new MainPage.FormSendDataHandler(mainfromlisner);
            mp.Owner = this;
            AddForms2Panel(mp);

            this.dispane.Left = (this.ClientSize.Width - this.dispane.Width) / 2;
            this.dispane.Top = (this.ClientSize.Height - this.ClientSize.Height) / 2;
        }

        #region 'Properties'
        private void AddForms2Panel(Form form)
        {
            form.TopLevel = false;
            dispane.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        #endregion

        #region 'Binding Propertise'
        private void mainfromlisner(object sender)
        {
            int pramiter = (int)sender;
            TopperList TL = new TopperList(pramiter);
            TL.FormSendEvent += new TopperList.FormSendDataHandler(Topperlistlisner);
            TL.Owner = this;
            AddForms2Panel(TL);
        }

        private void Topperlistlisner(object sender)
        {

        }
        #endregion
        private void backgroungMain_Load(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.ShowDialog();
        }
    }
}
