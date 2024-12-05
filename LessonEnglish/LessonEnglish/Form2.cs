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
    public partial class Form2 : Form
    {
        DataBase database = new DataBase();

        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            loginTextBox.MaxLength = 50;
            passwordTextBox.MaxLength = 50;
        }

        private void startLoginButton_Click(object sender, EventArgs e)
        {
            var loginUs = loginTextBox.Text;
            var passwordUs = passwordTextBox.Text;

            string queryStr = $"insert into UserData(user_login, user_password) values('{loginUs}', ('{passwordUs}'))";

            SqlCommand command = new SqlCommand(queryStr, database.getConnection());

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаут успешно создан", "Аккаунт создан");
                Form1 Form1 = new Form1();
                this.Hide();
                Form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            database.closeConnection();
        }

        private Boolean checkUser()
        {
            var loginuser = loginTextBox.Text;
            var passworduser = passwordTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string querystring = $"select id, user_login, user_password from UserData where user_login = '{loginuser}' and password_user = '{passworduser}'";
            
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь усже существует");
                return true;
            }
            else
            {
                return false;
            }
;        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            closePasswordPictureBox.Visible = false;
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
