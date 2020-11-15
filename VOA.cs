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
    public partial class VOA : Form
    {
        public VOA()
        {
            InitializeComponent();
        }

        private void VOA_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://stream.radiojar.com/ycff5hcs92quv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm15 = new Form1();
            frm15.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
