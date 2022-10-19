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
            Xjon();
            Nevek(player1, player2);
        }


        private void Nevek(string player1, string player2)
        {
            RandomKezdes(player1, player2);
        }

        private void RandomKezdes(string player1, string player2)
        {
            if (player1.ToLower()=="cica" || player1.ToLower() == "cicuska" || player1.ToLower() == "cicamica" || player1.ToLower() == "ciculi" || player1.ToLower() == "macsek")
            {
                label1.Text = player1;
                if (player2.Length == 0) player2 = "Player2";
                label2.Text = player2;
            }
            else if (player2.ToLower() == "cica" || player2.ToLower() == "cicuska" || player2.ToLower() == "cicamica" || player2.ToLower() == "ciculi" || player2.ToLower() == "macsek")
            {
                label1.Text = player2;
                if (player1.Length == 0) player1 = "Player1";
                label2.Text = player1;
            }
            else
            {
                label1.Text = player1;
                label2.Text = player2;
            }
                label1.TextAlign = ContentAlignment.MiddleCenter;
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
                    Ojon();
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
            
                    Xjon();
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
            panel1.BackColor = Color.FromArgb(255, Color.White);
            panel2.BackColor = Color.FromArgb(0, Color.Black);
            label2.BringToFront();
            label1.Visible = false;
            label2.Visible = true;
        }

        private void Xjon()
        {
            panel1.BackColor = Color.FromArgb(0, Color.Black);
            panel2.BackColor = Color.FromArgb(255, Color.White);
            label1.BringToFront();
            label1.Visible = true;
            label2.Visible = false;
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
            int segedsor, segedoszlop;
            if (sor>oszlop)
            {
                segedsor = sor - oszlop;
                segedoszlop = 0;
               
            }
            else if(sor<oszlop){
                segedoszlop = oszlop - sor;
                segedsor = 0;
            }
            else
            {
                segedoszlop = 0;
                segedsor = 0;

            }
            if( AtloEllenorzes(segedsor, segedoszlop, xoszama, xo))
            {
                return true;
            }
            //atlo2
            xoszama = 0;
            if (sor+oszlop<24)
            {
                segedsor = 0;
                segedoszlop = sor + oszlop;

            }
            else if (sor+oszlop>24)
            {
                segedoszlop = 24;
                segedsor = oszlop+sor-segedoszlop;
            }
            else
            {
                segedoszlop = 24;
                segedsor = 0;

            }
            return Atlo2Ellenorzes(segedsor, segedoszlop, xoszama, xo);


        }

        private bool Atlo2Ellenorzes(int segedsor, int segedoszlop, int xoszama, string xo)
        {
            for (int i = 0; i <Math.Abs(segedoszlop - segedsor); i++)
            {
                if (matrix[segedsor + i, segedoszlop - i].Text == xo)
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
            return false;
        }

        private bool AtloEllenorzes(int segedsor, int segedoszlop, int xoszama, string xo)
        {
            for (int i = 0; i < meret - segedsor - segedoszlop; i++)
            {
                if (matrix[segedsor + i, segedoszlop + i].Text == xo)
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
            return false;
        }
    }
}
