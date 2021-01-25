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
    public partial class UI : Form
    {
        TcpClient client = new TcpClient("127.0.0.1", 8888);

        //BLACK PIECES
        readonly Image blackBishop = Image.FromFile("../../assets/BlackBishop.png");
        readonly Image blackKing = Image.FromFile("../../assets/BlackKing.png");
        readonly Image blackKnight = Image.FromFile("../../assets/BlackKnight.png");
        readonly Image blackPawn = Image.FromFile("../../assets/BlackPawn.png");
        readonly Image blackQueen = Image.FromFile("../../assets/BlackQueen.png");
        readonly Image blackRook = Image.FromFile("../../assets/BlackRook.png");

        //WHITE PIECES
        readonly Image whiteBishop = Image.FromFile("../../assets/WhiteBishop.png");
        readonly Image whiteKing = Image.FromFile("../../assets/WhiteKing.png");
        readonly Image whiteKnight = Image.FromFile("../../assets/WhiteKnight.png");
        readonly Image whitePawn = Image.FromFile("../../assets/WhitePawn.png");
        readonly Image whiteQueen = Image.FromFile("../../assets/WhiteQueen.png");
        readonly Image whiteRook = Image.FromFile("../../assets/WhiteRook.png");

        public UI()
        {
            InitializeComponent();
            NetworkStream stream = client.GetStream();

            Byte[] data = new Byte[256];

            Int32 bytes = stream.Read(data, 0, data.Length);
            string serverResponse = Encoding.ASCII.GetString(data, 0, bytes);
            DrawBoard(serverResponse);
        }

        void DrawBoard(string serverResponse)
        {
            string withoutBreak = serverResponse.Replace("\n", " ");

            string[] positions = new string[64];
            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = withoutBreak.Split(' ')[i];
            }

            for (int i = 0; i < positions.Length; i++)
            {
                if (i % 8 == 0 && i != 0)
                {
                    Console.WriteLine("\n");
                }
                Console.Write(positions[i] + " ");
            }

            var pboxes = new PictureBox[]
            {
                pbxA8, pbxB8, pbxC8, pbxD8, pbxE8, pbxF8, pbxG8, pbxH8,
                pbxA7, pbxB7, pbxC7, pbxD7, pbxE7, pbxF7, pbxG7, pbxH7,
                pbxA6, pbxB6, pbxC6, pbxD6, pbxE6, pbxF6, pbxG6, pbxH6,
                pbxA5, pbxB5, pbxC5, pbxD5, pbxE5, pbxF5, pbxG5, pbxH5,
                pbxA4, pbxB4, pbxC4, pbxD4, pbxE4, pbxF4, pbxG4, pbxH4,
                pbxA3, pbxB3, pbxC3, pbxD3, pbxE3, pbxF3, pbxG3, pbxH3,
                pbxA2, pbxB2, pbxC2, pbxD2, pbxE2, pbxF2, pbxG2, pbxH2,
                pbxA1, pbxB1, pbxC1, pbxD1, pbxE1, pbxF1, pbxG1, pbxH1
            };

            for (int i = 0; i < positions.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (positions[i] == "r")
                        pboxes[i].Image = blackRook;
                    else if (positions[i] == "n")
                        pboxes[i].Image = blackKnight;
                    else if (positions[i] == "b")
                        pboxes[i].Image = blackBishop;
                    else if (positions[i] == "q")
                        pboxes[i].Image = blackQueen;
                    else if (positions[i] == "k")
                        pboxes[i].Image = blackKing;
                    else if (positions[i] == "p")
                        pboxes[i].Image = blackPawn;
                    else if (positions[i] == "R")
                        pboxes[i].Image = whiteRook;
                    else if (positions[i] == "N")
                        pboxes[i].Image = whiteKnight;
                    else if (positions[i] == "B")
                        pboxes[i].Image = whiteBishop;
                    else if (positions[i] == "Q")
                        pboxes[i].Image = whiteQueen;
                    else if (positions[i] == "K")
                        pboxes[i].Image = whiteKing;
                    else if (positions[i] == "P")
                        pboxes[i].Image = whitePawn;
                    else if(positions[i] == ".")
                        pboxes[i].Image = null;
                }
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Byte[] data = new Byte[256];
            NetworkStream stream = client.GetStream();

            stream.Write(Encoding.ASCII.GetBytes(tbxMove.Text),0,tbxMove.Text.Length);
            Int32 bytes = stream.Read(data, 0, data.Length);
            string message = Encoding.ASCII.GetString(data, 0, bytes);
            if (message != "Draw" || message != "White won" || message != "Black won")
                DrawBoard(message);
            else
                MessageBox.Show(message);
        }
    }
}
