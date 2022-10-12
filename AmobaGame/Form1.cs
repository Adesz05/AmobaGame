using System;
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
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string player1 = textBox1.Text;
            string player2 = textBox2.Text;

            if (player1 == "")
            {
                player1 = "player1";
            }
            if (player2 == "")
            {
                player2 = "player2";
            }
            Jatekter jatekter = new Jatekter();
            this.Visible = false;
            jatekter.ShowDialog();
            Close();
        }
    }
}
