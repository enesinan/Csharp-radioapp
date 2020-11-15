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
    public partial class RedState : Form
    {
        public RedState()
        {
            InitializeComponent();
        }

        private void RedState_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"https://s2.radio.co/s572ad25f7/listen";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm9 = new Form1();
            frm9.Show();
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
