using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random rnd = new Random();
            char[] znaky = new char[n];

            int Od = '0';
            int Do = 'B';
            for (int i = 0; i < n; i++)
            {
                int c = rnd.Next() % (Do - Od) + Od;
                char z = (char)c;
                znaky[i] = z;
                listBox1.Items.Add(z);
            }

            if (znaky[n-1] >= '0' && znaky[n - 1] <= '9')
            {
                for (int i = 0; i < n; i++)
                {
                    if (znaky[i] >= '0' && znaky[i] <= '9')
                    {
                        znaky[i] = 'x';
                    }
                    listBox2.Items.Add(znaky[i]);
                }
            }
            else
            {
                int max = 0;
                int poziceMax = 0;
                for (int i = 0; i < n; i++)
                {
                    int hodnota = (int)znaky[i];
                    if(hodnota > max){
                        max = hodnota;
                        poziceMax = i;
                    }
                }

                znaky[poziceMax] = znaky[n - 1];
                znaky[n - 1] = (char)max;
                
                for (int i = 0; i < n; i++)
                {
                    listBox2.Items.Add(znaky[i]);
                }
            }
        }
    }
}
