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
            if (player1.Length == 0) player1 = "Player1";
            if (player2.Length == 0) player2 = "Player2";
            
            Jatekter jatekter = new Jatekter(player1,player2);

            this.Visible = false;
            jatekter.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "A két játékos felváltva tesz egy X-et vagy egy kört bábut a táblára. A játék célja, hogy vízszintes, függőleges vagy átlós irányban megszakítás nélkül öt saját bábut sikerüljön letenni. Az ellenfél ezt a kialakulni látszó vonal végére tett bábukkal próbálja megakadályozni.";
            MessageBox.Show(message, "Játékszabály", MessageBoxButtons.OK);
        }
    }
}