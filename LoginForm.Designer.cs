
namespace Project_Stock
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            lbRegister = new System.Windows.Forms.Label();
            btnLogin = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tbPass = new System.Windows.Forms.TextBox();
            tbLogin = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            lbExit = new System.Windows.Forms.Label();
            lbLogin = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel1.Controls.Add(lbRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbPass);
            panel1.Controls.Add(tbLogin);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(357, 335);
            panel1.TabIndex = 0;
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.BackColor = System.Drawing.SystemColors.ActiveBorder;
            lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            lbRegister.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lbRegister.Location = new System.Drawing.Point(118, 301);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new System.Drawing.Size(138, 15);
            lbRegister.TabIndex = 6;
            lbRegister.Text = "Создать пользователя";
            lbRegister.Click += lbRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogin.Location = new System.Drawing.Point(116, 257);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(145, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new System.Drawing.Point(66, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(77, 46);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new System.Drawing.Point(84, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(57, 40);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tbPass
            // 
            tbPass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbPass.Location = new System.Drawing.Point(147, 197);
            tbPass.MaximumSize = new System.Drawing.Size(130, 40);
            tbPass.MinimumSize = new System.Drawing.Size(130, 40);
            tbPass.Name = "tbPass";
            tbPass.Size = new System.Drawing.Size(130, 40);
            tbPass.TabIndex = 2;
            tbPass.KeyPress += tbPass_KeyPress;
            // 
            // tbLogin
            // 
            tbLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbLogin.Location = new System.Drawing.Point(147, 130);
            tbLogin.MaximumSize = new System.Drawing.Size(130, 40);
            tbLogin.MinimumSize = new System.Drawing.Size(130, 40);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new System.Drawing.Size(130, 40);
            tbLogin.TabIndex = 1;
            tbLogin.KeyPress += tbLogin_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panel2.Controls.Add(lbExit);
            panel2.Controls.Add(lbLogin);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(357, 89);
            panel2.TabIndex = 0;
            // 
            // lbExit
            // 
            lbExit.AutoSize = true;
            lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            lbExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbExit.Location = new System.Drawing.Point(333, 0);
            lbExit.Name = "lbExit";
            lbExit.Size = new System.Drawing.Size(24, 28);
            lbExit.TabIndex = 1;
            lbExit.Text = "X";
            lbExit.Click += lbExit_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbLogin.ForeColor = System.Drawing.Color.White;
            lbLogin.Location = new System.Drawing.Point(105, 46);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(165, 32);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Авторизация";
            lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(357, 335);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbRegister;
    }
}