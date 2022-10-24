﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmobaGame
{
    public partial class Jatekter : Form
    {

        static int meret = 25;
        static int KiJon = 0;
        static Label[,] matrix = new Label[meret, meret];
        static Player player1;
        static Player player2;
        static int futasokSzama = 0;
        static List<NyeroKoordinatak> koordinatak = new List<NyeroKoordinatak>();

        public Jatekter(string Player1, string Player2)
        {
            MatrixGeneralas();
            InitializeComponent();
            Xjon();
            if (futasokSzama<1)
            {
            player1 = new Player(Player1,'X',0);
            player2 = new Player(Player2,'O',0);
            }
            Nevek();
        }

        private void Nevek()
        {
            if (futasokSzama<1)
            {
            RandomKezdes();
            }
            else
            {
                if (player1.MivelVan=='X')
                {
                    XLabel.Text = player1.Nev;
                    OLabel.Text = player2.Nev;
                    Xpontszam.Text = "Győzelmek: "+player1.Pontszam.ToString();
                    Opontszam.Text = "Győzelmek: "+player2.Pontszam.ToString();
                    
                }
                else
                {
                    OLabel.Text = player1.Nev;
                    XLabel.Text = player2.Nev;
                    Xpontszam.Text = "Győzelmek: "+player2.Pontszam.ToString();
                    Opontszam.Text = "Győzelmek: "+player1.Pontszam.ToString();
                }
                XLabel.TextAlign = ContentAlignment.MiddleCenter;
                OLabel.TextAlign = ContentAlignment.MiddleCenter;
                Xpontszam.TextAlign = ContentAlignment.MiddleCenter;
                Opontszam.TextAlign = ContentAlignment.MiddleCenter;

            }
            futasokSzama++;

        }

        private void RandomKezdes()
        {
            Random r = new Random();
            int r1 = r.Next(1, 3);
            if (r1 == 1)
            {
                XLabel.Text = player1.Nev;
                OLabel.Text = player2.Nev;
                player1.MivelVan = 'X';
                player2.MivelVan = 'O';
                Xpontszam.Text = "Győzelmek: "+player2.Pontszam.ToString();
                Opontszam.Text = "Győzelmek: "+player1.Pontszam.ToString();
            }
            else
            {
                XLabel.Text = player2.Nev;
                OLabel.Text = player1.Nev;
                Xpontszam.Text = "Győzelmek: "+player1.Pontszam.ToString();
                Opontszam.Text = "Győzelmek: "+player2.Pontszam.ToString();
                player1.MivelVan = 'O';
                player2.MivelVan = 'X';
            }
            if (player1.Nev.ToLower() == "cica" || player1.Nev.ToLower() == "cicuska" || player1.Nev.ToLower() == "cicamica" || player1.Nev.ToLower() == "ciculi" || player1.Nev.ToLower() == "macsek")
            {
                XLabel.Text = player1.Nev;
                if (player2.Nev.Length == 0) player2.Nev = "Player2";
                OLabel.Text = player2.Nev;
            }
            else if (player2.Nev.ToLower() == "cica" || player2.Nev.ToLower() == "cicuska" || player2.Nev.ToLower() == "cicamica" || player2.Nev.ToLower() == "ciculi" || player2.Nev.ToLower() == "macsek")
            {
                XLabel.Text = player2.Nev;
                if (player1.Nev.Length == 0) player1.Nev = "Player1";
                OLabel.Text = player1.Nev;
            }
            XLabel.TextAlign = ContentAlignment.MiddleCenter;
                OLabel.TextAlign = ContentAlignment.MiddleCenter;
            Xpontszam.TextAlign = ContentAlignment.MiddleCenter;
            Opontszam.TextAlign = ContentAlignment.MiddleCenter;
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
                        DialogResult valasz;
                        NyeroOtosSzinezes();
                        if (player1.MivelVan=='X')
                        {
                            player1.Pontszam++;
                        valasz = MessageBox.Show(player1.Nev+" Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        else
                        {
                            player2.Pontszam++;
                        valasz = MessageBox.Show(player2.Nev+" Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        TovabbJatszik(valasz);
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
                        NyeroOtosSzinezes();
                        DialogResult valasz;
                        if (player1.MivelVan == 'O')
                        {
                            player1.Pontszam++;
                            valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        else
                        {
                            player2.Pontszam++;
                            valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        TovabbJatszik(valasz);
                    }
                }
            }
        }

        private void TovabbJatszik(DialogResult valasz)
        {
            if (valasz == DialogResult.Yes)
            {
                char seged = player1.MivelVan;
                player1.MivelVan = player2.MivelVan;
                player2.MivelVan = seged;
                KiJon = 0;
                Jatekter jatekter = new Jatekter(player1.Nev, player2.Nev);
                this.Visible = false;
                jatekter.ShowDialog();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void NyeroOtosSzinezes()
        {
            for (int i = 0; i < 5; i++)
            {
                matrix[koordinatak[i].X,koordinatak[i].Y].BackColor = Color.Black;
            }
        }

        private void Ojon()
        {
            pirosAmong.Visible = false;
            kekAmong.Visible = true;
            Opontszam.Visible = true;
            Xpontszam.Visible = false;
            kekKor.Visible = true;
            pirosX.Visible = false;
            XLabel.Visible = false;
            OLabel.Visible = true;
            kekFeladas.Visible = true;
            pirosFeladas.Visible = false;
        }

        private void Xjon()
        {
            pirosAmong.Visible = true;
            kekAmong.Visible = false;
            Opontszam.Visible = false;
            Xpontszam.Visible = true;
            kekKor.Visible = false;
            pirosX.Visible = true;
            XLabel.Visible = true;
            OLabel.Visible = false;
            kekFeladas.Visible = false;
            pirosFeladas.Visible = true;
        }

        private bool Ellenorzes(int sor, int oszlop, string xo)
        {
            //vizszintes
            int xoszama = 0;
            for (int i = 0; i < meret; i++)
            {
                if (matrix[sor, i].Text == xo)
                {
                    xoszama++;
                    koordinatak.Add(new NyeroKoordinatak(matrix[sor,i].Name));
                    if (xoszama == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    xoszama = 0;
                    koordinatak.Clear();
                }

            }
            //fuggoleges
            xoszama = 0;
            for (int i = 0; i < meret; i++)
            {
                if (matrix[i, oszlop].Text == xo)
                {
                    xoszama++;
                    koordinatak.Add(new NyeroKoordinatak(matrix[i, oszlop].Name));
                    if (xoszama == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    xoszama = 0;
                    koordinatak.Clear();
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
                    koordinatak.Add(new NyeroKoordinatak(matrix[segedsor + i, segedoszlop - i].Name));
                    if (xoszama == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    xoszama = 0;
                    koordinatak.Clear();
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
                    koordinatak.Add(new NyeroKoordinatak(matrix[segedsor + i, segedoszlop + i].Name));
                    if (xoszama == 5)
                    {
                        return true;
                    }
                }
                else
                {
                    koordinatak.Clear();
                    xoszama = 0;
                }
            }
            return false;
        }

        private void pirosFeladas_Click(object sender, EventArgs e)
        {
            if (player1.MivelVan== 'X')
            {
                player2.Pontszam++;
                DialogResult valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
            else
            {
                player1.Pontszam++;
                DialogResult valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }

        }

        private void kekFeladas_Click(object sender, EventArgs e)
        {
            if (player1.MivelVan == 'O')
            {
                player2.Pontszam++;
                DialogResult valasz = MessageBox.Show(player2.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
            else
            {
                player1.Pontszam++;
                DialogResult valasz = MessageBox.Show(player1.Nev + " Nyert!\nSzeretnétek játszani mégegyet?", "Ügyi bügyi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                TovabbJatszik(valasz);
            }
        }
    }
}
