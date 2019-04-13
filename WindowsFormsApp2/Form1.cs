using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel1.Visible = true;
            */
            panel1.Show();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel2.Visible = true;*/
            panel1.Hide();
            panel2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            /*panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel3.Visible = true;*/
            panel2.Hide();
            panel3.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            /*panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;*/
            panel3.Hide();
            panel4.Show();
        }
    }
}
