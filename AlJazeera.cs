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
    public partial class AlJazeera : Form
    {
        public AlJazeera()
        {
            InitializeComponent();
        }

        private void AlJazeera_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://live-hls-audio-web-aje.getaj.net/VOICE-AJE/index.m3u8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm5 = new Form1();
            frm5.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
