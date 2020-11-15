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
    public partial class BBC : Form
    {
        public BBC()
        {
            InitializeComponent();
        }

        private void BBC_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"http://bbcwssc.ic.llnwd.net/stream/bbcwssc_mp1_ws-eieuk_backup";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm3 = new Form1();
            frm3.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
