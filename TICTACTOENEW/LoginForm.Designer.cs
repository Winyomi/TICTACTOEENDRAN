using System;

namespace TicTacToe
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.ForeColor = System.Drawing.Color.Gray;
            this.txtPlayerId.Location = new System.Drawing.Point(12, 12);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerId.TabIndex = 0;
            this.txtPlayerId.Text = "Player ID";
            this.txtPlayerId.Enter += new System.EventHandler(this.txtPlayerId_Enter);
            this.txtPlayerId.Leave += new System.EventHandler(this.txtPlayerId_Leave);
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPlayerPassword.Location = new System.Drawing.Point(118, 12);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerPassword.TabIndex = 1;
            this.txtPlayerPassword.Text = "Password";
            this.txtPlayerPassword.Enter += new System.EventHandler(this.txtPlayerPassword_Enter);
            this.txtPlayerPassword.Leave += new System.EventHandler(this.txtPlayerPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(224, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(336, 71);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPlayerPassword);
            this.Controls.Add(this.txtPlayerId);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtPlayerId_Enter(object sender, EventArgs e)
        {
            if (txtPlayerId.Text == "Player ID")
            {
                txtPlayerId.Text = "";
                txtPlayerId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPlayerId_Leave(object sender, EventArgs e)
        {
            if (txtPlayerId.Text == "")
            {
                txtPlayerId.Text = "Player ID";
                txtPlayerId.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtPlayerPassword_Enter(object sender, EventArgs e)
        {
            if (txtPlayerPassword.Text == "Password")
            {
                txtPlayerPassword.Text = "";
                txtPlayerPassword.ForeColor = System.Drawing.Color.Black;
                txtPlayerPassword.PasswordChar = '*';
            }
        }

        private void txtPlayerPassword_Leave(object sender, EventArgs e)
        {
            if (txtPlayerPassword.Text == "")
            {
                txtPlayerPassword.Text = "Password";
                txtPlayerPassword.ForeColor = System.Drawing.Color.Gray;
                txtPlayerPassword.PasswordChar = '\0';
            }
        }
    }
}
