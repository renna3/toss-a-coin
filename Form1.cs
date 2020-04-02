using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moneta_probabilità
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //0 = heads
            //1 = tails
            Random r = new Random();
            long n = Convert.ToInt64(textBox1.Text);
            long heads = 0;
            long tails = 0;

            //check the value
            if (n > 0)
            {
                for (long i = 0; i < n; i++)
                {
                    if (r.Next(0, 2) == 0)
                        heads++;
                    else
                        tails++;
                }
                long total = heads + tails;
                double heads_percentage = 100.0 * heads / total;
                double tails_percentage = 100.0 * tails / total;
                MessageBox.Show("The total amount of tosses is " + total + "\n" + "The amount of heads is " + heads +
                    "\n" + "The amount of tails is " + tails + "\n" + "The percentage of heads is " + heads_percentage +
                    "%\n" + "The percentage of tails is " + tails_percentage + "%", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (n == 0)
                MessageBox.Show("No tosses done.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else
                MessageBox.Show("The value must be between 0 and 9,223,372,036,854,775,807", "Error01", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
