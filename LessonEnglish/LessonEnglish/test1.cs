using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonEnglish
{
    public partial class test1 : Form
    {
        int questionCount, correctCount, incorrctCount, correctNumber, selectOption;
        string[] listIncorrctQuestion;
        DataBase dataBase = new DataBase();
        public string currentUserLogin { get; set; }

        System.IO.StreamReader ReadFile;

        public test1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        void start()
        {
            var Encoding = System.Text.Encoding.GetEncoding(65001);

            try
            {
                ReadFile = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + @"\t1.txt", Encoding);

                this.Text = ReadFile.ReadLine();

                questionCount = 0;
                correctCount = 0;
                incorrctCount = 0;

                listIncorrctQuestion = new string[10];
            }
            catch (Exception) 
            {
                MessageBox.Show("Файл не был создан");
            }
            InitializationRadio();
        }

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            if (selectOption == correctNumber) correctCount++;
            else
            {
                incorrctCount++;
                listIncorrctQuestion[incorrctCount] = question.Text;
            }

            if (nextQuestion.Text == "Начать заново")
            {
                RadioButton1.Visible = true;
                RadioButton2.Visible = true;
                RadioButton3.Visible = true;
                start();
                return;
            }

            if (nextQuestion.Text == "Завершить")
            {
                ReadFile.Close();

                RadioButton1.Visible = false;
                RadioButton2.Visible = false;
                RadioButton3.Visible = false;

                question.Text = String.Format("Тестирование завершено.\n" + "Правильных ответов: {0} из {1}.\n" + "Набранные баллы: {2:F2}.", correctCount, questionCount, (correctCount * 5.0F) / questionCount);

                var Str = "Список ошибок " + ":\n\n";
                for (int i = 1; i <= incorrctCount; i++)
                    Str = Str + listIncorrctQuestion[i] + "\n";

                if (incorrctCount != 0) MessageBox.Show(Str, "Тестирование завершено");

                CalculateAndSaveResults();
            }
            if (nextQuestion.Text == "Следующий вопрос") InitializationRadio();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            choicePractice choicePractice = new choicePractice();
            choicePractice.Show();
            this.Hide();
        }

        private void question_Click(object sender, EventArgs e)
        {

        }

        private void question_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        void InitializationRadio()
        {
            question.Text = ReadFile.ReadLine();

            RadioButton1.Text = ReadFile.ReadLine();
            RadioButton2.Text = ReadFile.ReadLine();
            RadioButton3.Text = ReadFile.ReadLine();

            correctNumber = int.Parse(ReadFile.ReadLine());

            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;

            nextQuestion.Enabled = false;

            questionCount++;

            if (ReadFile.EndOfStream == true) nextQuestion.Text = "Завершить";
        }

        void ConditionRadio(object sender, EventArgs e)
        {
            nextQuestion.Enabled = true;
            nextQuestion.Focus();
            RadioButton Radio = (RadioButton)sender;
            var tmp = Radio.Name;
            selectOption = int.Parse(tmp.Substring(11));
        }

        private void test1_Load(object sender, EventArgs e)
        {
            RadioButton1.CheckedChanged += new EventHandler(ConditionRadio);
            RadioButton2.CheckedChanged += new EventHandler(ConditionRadio);
            RadioButton3.CheckedChanged += new EventHandler(ConditionRadio);
            start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int GetCorrectCount()
        {
            return correctCount;
        }

        private void CalculateAndSaveResults()
        {
            try
            {
                string queryString = "UPDATE Result SET result_test_1 = @UserResult " +
                                     "WHERE login_user = @UserLogin";

                using (SqlConnection connection = dataBase.getConnection())
                {
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@UserResult", correctCount);
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
    }
}
