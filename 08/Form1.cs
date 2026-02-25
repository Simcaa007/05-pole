using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] Cisla(int n, int a, int b)
        {
            int[] pole = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next() % ((b + 1) - a) + a;
            }

            return pole;
        }

        void Zobrazeni(ListBox lb, int[] pole)
        {
            foreach (int i in pole)
            {
                lb.Items.Add(i);
            }
        }

        int[] A;
        int[] B;
        int[] C;

        private void button1_Click(object sender, EventArgs e)
        {
            A = Cisla(int.Parse(textBox3.Text), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Zobrazeni(listBox1, A);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B = Cisla(int.Parse(textBox3.Text), int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            Zobrazeni(listBox2, B);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pocet = 0;
            string cisla = "";
            foreach (int i in A)
            {
                foreach (int j in B)
                {
                    if (j == i && !cisla.Contains(j.ToString()))
                    {
                        pocet++;
                    }
                }
            }
            C = new int[pocet];

            int c = 0;
            foreach (int i in A)
            {
                foreach (int j in B)
                {
                    if (j == i && !cisla.Contains(j.ToString()))
                    {
                        C[c] = j;
                        cisla += j + "";
                        c++;
                    }
                }
            }

            for (int i = 0; i < pocet; i++)
            {
                listBox3.Items.Add(C[i]);
            }
        }
    }
}
