using System;
using System.Drawing;
using System.Windows.Forms;

namespace AmobaGame
{
    public partial class Jatekter : Form
    {
        static int meret = 25;
        static int KiJon = 0;
        static Label[,] matrix = new Label[meret, meret];
        public Jatekter(string player1, string player2)
        {
            MatrixGeneralas();
            InitializeComponent();
            Nevek(player1, player2);
        }


        private void Nevek(string player1, string player2)
        {
            label1.Text = player1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = player2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void MatrixGeneralas()
        {
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    matrix[i, j] = new Label();
                    matrix[i, j].Parent = this;
                    matrix[i, j].Name = i + "_" + j;
                    matrix[i, j].Size = new Size(meret, meret);
                    matrix[i, j].Location = new Point(200 + meret * j, 10 + meret * i);
                    matrix[i, j].BorderStyle = BorderStyle.FixedSingle;
                    matrix[i, j].Font = new Font("Arial", 16);
                    matrix[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    matrix[i, j].Padding = new Padding(3, 0, 0, 0);
                    matrix[i, j].Margin = new Padding(0, 0, 0, 0);
                    matrix[i, j].Click += new EventHandler(Klikkeles);
                }
            }
        }

        private void Klikkeles(object sender, EventArgs e)
        {
            Label klikkelt = sender as Label;
            int sor = Convert.ToInt32(klikkelt.Name.Split('_')[0]);
            int oszlop = Convert.ToInt32(klikkelt.Name.Split('_')[1]);
            if (klikkelt.Text == "")
            {
                if (KiJon == 0)
                {
                    Xjon();
                    klikkelt.Text = "X";
                    KiJon = 1;
                    klikkelt.ForeColor = Color.Red;
                    if (Ellenorzes(sor, oszlop, "X"))
                    {
                        MessageBox.Show("Nyertél X");
                    }
                }
                else
                {
                    Ojon();
                    klikkelt.Text = "O";
                    KiJon = 0;
                    klikkelt.ForeColor = Color.Blue;
                    if (Ellenorzes(sor, oszlop, "O"))
                    {
                        MessageBox.Show("Nyertél O");
                    }
                }
            }
        }

        private void Ojon()
        {
            panel1.BackColor = Color.FromArgb(0,Color.Black);
            panel2.BackColor = Color.FromArgb(255, Color.White);
            label1.BringToFront();
            label1.Visible = true;
            label2.Visible = false;
        }

        private void Xjon()
        {
            panel1.BackColor = Color.FromArgb(255, Color.White);
            panel2.BackColor = Color.FromArgb(0, Color.Black);
            label2.BringToFront();
            label1.Visible = false;
            label2.Visible = true;
        }

        private bool Ellenorzes(int sor, int oszlop, string xo)
        {
            int xoszama = 0;
            for (int i = 0; i < meret; i++)
            {
                if (matrix[sor, i].Text == xo)
                {
                    xoszama++;
                    if (xoszama == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    xoszama = 0;
                }

            }
            //fuggoleges
            xoszama = 0;
            for (int i = 0; i < meret; i++)
            {
                if (matrix[i, oszlop].Text == xo)
                {
                    xoszama++;
                    if (xoszama == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    xoszama = 0;
                }
            }
            //atlo1
            xoszama = 0;
            for (int i =0; i < meret; i++)
            {

                if (matrix[i,i].Text == xo)
                {
                    xoszama++;
                    if (xoszama == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    xoszama = 0;
                }
                sor++;
                oszlop++;

            }
            return false;
        }
    }
}
