using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK_04._02_PR1
{
    public partial class Form1 : Form
    {
        /*double V = 0;*/
        double x, y, z;

        public Form1()
        {
            InitializeComponent();
            /*textBoxX.Text = Convert.ToString(V);
            textBoxY.Text = Convert.ToString(V);
            textBoxZ.Text = Convert.ToString(V);*/
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            /*x = Convert.ToDouble(textBoxX.Text); y = Convert.ToDouble(textBoxY.Text); z = Convert.ToDouble(textBoxZ.Text);
            xyz(x, y, z);*/
        }

        private void textBoxZ_TextChanged(object sender, EventArgs e)
        {
            /*xyz(Convert.ToDouble(textBoxX.Text), Convert.ToDouble(textBoxY.Text), Convert.ToDouble(textBoxZ.Text));*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
                x = Convert.ToDouble(textBoxX.Text); y = Convert.ToDouble(textBoxY.Text); z = Convert.ToDouble(textBoxZ.Text);
                Otwet.Text = Convert.ToString(((2 * Math.Cos(x - (Math.PI / 6))) / (0.5 + (Math.Sin(y) * Math.Sin(y)))) * (1 + ((z * z) / (3 - ((z * z) / 5)))));
        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
            /*xyz(Convert.ToDouble(textBoxX.Text), Convert.ToDouble(textBoxY.Text), Convert.ToDouble(textBoxZ.Text));*/
        }

        /*void xyz(double x, double y, double z)
        {
            Otwet.Text = Convert.ToString(((2*Math.Cos(x-(Math.PI/6)))/(0.5+(Math.Sin(y)*Math.Sin(y))))*(1+((z*z)/(3-((z*z)/5)))));
        }*/
    }
}
