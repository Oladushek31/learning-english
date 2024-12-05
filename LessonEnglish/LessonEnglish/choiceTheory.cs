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
    public partial class choiceTheory : Form
    {
        public choiceTheory()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void theoryButton1_Click(object sender, EventArgs e)
        {
            theory1 theory1 = new theory1();
            theory1.Show();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            theory2 theory2 = new theory2();
            theory2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            theory4 theory4 = new theory4();
            theory4.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void theoryButton3_Click(object sender, EventArgs e)
        {
            theory3 theory3 = new theory3();
            theory3.Show();
            this.Hide();
        }

        private void theoryButton5_Click(object sender, EventArgs e)
        {
            theory5 theory5 = new theory5();
            theory5.Show();
            this.Hide();
        }

        private void choiceTheory_Load(object sender, EventArgs e)
        {

        }
    }
}
