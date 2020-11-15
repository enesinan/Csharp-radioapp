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
    public partial class NetTalk : Form
    {
        public NetTalk()
        {
            InitializeComponent();
        }

        private void NetTalk_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://stream.zeno.fm/n7cpeqvgvceuv";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm7 = new Form1();
            frm7.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
