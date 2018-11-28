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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtLength.Visible = false;
            txtWidth.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            switch (comboBox1.SelectedIndex){
               case 0:
                    label4.Text = "A = Length * Length";
                    lblLength.Text = "Length :";
                    txtLength.Visible = true;
                    break;
                case 1:
                    label4.Text = "A= Length * Width";
                    lblLength.Text = "Length :";
                    txtLength.Visible = true;
                    lblWidth.Text = "Width :";
                    txtWidth.Visible = true;
                    break;
                case 2:
                    label4.Text = "A= (1/2)* Base * Altitude";
                    lblLength.Text = "Base :";
                    txtLength.Visible = true;
                    lblWidth.Text = "Altitude :";
                    txtWidth.Visible = true;
                    break;

                case 3:
                    label4.Text = "A= pi* Radius^2";
                    lblLength.Text = "Radius :";
                    txtLength.Visible = true;
                 
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0){
                double number = double.Parse(txtLength.Text);
                double area = number * number;
                answer.Text = Convert.ToString(area); }

            if (comboBox1.SelectedIndex == 1)
            {
                double number1 = double.Parse(txtLength.Text);
                double number2 = double.Parse(txtWidth.Text);
                double area = number1 * number2;
                answer.Text = Convert.ToString(area);
            }

            if (comboBox1.SelectedIndex == 2)
            {
                double number1 = double.Parse(txtLength.Text);
                double number2 = double.Parse(txtWidth.Text);
                double area = 0.5 *number1 * number2;
                answer.Text = Convert.ToString(area);
            }
            if (comboBox1.SelectedIndex == 3)
            {
                double number1 = double.Parse(txtLength.Text);
                double pi = Math.PI;
                double area = pi * Math.Pow(number1, 2);
                answer.Text = Convert.ToString(area);
            }

        }
    }
}
