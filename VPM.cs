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
    public partial class VPM : Form
    {
        public VPM()
        {
            InitializeComponent();
        }

        private void VPM_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://playerservices.streamtheworld.com/api/livestream-redirect/WCVEFM_SC";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm4 = new Form1();
            frm4.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
