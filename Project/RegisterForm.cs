using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_Stock
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            tbName.PlaceholderText = "Введите имя";
            tbFullName.PlaceholderText = "Введите фамилию";
            tbNewLogin.PlaceholderText = "Введите логин";
            tbNewPass.PlaceholderText = "Введите пароль";

            /*Placeholder -  используется внутри текстового поля,
            который описывает, какую информацию следует ввести в поле, имеет серый цвет текста.
            Он исчезает, когда пользователь начинает писать в поле. 

            Метод GotFocus проверяет, если текст в textBox является текстом-пометкой (placeholder text) серого цвета, 
            то он удаляет этот текст и меняет цвет текста на черный с серого.

            Метод LostFocus проверяет, если в textBox нет введенного пользователем текста, 
            то он вставляет в текстовое поле некоторый текст-пометку (placeholder text) серого цвета. 
            Это делается для того, чтобы подсказать пользователю, что можно ввести в это текстовое поле.
            */
            tbName.GotFocus += (sender, e) =>
            {
                if (tbName.ForeColor == Color.Gray) // если в текстбоксе текст placeholdertext, то убираем его
                {
                    tbName.Text = "";
                    tbName.ForeColor = Color.Black; // цвет текста введенного пользователем
                }
            };

            tbName.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(tbName.Text)) // если текстбокс пустой, то возвращаем placeholdertext
                {
                    tbName.ForeColor = Color.Gray; // цвет текста placeholdertext
                }
            };

            tbFullName.GotFocus += (sender, e) =>
            {
                if (tbFullName.ForeColor == Color.Gray)
                {
                    tbFullName.Text = "";
                    tbFullName.ForeColor = Color.Black;
                }
            };

            tbFullName.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(tbFullName.Text))
                {
                    tbFullName.ForeColor = Color.Gray;
                }
            };

            tbNewLogin.GotFocus += (sender, e) =>
            {
                if (tbNewLogin.ForeColor == Color.Gray)
                {
                    tbNewLogin.Text = "";
                    tbNewLogin.ForeColor = Color.Black;
                }
            };

            tbNewLogin.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(tbNewLogin.Text))
                {
                    tbNewLogin.ForeColor = Color.Gray;
                }
            };

            tbNewPass.GotFocus += (sender, e) =>
            {
                if (tbNewPass.ForeColor == Color.Gray)
                {
                    tbNewPass.Text = "";
                    tbNewPass.ForeColor = Color.Black;
                }
            };

            tbNewPass.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(tbNewPass.Text))
                {
                    tbNewPass.ForeColor = Color.Gray;
                }
            };
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" && tbFullName.Text == ""
            && tbNewLogin.Text == "" && tbNewPass.Text == "")
                MessageBox.Show("Error. Enter data in all fields!");
            else if (tbName.Text == "")
                MessageBox.Show("Error. Enter Name");
            else if (tbFullName.Text == "")
                MessageBox.Show("Error. Enter FullName");
            else if (tbNewLogin.Text == "")
                MessageBox.Show("Error. Enter login");
            else if (tbNewPass.Text == "")
                MessageBox.Show("Error. Enter password");
            else
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') // ограничивает ввод пробелов в текстовом поле
                e.Handled = true;
        }

        private void tbNewLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tbFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tbNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }


    }
}


