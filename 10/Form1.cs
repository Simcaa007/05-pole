using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            pole = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int cislo = rnd.Next() % (11 - 1) + 1;
                pole[i] = cislo;
                listBox1.Items.Add(pole[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (radioButton1.Checked)
            {
                Array.Sort(pole);

                foreach (int i in pole)
                {
                    listBox2.Items.Add(i);
                }
            }
            else if (radioButton2.Checked)
            {
                Array.Sort(pole);
                Array.Reverse(pole);

                foreach(int i in pole)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Array.Sort(pole);
            int min = pole[1];
            int max = pole[pole.Length - 2];

            MessageBox.Show($"Druhy nejmensi prvek posloupnosti je cislo {min}" +
                $" a druhy nejvetsi prvek je cislo {max}");
        }
    }
}
