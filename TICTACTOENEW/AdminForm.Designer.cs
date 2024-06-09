namespace TicTacToe
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.TextBox txtPlayerPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.Button btnUpdatePlayerPassword;
        private System.Windows.Forms.Button btnLogout; 

        private void InitializeComponent()
        {
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.txtPlayerPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.btnUpdatePlayerPassword = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button(); 
            this.SuspendLayout();
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.Location = new System.Drawing.Point(12, 12);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.Size = new System.Drawing.Size(260, 20);
            this.txtPlayerId.TabIndex = 0;
            // 
            // txtPlayerPassword
            // 
            this.txtPlayerPassword.Location = new System.Drawing.Point(12, 38);
            this.txtPlayerPassword.Name = "txtPlayerPassword";
            this.txtPlayerPassword.Size = new System.Drawing.Size(260, 20);
            this.txtPlayerPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(12, 64);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(260, 20);
            this.txtNewPassword.TabIndex = 2;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.Location = new System.Drawing.Point(12, 90);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(260, 23);
            this.btnCreatePlayer.TabIndex = 3;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = true;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // btnUpdatePlayerPassword
            // 
            this.btnUpdatePlayerPassword.Location = new System.Drawing.Point(12, 119);
            this.btnUpdatePlayerPassword.Name = "btnUpdatePlayerPassword";
            this.btnUpdatePlayerPassword.Size = new System.Drawing.Size(260, 23);
            this.btnUpdatePlayerPassword.TabIndex = 4;
            this.btnUpdatePlayerPassword.Text = "Update Player Password";
            this.btnUpdatePlayerPassword.UseVisualStyleBackColor = true;
            this.btnUpdatePlayerPassword.Click += new System.EventHandler(this.btnUpdatePlayerPassword_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 148);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(260, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click); 
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.btnLogout); 
            this.Controls.Add(this.btnUpdatePlayerPassword);
            this.Controls.Add(this.btnCreatePlayer);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtPlayerPassword);
            this.Controls.Add(this.txtPlayerId);
            this.Name = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
