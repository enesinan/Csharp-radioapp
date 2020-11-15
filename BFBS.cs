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
    public partial class BFBS : Form
    {
        public BFBS()
        {
            InitializeComponent();
        }

        private void BFBS_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://edge-audio-03-gos2.sharp-stream.com/ssvcbfbs12.aac?device=bfbs_canada";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm13 = new Form1();
            frm13.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
