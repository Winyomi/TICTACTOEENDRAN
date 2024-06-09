using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class AdminForm : Form
    {
        private Administrator admin;

        public AdminForm(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;

            SetPlaceholder(txtPlayerId, "Player ID");
            SetPlaceholder(txtPlayerPassword, "Password");
            SetPlaceholder(txtNewPassword, "New Password");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.ForeColor = Color.Black;
                    textBox.Text = "";
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = placeholder;
                }
            };
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            string playerId = txtPlayerId.Text;
            string playerPassword = txtPlayerPassword.Text;

            if (string.IsNullOrWhiteSpace(playerId) || playerId == "Player ID" ||
                string.IsNullOrWhiteSpace(playerPassword) || playerPassword == "Password")
            {
                MessageBox.Show("Please enter valid player details.");
                return;
            }

            admin.CreatePlayer(playerId, playerPassword);
            MessageBox.Show($"Player {playerId} created successfully.");
        }

        private void btnUpdatePlayerPassword_Click(object sender, EventArgs e)
        {
            string playerId = txtPlayerId.Text;
            string newPassword = txtNewPassword.Text;

            if (string.IsNullOrWhiteSpace(playerId) || playerId == "Player ID" ||
                string.IsNullOrWhiteSpace(newPassword) || newPassword == "New Password")
            {
                MessageBox.Show("Please enter valid player ID and new password.");
                return;
            }

            var player = admin.GetPlayers().Find(p => p.PlayerID == playerId);
            if (player != null)
            {
                admin.UpdatePlayerPassword(player, newPassword);
                MessageBox.Show($"Password for player {playerId} updated successfully.");
            }
            else
            {
                MessageBox.Show($"Player {playerId} not found.");
            }
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            LoginForm loginForm = new LoginForm(admin);
            loginForm.ShowDialog(); 
            this.Close(); 
        }
    }
}
