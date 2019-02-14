using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezystor_App
{
    public partial class Form1 : Form
    {
        int[] indeksy = new int[5];
        Color[] kolory = new Color[]
        {
            Color.Black,
            Color.Brown,
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Blue,
            Color.Pink,
            Color.Gray,
            Color.White

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1; i<5; i++)
            {
                indeksy[i] = 0;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        void Sum()
        {
            int suma = 0;
            for (int i = 0; i < 4; i++)
            {
                if (i == 4)
                {
                    suma *= (int)Math.Pow(10, indeksy[i]);
                }
                else
                    suma += indeksy[i];
            }
            textBox1.Text = suma.ToString();
            
            
        }

        void Mnoznik()
        {
            string mnoznik;
            if (int.Parse(textBox1.Text) % 1000 == 0)
            {

            }
        }

        private void zmienkolor(object sender, EventArgs e)
        {
            Button ourButton = (Button)sender;
            int ind = int.Parse(ourButton.Name.Substring(ourButton.Name.Length - 1)) - 1;
            ourButton.BackColor = kolory[indeksy[ind]++];
            if (indeksy[ind] == 10)
            {
                indeksy[ind] = 0;
            }
            if (ind == 4)
            {
                ourButton.Text = Math.Pow(10, indeksy[ind]).ToString();
            }
            ourButton.Text = indeksy[ind].ToString();
            Sum();
            Mnoznik();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
