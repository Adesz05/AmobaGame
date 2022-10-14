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
        public static int meret = 25;
        static Label[,] matrix = new Label[meret, meret];
        public Jatekter(string player1, string player2)
        {
            MatrixGeneralas();
            Katt();
            InitializeComponent();
        }
        private void Katt()
        {
            
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
                    matrix[i, j].Location = new Point(200 + meret * i, 10 + meret * j);
                    matrix[i, j].BorderStyle = BorderStyle.FixedSingle;
                    matrix[i, j].TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }
        private void Jatekter_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
