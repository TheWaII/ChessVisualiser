using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Chess
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            pBoxKingWhite.BackColor = Color.Green;
            pBoxKingBlack.BackColor = Color.Transparent;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            pBoxKingBlack.BackColor = Color.Green;
            pBoxKingWhite.BackColor = Color.Transparent;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            bool color = false;
            bool difficulty = false;
            string ccolor = "";
            int ddifficulty = 0;



            if (pBoxKingWhite.BackColor == pBoxKingBlack.BackColor)
            {
                MessageBox.Show("Choose color!");
            }
            else
            {
                color = true;
                if (pBoxKingBlack.BackColor == Color.Green)
                    ccolor = "black";
                else
                    ccolor = "white";
            }

            if (nudDifficulty.Value <= 0)
            {
                MessageBox.Show("Choose difficulty");
            }
            else
            {
                difficulty = true;
                ddifficulty = (int)nudDifficulty.Value;
            }

            if (color && difficulty)
            {
                Connection connection = new Connection();
                string message = connection.Connect(ccolor + ";" + ddifficulty.ToString());

                if (message == "connected")
                {
                    UI ui = new UI();
                    ui.Show();
                    btnBlack.Enabled = false; 
                    btnWhite.Enabled = false;
                    btnPlay.Enabled = false;
                }
            }
        }
    }
}
