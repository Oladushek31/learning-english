using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonEnglish
{
    public partial class MainPage : Form
    {
        public string currentUserLogin { get; set; }
        public MainPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void theory_Click(object sender, EventArgs e)
        {
            choiceTheory choiceTheory = new choiceTheory();
            choiceTheory.Show();
            this.Hide();
        }

        private void Practice_Click(object sender, EventArgs e)
        {
            choicePractice choicePractice = new choicePractice();
            choicePractice.currentUserLogin = currentUserLogin;
            choicePractice.Show();
            this.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics();
            statistics.Show();
            this.Hide();
        }
    }
}
