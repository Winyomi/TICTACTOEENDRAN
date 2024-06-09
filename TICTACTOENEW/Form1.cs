using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private TicTacToeGame game;
        private Button[,] buttons;
        private Administrator admin;
        private Player player;

        public Form1(Player player, Administrator admin)
        {
            InitializeComponent();
            this.player = player;
            this.admin = admin;
            game = new TicTacToeGame();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            buttons = new Button[3, 3] {
                { btn00, btn01, btn02 },
                { btn10, btn11, btn12 },
                { btn20, btn21, btn22 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true; 
                    buttons[i, j].Click += new EventHandler(ButtonClick);
                }
            }

            lblStatus.Text = "Player X's turn";
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (player == null)
            {
                lblStatus.Text = "Please login to play.";
                return;
            }

            Button clickedButton = sender as Button;
            int row = -1, col = -1;

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j] == clickedButton)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
                if (row != -1) break;
            }

            if (game.MakeMove(row, col))
            {
                clickedButton.Text = game.CurrentPlayer.ToString();

                if (game.CheckWinner())
                {
                    lblStatus.Text = $"Player {game.CurrentPlayer} wins!";
                    DisableButtons();
                }
                else if (game.IsDraw())
                {
                    lblStatus.Text = "It's a draw!";
                }
                else
                {
                    game.SwitchPlayer();
                    lblStatus.Text = $"Player {game.CurrentPlayer}'s turn";
                }
            }
        }

        private void DisableButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void EnableButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }

        private void btnOpenAdminForm_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm(admin);
            adminForm.ShowDialog();
        }

        private void btnOpenLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(admin); 
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                player = loginForm.Player;
                lblStatus.Text = "Login successful. Player X's turn.";
            }
            else
            {
                lblStatus.Text = "Login failed.";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            player = null;
            lblStatus.Text = "Logged out.";
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(admin);
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            game = new TicTacToeGame();
            InitializeBoard();
            lblStatus.Text = "Player X's turn";
        }
    }
}
