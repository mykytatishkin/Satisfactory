
namespace Project_Stock
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            lbSearch = new System.Windows.Forms.Label();
            panelSearch = new System.Windows.Forms.Panel();
            tbSearch = new System.Windows.Forms.TextBox();
            lbNameSearch = new System.Windows.Forms.Label();
            lbProduct = new System.Windows.Forms.Label();
            lbAdd = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            dgv = new System.Windows.Forms.DataGridView();
            panel3 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            lbUAH = new System.Windows.Forms.Label();
            tbPrice = new System.Windows.Forms.TextBox();
            dNumeric = new System.Windows.Forms.NumericUpDown();
            lbPrice = new System.Windows.Forms.Label();
            lbAmount = new System.Windows.Forms.Label();
            rtbDescription = new System.Windows.Forms.RichTextBox();
            lbDescription = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            lbNewProductName = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panelSearch.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dNumeric).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gainsboro;
            panel1.Controls.Add(lbSearch);
            panel1.Controls.Add(panelSearch);
            panel1.Controls.Add(lbProduct);
            panel1.Controls.Add(lbAdd);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(864, 381);
            panel1.TabIndex = 0;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbSearch.Location = new System.Drawing.Point(511, 263);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(39, 14);
            lbSearch.TabIndex = 4;
            lbSearch.Text = "Поиск";
            // 
            // panelSearch
            // 
            panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSearch.Controls.Add(tbSearch);
            panelSearch.Controls.Add(lbNameSearch);
            panelSearch.Location = new System.Drawing.Point(497, 268);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new System.Drawing.Size(346, 91);
            panelSearch.TabIndex = 3;
            // 
            // tbSearch
            // 
            tbSearch.Location = new System.Drawing.Point(173, 34);
            tbSearch.MaximumSize = new System.Drawing.Size(125, 21);
            tbSearch.MinimumSize = new System.Drawing.Size(125, 21);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new System.Drawing.Size(125, 21);
            tbSearch.TabIndex = 11;
            // 
            // lbNameSearch
            // 
            lbNameSearch.AutoSize = true;
            lbNameSearch.Location = new System.Drawing.Point(11, 37);
            lbNameSearch.Name = "lbNameSearch";
            lbNameSearch.Size = new System.Drawing.Size(156, 15);
            lbNameSearch.TabIndex = 11;
            lbNameSearch.Text = "Поиск товара по названию";
            // 
            // lbProduct
            // 
            lbProduct.AutoSize = true;
            lbProduct.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbProduct.Location = new System.Drawing.Point(26, 9);
            lbProduct.Name = "lbProduct";
            lbProduct.Size = new System.Drawing.Size(52, 17);
            lbProduct.TabIndex = 1;
            lbProduct.Text = "Товары";
            // 
            // lbAdd
            // 
            lbAdd.AutoSize = true;
            lbAdd.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAdd.Location = new System.Drawing.Point(509, 10);
            lbAdd.Name = "lbAdd";
            lbAdd.Size = new System.Drawing.Size(58, 14);
            lbAdd.TabIndex = 0;
            lbAdd.Text = "Добавить";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(dgv);
            panel2.Location = new System.Drawing.Point(12, 17);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(420, 314);
            panel2.TabIndex = 1;
            panel2.Tag = "";
            // 
            // dgv
            // 
            dgv.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new System.Drawing.Point(14, 25);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new System.Drawing.Size(388, 268);
            dgv.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(lbUAH);
            panel3.Controls.Add(tbPrice);
            panel3.Controls.Add(dNumeric);
            panel3.Controls.Add(lbPrice);
            panel3.Controls.Add(lbAmount);
            panel3.Controls.Add(rtbDescription);
            panel3.Controls.Add(lbDescription);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(lbNewProductName);
            panel3.Location = new System.Drawing.Point(497, 15);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(346, 233);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Silver;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(239, 193);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(98, 24);
            button2.TabIndex = 13;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Silver;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(11, 194);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(98, 24);
            button1.TabIndex = 12;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.Silver;
            btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(125, 193);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(98, 24);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // lbUAH
            // 
            lbUAH.AutoSize = true;
            lbUAH.BackColor = System.Drawing.Color.White;
            lbUAH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbUAH.Location = new System.Drawing.Point(223, 62);
            lbUAH.MaximumSize = new System.Drawing.Size(35, 17);
            lbUAH.MinimumSize = new System.Drawing.Size(35, 17);
            lbUAH.Name = "lbUAH";
            lbUAH.Size = new System.Drawing.Size(35, 17);
            lbUAH.TabIndex = 3;
            lbUAH.Text = "UAH";
            lbUAH.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbPrice
            // 
            tbPrice.Location = new System.Drawing.Point(145, 59);
            tbPrice.MaximumSize = new System.Drawing.Size(114, 21);
            tbPrice.MaxLength = 12;
            tbPrice.MinimumSize = new System.Drawing.Size(114, 21);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new System.Drawing.Size(114, 21);
            tbPrice.TabIndex = 7;
            // 
            // dNumeric
            // 
            dNumeric.Location = new System.Drawing.Point(144, 150);
            dNumeric.Name = "dNumeric";
            dNumeric.Size = new System.Drawing.Size(114, 23);
            dNumeric.TabIndex = 10;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(12, 63);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(107, 15);
            lbPrice.TabIndex = 6;
            lbPrice.Text = "Стоимость товара";
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Location = new System.Drawing.Point(13, 153);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new System.Drawing.Size(112, 15);
            lbAmount.TabIndex = 9;
            lbAmount.Text = "Количество товара";
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            rtbDescription.Location = new System.Drawing.Point(144, 89);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new System.Drawing.Size(181, 50);
            rtbDescription.TabIndex = 5;
            rtbDescription.Text = "";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new System.Drawing.Point(13, 99);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(102, 15);
            lbDescription.TabIndex = 3;
            lbDescription.Text = "Описание товара";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(144, 28);
            textBox1.MaximumSize = new System.Drawing.Size(114, 21);
            textBox1.MinimumSize = new System.Drawing.Size(114, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(114, 21);
            textBox1.TabIndex = 2;
            // 
            // lbNewProductName
            // 
            lbNewProductName.AutoSize = true;
            lbNewProductName.Location = new System.Drawing.Point(11, 29);
            lbNewProductName.Name = "lbNewProductName";
            lbNewProductName.Size = new System.Drawing.Size(126, 15);
            lbNewProductName.TabIndex = 1;
            lbNewProductName.Text = "Новое наименование";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(864, 381);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Главная форма";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNewProductName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.NumericUpDown dNumeric;
        private System.Windows.Forms.Label lbUAH;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbNameSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

