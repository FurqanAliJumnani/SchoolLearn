using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            // Show Class One panel
            panel4.Visible = true;
            panel3.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }
        
        
        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            panel3.Visible = false;
            panel6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel4.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loginform lgfrm = new loginform();
            lgfrm.Show();
            this.Hide();
        }
    }
}
