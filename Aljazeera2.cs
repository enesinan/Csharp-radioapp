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
    public partial class Aljazeera2 : Form
    {
        public Aljazeera2()
        {
            InitializeComponent();
        }

        private void Aljazeera2_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://live-hls-audio-web-aja.getaj.net/VOICE-AJA/index.m3u8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm6 = new Form1();
            frm6.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
