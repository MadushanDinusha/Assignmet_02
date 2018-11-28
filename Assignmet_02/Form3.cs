using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmet_02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            txtLength.Visible = false;
            txtHeight.Visible = false;
            txtWidth.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label7.Text = "V = Length * Width * Height";
                    label1.Text = "Length :";
                    label2.Text = "Width :";
                    label4.Text = "Height :";
                    txtLength.Visible = true;
                    txtHeight.Visible = true;
                    txtWidth.Visible = true;
                    break;
                case 1:
                    label7.Text = "V = pi * Radius^2 * Height";
                    label1.Text = "Radius :";
                    label2.Text = "Height :";
                    txtLength.Visible = true;
                    txtHeight.Visible = true;
                    break;
                case 2:
                    label7.Text = "V = (1/3) * pi * Radius^2 * Height";
                    label4.Text = "Radius :";
                    label1.Text = "Height :";
                    txtLength.Visible = true;
                    txtWidth.Visible = true;
                    break;

                case 3:
                    label4.Text = "A= pi* Radius^2";
                    label1.Text = "Radius :";
                    txtLength.Visible = true;

                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
