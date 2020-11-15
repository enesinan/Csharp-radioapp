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
    public partial class NEPM : Form
    {
        public NEPM()
        {
            InitializeComponent();
        }

        private void NEPM_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://onlineradiobox.com/json/us/wnnznews/play?platform=web";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm14 = new Form1();
            frm14.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
