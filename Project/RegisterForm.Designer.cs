
namespace Project_Stock
{
    partial class RegisterForm
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
            tbNewLogin = new System.Windows.Forms.TextBox();
            tbNewPass = new System.Windows.Forms.TextBox();
            lbRegister = new System.Windows.Forms.Label();
            btnRegistr = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tbFullName = new System.Windows.Forms.TextBox();
            tbName = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            lbExit = new System.Windows.Forms.Label();
            lbRegistr = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel1.Controls.Add(tbNewLogin);
            panel1.Controls.Add(tbNewPass);
            panel1.Controls.Add(lbRegister);
            panel1.Controls.Add(btnRegistr);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tbFullName);
            panel1.Controls.Add(tbName);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(475, 320);
            panel1.TabIndex = 1;
            // 
            // tbNewLogin
            // 
            tbNewLogin.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbNewLogin.Location = new System.Drawing.Point(80, 175);
            tbNewLogin.MaximumSize = new System.Drawing.Size(130, 40);
            tbNewLogin.MinimumSize = new System.Drawing.Size(130, 40);
            tbNewLogin.Name = "tbNewLogin";
            tbNewLogin.Size = new System.Drawing.Size(130, 40);
            tbNewLogin.TabIndex = 8;
            tbNewLogin.KeyPress += tbNewLogin_KeyPress;
            // 
            // tbNewPass
            // 
            tbNewPass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbNewPass.Location = new System.Drawing.Point(302, 175);
            tbNewPass.MaximumSize = new System.Drawing.Size(155, 40);
            tbNewPass.MinimumSize = new System.Drawing.Size(155, 40);
            tbNewPass.Name = "tbNewPass";
            tbNewPass.Size = new System.Drawing.Size(155, 40);
            tbNewPass.TabIndex = 7;
            tbNewPass.KeyPress += tbNewPass_KeyPress;
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            lbRegister.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lbRegister.Location = new System.Drawing.Point(166, 279);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new System.Drawing.Size(134, 17);
            lbRegister.TabIndex = 6;
            lbRegister.Text = "Авторизироваться";
            lbRegister.Click += lbRegister_Click;
            // 
            // btnRegistr
            // 
            btnRegistr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegistr.Location = new System.Drawing.Point(146, 238);
            btnRegistr.Name = "btnRegistr";
            btnRegistr.Size = new System.Drawing.Size(176, 40);
            btnRegistr.TabIndex = 5;
            btnRegistr.Text = "Зарегистрироваться";
            btnRegistr.UseVisualStyleBackColor = true;
            btnRegistr.Click += btnRegistr_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new System.Drawing.Point(226, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(70, 40);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new System.Drawing.Point(19, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(57, 40);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tbFullName
            // 
            tbFullName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbFullName.Location = new System.Drawing.Point(302, 129);
            tbFullName.MaximumSize = new System.Drawing.Size(155, 40);
            tbFullName.MinimumSize = new System.Drawing.Size(155, 40);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new System.Drawing.Size(155, 40);
            tbFullName.TabIndex = 2;
            tbFullName.KeyPress += tbFullName_KeyPress;
            // 
            // tbName
            // 
            tbName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbName.Location = new System.Drawing.Point(80, 129);
            tbName.MaximumSize = new System.Drawing.Size(130, 40);
            tbName.MinimumSize = new System.Drawing.Size(130, 40);
            tbName.Name = "tbName";
            tbName.Size = new System.Drawing.Size(130, 40);
            tbName.TabIndex = 1;
            tbName.KeyPress += tbName_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panel2.Controls.Add(lbExit);
            panel2.Controls.Add(lbRegistr);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(475, 89);
            panel2.TabIndex = 0;
            // 
            // lbExit
            // 
            lbExit.AutoSize = true;
            lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            lbExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbExit.Location = new System.Drawing.Point(445, 0);
            lbExit.Name = "lbExit";
            lbExit.Size = new System.Drawing.Size(24, 28);
            lbExit.TabIndex = 1;
            lbExit.Text = "X";
            lbExit.Click += lbExit_Click;
            // 
            // lbRegistr
            // 
            lbRegistr.AutoSize = true;
            lbRegistr.Font = new System.Drawing.Font("Sitka Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbRegistr.ForeColor = System.Drawing.Color.White;
            lbRegistr.Location = new System.Drawing.Point(154, 40);
            lbRegistr.Name = "lbRegistr";
            lbRegistr.Size = new System.Drawing.Size(175, 35);
            lbRegistr.TabIndex = 0;
            lbRegistr.Text = "Регистрация";
            lbRegistr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(475, 320);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RegisterForm";
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
        private System.Windows.Forms.TextBox tbNewLogin;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Button btnRegistr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label lbRegistr;
    }
}