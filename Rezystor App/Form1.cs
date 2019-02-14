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
        int[] index = new int[5];
        Color[] colors = new Color[] 
        {
            Color.Black, Color.Brown, Color.Red, Color.Orange, Color.Yellow, Color.Green,Color.Blue, Color.Pink, Color.Gray, Color.White
        };
        //kolory

        int[] tab = new int[]
        {
            0,1,2,5,10,20
        };

        public Form1()
        {
            InitializeComponent();
        }



        int tolerancja = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1; i<5; i++)
            {
                index[i] = 0;
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

        void Suma()
        {
            string suma = "";
            for (int i = 0; i <= 4; i++)
            {
                if (i == 4 || i == 3)
                {
                }
                else if (index[i] != 0)
                    suma += index[i].ToString();
            }
            int sumy = int.Parse(suma);
            sumy *= (int)Math.Pow(10, index[4]);




            textBox1.Text = sumy.ToString();


        }

        void Mnoznik()
        {
            string mnoznik = "";
            int wartosc = int.Parse(textBox1.Text);
            if (wartosc / 100000 > 0)
            {
                mnoznik = (wartosc / 100000).ToString() + "megaΩ ";
            }
            else if (wartosc / 1000 > 0)
            {
                mnoznik = (wartosc / 1000).ToString() + "kΩ ";
            }
            else
            {
                mnoznik = wartosc.ToString() + "Ω ";
            }
            textBox2.Text = mnoznik + " " + button4.Text + " %";
        }

        private void zmienkolor(object sender, EventArgs e)
        {
            Button ourButton = (Button)sender;

            int ind = int.Parse(ourButton.Name.Substring(ourButton.Name.Length - 1)) - 1;
            ourButton.BackColor = colors[index[ind]++];  //kolory



            if (index[ind] == 10)
            {
                index[ind] = 0;
            }
            else if (ind == 4)
            {
                ourButton.Text = Math.Pow(10, index[ind]).ToString();
            }
            else if (ind == 3)
            {
                ourButton.Text = tab[tolerancja].ToString();
                if (tolerancja == 5)
                {
                    index[ind] = 0;
                    tolerancja = 0;
                }
                else
                {
                    tolerancja++;
                }
            }
            else ourButton.Text = index[ind].ToString();
            Suma();
            Mnoznik();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
