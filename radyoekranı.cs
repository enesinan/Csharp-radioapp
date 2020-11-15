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
    public partial class radyoekranı : Form
    {
        public radyoekranı()
        {
            InitializeComponent();
        }

        private void radyoekranı_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://mp3.cbn.com/stream/news64?app=onlineradiobox";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
