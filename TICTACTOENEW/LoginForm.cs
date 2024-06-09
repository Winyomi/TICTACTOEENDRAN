using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class LoginForm : Form
    {
        private Administrator admin;
        private Player player;

        public LoginForm(Administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        public Player Player
        {
            get { return player; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string id = txtPlayerId.Text;
            string pass = txtPlayerPassword.Text;

            if (admin.verifyLogin(id, pass))
            {
                lblStatus.Text = $"Administrator {id} logged in.";
                this.DialogResult = DialogResult.OK;

                this.Hide();
                AdminForm adminForm = new AdminForm(admin);
                adminForm.ShowDialog();
                this.Close();
                return;
            }

            foreach (var user in admin.GetPlayers())
            {
                if (user.verifyLogin(id, pass))
                {
                    player = user;
                    lblStatus.Text = $"Player {id} logged in.";
                    this.DialogResult = DialogResult.OK;

                    this.Hide();
                    Form1 gameForm = new Form1(player, admin);
                    gameForm.ShowDialog();
                    this.Close();
                    return;
                }
            }

            lblStatus.Text = "Login failed.";
        }
    }
}
