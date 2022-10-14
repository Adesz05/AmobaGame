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
        public int meret = 20;
        static Label[,] matrix = new Label[20, 20];
        public Jatekter(string player1, string player2)
        {
            MatrixGeneralas();
            InitializeComponent();
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
                    matrix[i, j].Size = new Size(20, 20);
                    matrix[i, j].Location = new Point(10 + 20 * i, 10 + 20 * j);
                    matrix[i, j].BorderStyle = BorderStyle.FixedSingle;
                    matrix[i, j].TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }
        private void Jatekter_Load(object sender, EventArgs e)
        {
           
        }
    }
}
