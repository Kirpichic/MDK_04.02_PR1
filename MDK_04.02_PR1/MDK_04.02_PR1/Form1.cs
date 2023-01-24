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
        double x, y, z;

        private void button2_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(BoxX.Text); y = Convert.ToDouble(BoxY.Text);
            if (f1.Checked == true) {

                if ((x*y<4) & (x*y>1)) {

                    otvet2.Text = Convert.ToString(Math.Pow((Math.Cos(x)+y),2));

                } else if ((x * y < 10) & (x * y > 8))
                {

                    otvet2.Text = Convert.ToString(Math.Cos(x) * Math.Tan(y)) ;

                } else
                {
                    otvet2.Text = Convert.ToString(Math.Cos(x) + y);
                }
           
            } else if (f2.Checked == true) {

                if ((x * y < 4) & (x * y > 1))
                {

                    otvet2.Text = Convert.ToString(Math.Pow((Math.Pow(x,2) + y), 2));

                }
                else if ((x * y < 10) & (x * y > 8))
                {

                    otvet2.Text = Convert.ToString(Math.Pow(x,2) * Math.Tan(y));

                }
                else
                {
                    otvet2.Text = Convert.ToString(Math.Pow(x,2) + y);
                }

            } else if (f3.Checked == true)
            {

                if ((x * y < 4) & (x * y > 1))
                {

                    otvet2.Text = Convert.ToString(Math.Pow((Math.Exp(x) + y), 2));

                }
                else if ((x * y < 10) & (x * y > 8))
                {

                    otvet2.Text = Convert.ToString(Math.Exp(x) * Math.Tan(y));

                }
                else
                {
                    otvet2.Text = Convert.ToString(Math.Exp(x) + y);
                }

            }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBoxX.Text); y = Convert.ToDouble(textBoxY.Text); z = Convert.ToDouble(textBoxZ.Text);
            Otwet.Text = Convert.ToString(((2 * Math.Cos(x - (Math.PI / 6))) / (0.5 + (Math.Sin(y) * Math.Sin(y)))) * (1 + ((z * z) / (3 - ((z * z) / 5)))));
        }
    }
}
