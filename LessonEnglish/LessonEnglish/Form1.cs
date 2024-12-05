using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LessonEnglish
{
    public partial class Form1 : Form
    {
        public int totalCorrectCount = 0;
        public string currentUserLogin;
        DataBase dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            closePasswordPictureBox.Visible = false;
            loginTextBox.MaxLength = 50;
            passwordTextBox.MaxLength = 50;
        }

        private void startLoginButton_Click(object sender, EventArgs e)
        {
            var loginUser = loginTextBox.Text;
            var passwordUser = passwordTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = "select user_login, user_password from UserData where user_login = @loginUser and user_password = @passwordUser";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            command.Parameters.AddWithValue("@loginUser", loginUser);
            command.Parameters.AddWithValue("@passwordUser", passwordUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вход выполнен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentUserLogin = loginUser;
                MainPage mp = new MainPage();
                mp.currentUserLogin = currentUserLogin;
                this.Hide();
                mp.ShowDialog();
            }
            else MessageBox.Show("Данного аккаунта не существует", "Аккаунт не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        private void recoveryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();    
        }

        private void closePasswordPictureBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = false;
            closePasswordPictureBox.Visible = false;
            openPasswordPictureBox.Visible = true;
        }

        private void openPasswordPictureBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            closePasswordPictureBox.Visible = true;
            openPasswordPictureBox.Visible = false;
        }

        private void CalculateAndSaveResults()
        {
            try
            {
                string queryString = "UPDATE Result SET user_result = @UserResult " +
                                     "WHERE user_login = @UserLogin";

                using (SqlConnection connection = dataBase.getConnection())
                {
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@UserResult", totalCorrectCount);
                        command.Parameters.AddWithValue("@UserLogin", currentUserLogin);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Результат успешно сохранен в базе данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось обновить результат в базе данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении результата в базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CalculateAndSaveResults();
        }

        private void logoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
