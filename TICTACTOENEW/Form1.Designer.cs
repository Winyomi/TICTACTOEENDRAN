namespace TicTacToe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOpenAdminForm;
        private System.Windows.Forms.Button btnOpenLoginForm;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;

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
            this.btn00 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnOpenAdminForm = new System.Windows.Forms.Button();
            this.btnOpenLoginForm = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(50, 7);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(75, 75);
            this.btn00.TabIndex = 0;
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(131, 7);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(75, 75);
            this.btn01.TabIndex = 1;
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(212, 7);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(75, 75);
            this.btn02.TabIndex = 2;
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(50, 88);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(75, 75);
            this.btn10.TabIndex = 3;
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(131, 88);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(75, 75);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(212, 88);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(75, 75);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(50, 169);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(75, 75);
            this.btn20.TabIndex = 6;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(131, 169);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(75, 75);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            this.btn21.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(212, 169);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(75, 75);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            this.btn22.Click += new System.EventHandler(this.ButtonClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(47, 275);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            // 
            // btnOpenAdminForm
            // 
            this.btnOpenAdminForm.Location = new System.Drawing.Point(293, 88);
            this.btnOpenAdminForm.Name = "btnOpenAdminForm";
            this.btnOpenAdminForm.Size = new System.Drawing.Size(125, 23);
            this.btnOpenAdminForm.TabIndex = 10;
            this.btnOpenAdminForm.Text = "Admin Panel";
            this.btnOpenAdminForm.UseVisualStyleBackColor = true;
            this.btnOpenAdminForm.Click += new System.EventHandler(this.btnOpenAdminForm_Click);
            // 
            // btnOpenLoginForm
            // 
            this.btnOpenLoginForm.Location = new System.Drawing.Point(293, 140);
            this.btnOpenLoginForm.Name = "btnOpenLoginForm";
            this.btnOpenLoginForm.Size = new System.Drawing.Size(125, 23);
            this.btnOpenLoginForm.TabIndex = 11;
            this.btnOpenLoginForm.Text = "Player Login";
            this.btnOpenLoginForm.UseVisualStyleBackColor = true;
            this.btnOpenLoginForm.Click += new System.EventHandler(this.btnOpenLoginForm_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(228, 270);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(309, 270);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(433, 315);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnOpenLoginForm);
            this.Controls.Add(this.btnOpenAdminForm);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn00);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRestart;
    }
}
