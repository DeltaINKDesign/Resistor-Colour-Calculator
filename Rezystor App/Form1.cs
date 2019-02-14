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
            foreach(int v in indeksy)
            {
                suma += v;

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button ourButton = (Button)sender;
            int ind = int.Parse(ourButton.Name.Substring(ourButton.Name.Length - 1)) - 1;
            ourButton.BackColor = kolory[indeksy[ind]++];
            if (indeksy[ind] == 10)
            {
                indeksy[ind] = 0;
            }
            ourButton.Text = indeksy[ind].ToString();
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
            ourButton.Text = indeksy[ind].ToString();
            Sum();
        }
    }
}
