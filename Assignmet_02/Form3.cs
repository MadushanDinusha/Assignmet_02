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
                    lblLength.Text = "Length :";
                    lblWidth.Text  = "Width :";
                    lblHeight.Text = "Height :";
                    txtLength.Visible = true;
                    txtWidth.Visible = true;
                    txtHeight.Visible = true;
                    break;
                case 1:
                    label7.Text = "V = pi * Radius^2 * Height";
                    lblLength.Text = "Radius :";
                    lblWidth.Text = "Height :";
                    lblHeight.Text = "";
                    txtLength.Visible = true;
                    txtWidth.Visible = true;
                    txtHeight.Visible = false;
                    break;
                case 2:
                    label7.Text = "V = (1/3) * pi * Radius^2 * Height";
                    lblLength.Text = "Radius :";
                    lblWidth.Text = "Height :";
                    lblHeight.Text = "";
                    txtLength.Visible = true;
                    txtWidth.Visible = true;
                    txtHeight.Visible = false;
                    break;

                case 3:
                    label7.Text = "V = (4/3) * pi * Radius^3";
                    lblLength.Text = "Radius :";
                    lblWidth.Text = "";
                    lblHeight.Text = "";
                    txtLength.Visible = true;
                    txtHeight.Visible = false;
                    txtWidth.Visible = false;

                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            double pi = Math.PI;
            try {
                if (comboBox1.SelectedIndex == 0)
                {
                    double length = double.Parse(txtLength.Text);
                    double width = double.Parse(txtWidth.Text);
                    double height = double.Parse(txtHeight.Text);
                    double volume = width * height * length;
                    ans.Text = Convert.ToString(volume);
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    double radius = double.Parse(txtLength.Text);
                    double height = double.Parse(txtWidth.Text);
                    double volume = pi * height * Math.Pow(radius, 2);
                    ans.Text = Convert.ToString(volume);
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    double radius = double.Parse(txtLength.Text);
                    double height = double.Parse(txtWidth.Text);

                    double volume = pi * height * Math.Pow(radius, 2) * 1 / 3;
                    ans.Text = Convert.ToString(volume);
                }

                if (comboBox1.SelectedIndex == 3)
                {
                    double radius = double.Parse(txtLength.Text);
                    double volume = pi * Math.Pow(radius, 3) * 4 / 3;
                    ans.Text = Convert.ToString(volume);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("pelase enter a numeric value");
            }
            }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHeight.Text = "";
            lblLength.Text = "";
            lblWidth.Text = "";
            label7.Text = "";
            ans.Text = "";
            comboBox1.Text = "";
            txtHeight.Visible = false;
            txtLength.Visible = false;
            txtWidth.Visible = false;
        }
    }
}
