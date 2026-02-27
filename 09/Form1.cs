using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n;
        double[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            pole = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                double cislo = Math.Round(rnd.NextDouble() * (21 - 1) + 1, 2);
                pole[i] = cislo;
            }
            Array.Sort(pole);
            foreach (double d in pole)
            {
                listBox1.Items.Add(d);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double b = double.Parse(textBox2.Text);
            int pocet = 0;

            foreach (double cislo in pole)
            {
                if (cislo <= b)
                {
                    pocet++;
                }
            }
            double[] pole2 = pole.Take(pocet).ToArray();

            foreach (double d in pole2)
            {
                listBox2.Items.Add(d);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double b = double.Parse(textBox2.Text);

            int pocet = 0;
            foreach (double d in pole)
            {
                if (d <= b)
                {
                    pocet++;
                }
            }

            double[] pole3 = pole.Skip(pocet).ToArray();

            foreach(double d in pole3)
            {
                listBox3.Items.Add(d);
            }
        }
    }
}
