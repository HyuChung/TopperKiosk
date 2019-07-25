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
        public backgroungMain()
        {
            InitializeComponent();
            this.dispane.Left = (this.ClientSize.Width - this.dispane.Width) / 2;
            this.dispane.Top = (this.ClientSize.Height - this.ClientSize.Height) / 2;
        }


        private void AddForms2Panel(Form form)
        {
            form.TopLevel = false;
            dispane.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void backgroungMain_Load(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.ShowDialog();
        }
    }
}
