using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTakToe
{
    class Engine
    {
        private char ch ='1';
        public char [][] board;

        public Engine()
        {
            board = new char[3][];
            for(int i=0; i<3; i++)
            {
                board[i] = new char[3];
            }

            for(int i=0; i<3; i++)
            { 
                for(int j=0; j<3; j++)
                {
                    board[i][j] = ch++;
                }
            }
        }

        public void Display()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void Reset()
        {
            ch = '1';
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i][j] = ch++;
                }
            }
        }

        public bool Check()
        {
            if ((board[0][0] == board[1][1] && board[0][0] == board[2][2]) || (board[0][2] == board[1][1] && board[0][2] == board[2][0]))
                return true;
            else
            {
                for(int i=0; i<3; i++)
                {
                    if ((board[i][0] == board[i][1] && board[i][0] == board[i][2]) || (board[0][i] == board[1][i] && board[0][i] == board[2][i]))
                        return true;
                }
            }
            return false;
        }

        public bool isDraw()
        {
            int counter=0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] > '9')
                        counter++;
                }
            }

            if (counter == 9)
                return true;
            else
                return false;
        }

    }

    public partial class Form1 : Form
    {
        private int player = 1;
        private Engine eng;
        public Form1()
        {
            InitializeComponent();
            eng = new Engine();
            this.SetStyles();
            this.AddListener();
            this.Text = "Tic Tak Toe";
            this.BackColor = Color.Black;
            this.MaximizeBox = false;
        }

        private void AddListener()
        {
            button1.Click += new EventHandler(Button1_Click);
            button2.Click += new EventHandler(Button2_Click);
            button3.Click += new EventHandler(Button3_Click);
            button4.Click += new EventHandler(Button4_Click);
            button5.Click += new EventHandler(Button5_Click);
            button6.Click += new EventHandler(Button6_Click);
            button7.Click += new EventHandler(Button7_Click);
            button8.Click += new EventHandler(Button8_Click);
            button9.Click += new EventHandler(Button9_Click);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (eng.board[2][2] == 'X' || eng.board[2][2] == 'O')
                MessageBox.Show("Invalid Move");
            else
            {
                if (player == 1)
                {
                    eng.board[2][2] = 'X';
                    button9.Text = "X";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[2][2] = 'O';
                    button9.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (eng.board[2][1] == 'X' || eng.board[2][1] == 'O')
                MessageBox.Show("Invalid Move");
            else
            {
                if (player == 1)
                {
                    eng.board[2][1] = 'X';
                    button8.Text = "X";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[2][1] = 'O';
                    button8.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (eng.board[2][0] == 'X' || eng.board[2][0] == 'O')
                MessageBox.Show("Invalid Move");
            else
            {
                if (player == 1)
                {
                    eng.board[2][0] = 'X';
                    button7.Text = "X";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[2][0] = 'O';
                    button7.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (eng.board[1][2] == 'X' || eng.board[1][2] == 'O')
                MessageBox.Show("Invalid Move");
            else
            {
                if (player == 1)
                {
                    eng.board[1][2] = 'X';
                    button6.Text = "X";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[1][2] = 'O';
                    button6.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (eng.board[1][1] == 'X' || eng.board[1][1] == 'O')
                MessageBox.Show("Invalid Move");
            else
            {
                if (player == 1)
                {
                    eng.board[1][1] = 'X';
                    button5.Text = "X";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[1][1] = 'O';
                    button5.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (eng.board[1][0] == 'X' || eng.board[1][0] == 'O')
                MessageBox.Show("Invalid Move");
            else
            {
                if (player == 1)
                {
                    eng.board[1][0] = 'X';
                    button4.Text = "X";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[1][0] = 'O';
                    button4.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (eng.board[0][2] == 'X' || eng.board[0][2] == 'O')
                MessageBox.Show("Invalid Move");
            else
            {
                if (player == 1)
                {
                    eng.board[0][2] = 'X';
                    button3.Text = "X";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[0][2] = 'O';
                    button3.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (eng.board[0][1] == 'X' || eng.board[0][1] == 'O')
                MessageBox.Show("Invalid Move");
            else
            {
                if (player == 1)
                {
                    eng.board[0][1] = 'X';
                    button2.Text = "X";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[0][1] = 'O';
                    button2.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (eng.board[0][0] == 'X' || eng.board[0][0] == 'O')
                MessageBox.Show("Invalid Move");
            else 
            {
                if(player == 1)
                {
                    eng.board[0][0] = 'X';
                    button1.Text = "X";
                    if(eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player++;
                    label1.Text = "Player " + player.ToString();
                }
                else
                {
                    eng.board[0][0] = 'O';
                    button1.Text = "O";
                    if (eng.Check() == true)
                    {
                        MessageBox.Show("Player " + player.ToString() + " has won the match");
                        this.Reset();
                        goto End;
                    }
                    else if (eng.isDraw() == true)
                    {
                        MessageBox.Show("........Match is Draw........");
                        this.Reset();
                        goto End;
                    }
                    player--;
                    label1.Text = "Player " + player.ToString();
                }
            End:
                Console.WriteLine("");
            }
        }

        private void SetStyles()
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
            button9.BackColor = Color.Black;
            button9.ForeColor = Color.White;

            button1.Font = new Font("Ariel", 30);
            button1.Text = eng.board[0][0].ToString();
            button2.Font = new Font("Ariel", 30);
            button2.Text = eng.board[0][1].ToString();
            button3.Font = new Font("Ariel", 30);
            button3.Text = eng.board[0][2].ToString();
            button4.Font = new Font("Ariel", 30);
            button4.Text = eng.board[1][0].ToString();
            button5.Font = new Font("Ariel", 30);
            button5.Text = eng.board[1][1].ToString();
            button6.Font = new Font("Ariel", 30);
            button6.Text = eng.board[1][2].ToString();
            button7.Font = new Font("Ariel", 30);
            button7.Text = eng.board[2][0].ToString();
            button8.Font = new Font("Ariel", 30);
            button8.Text = eng.board[2][1].ToString();
            button9.Font = new Font("Ariel", 30);
            button9.Text = eng.board[2][2].ToString();

            label1.Text = "Player " + player.ToString();
            label1.ForeColor = Color.White;

        }

        private void Reset()
        {
            player = 1;
            eng.Reset();
            this.SetStyles();
            label1.Text = "Player " + player.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
