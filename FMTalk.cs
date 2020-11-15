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
    public partial class FMTalk : Form
    {
        public FMTalk()
        {
            InitializeComponent();
        }

        private void FMTalk_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://live.wostreaming.net/direct/alphacorporate-wsgwfmaac-ibc4?source=onlineradiobox";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm8 = new Form1();
            frm8.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
