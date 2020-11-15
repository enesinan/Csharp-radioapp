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
    public partial class WABE : Form
    {
        public WABE()
        {
            InitializeComponent();
        }

        private void WABE_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://onlineradiobox.com/json/us/wabe3/play?platform=web";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm12 = new Form1();
            frm12.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
