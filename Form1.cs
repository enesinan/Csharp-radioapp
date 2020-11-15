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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BBC World Service English
            //  axWindowsMediaPlayer1.URL = "http://bbcwssc.ic.llnwd.net/stream/bbcwssc_mp1_ws-eieuk_backup";



            

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radyoekranı rdycbn = new radyoekranı();
            rdycbn.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ABC abc = new ABC();
            abc.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BBC bbc = new BBC();
            bbc.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VPM vpm = new VPM();
            vpm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AlJazeera alj = new AlJazeera();
            alj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aljazeera2 alj2 = new Aljazeera2();
            alj2.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NetTalk nt = new NetTalk();
            nt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FMTalk fmt = new FMTalk();
            fmt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RedState rs = new RedState();
            rs.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            KTAR kt = new KTAR();
            kt.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BPR bpr = new BPR();
            bpr.Show();
            this.Hide();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            WABE wabe = new WABE();
            wabe.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BFBS bfbs = new BFBS();
            bfbs.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            NEPM nepm = new NEPM();
            nepm.Show();
            this.Hide();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            VOA voa = new VOA();
            voa.Show();
            this.Hide();
        }
    }
}
