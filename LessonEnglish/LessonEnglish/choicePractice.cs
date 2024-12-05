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
    public partial class choicePractice : Form
    {
        public string currentUserLogin { get; set; }

        public choicePractice()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void theoryButton1_Click(object sender, EventArgs e)
        {
            test1 test1 = new test1();
            test1.currentUserLogin = currentUserLogin;
            test1.Show();
            this.Hide();
        }

        private void theoryButton2_Click(object sender, EventArgs e)
        {
            test2 test2 = new test2();
            test2.currentUserLogin = currentUserLogin;
            test2.Show();
            this.Hide();
        }

        private void theoryButton3_Click(object sender, EventArgs e)
        {
            test3 test3 = new test3();
            test3.currentUserLogin = currentUserLogin;
            test3.Show();
            this.Hide();
        }

        private void theoryButton4_Click(object sender, EventArgs e)
        {
            test4 test4 = new test4();
            test4.currentUserLogin = currentUserLogin;
            test4.Show();
            this.Hide();
        }

        private void theoryButton5_Click(object sender, EventArgs e)
        {
            test5 test5 = new test5();
            test5.currentUserLogin = currentUserLogin;
            test5.Show();
            this.Hide();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
        }
    }
}
