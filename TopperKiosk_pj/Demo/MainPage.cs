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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ToperKiosk_Sys_Load(object sender, EventArgs e)
        {

        }

        private void translate_paneKO_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            TopperList newKoForm = new TopperList();
            newKoForm.ShowDialog();
        }

        private void translate_paneCH_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            TopperList newCHForm = new TopperList();
            newCHForm.ShowDialog();
        }

        private void translate_paneJP_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            TopperList newJPForm = new TopperList();
            newJPForm.ShowDialog();
        }

        private void translate_paneEN_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            TopperList newENForm = new TopperList();
            newENForm.ShowDialog();
        }

    
    }
}
