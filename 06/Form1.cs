using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            pole = new double[n];
            Random rnd = new Random();

            double max = 0;
            double min = double.MaxValue;
            int poziceMax = 0; int poziceMin = 0;

            for (int i = 0; i < n; i++)
            {
                double cislo = Math.Round(rnd.NextDouble() * (1000 - 1) + 1, 2);
                pole[i] = cislo;
                listBox1.Items.Add(cislo);

                if (cislo > max)
                {
                    max = cislo;
                    poziceMax = i;
                }
                if (cislo < min)
                {
                    min = cislo;
                    poziceMin = i;
                }
            }

            MessageBox.Show($"max: {max}, min: {min}");

            pole[poziceMin] = max;
            pole[poziceMax] = min;

            double soucet = 0;


            for (int i = 0; i < n; i++)
            {
                double cislo = pole[i];
                listBox2.Items.Add(cislo);
                if (cislo != pole[poziceMax] && cislo != pole[poziceMin])
                {
                    soucet += cislo;
                }
            }

            double prumer = soucet / (n - 2);

            MessageBox.Show($"Prumer je teda: {prumer}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
