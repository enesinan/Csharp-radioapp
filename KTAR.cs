using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnetForm.RadyoUyg2
{
    public partial class KTAR : Form
    {
        public KTAR()
        {
            InitializeComponent();
        }

        private void KTAR_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://playerservices.streamtheworld.com/api/livestream-redirect/KTARFMAAC.aac";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm10 = new Form1();
            frm10.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
