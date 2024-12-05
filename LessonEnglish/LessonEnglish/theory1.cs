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
    public partial class theory1 : Form
    {
        public theory1()
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

        private void TestButton_Click(object sender, EventArgs e)
        {
            test1 test1 = new test1();
            test1.Show();
            this.Hide();
        }

        private void theory1_Load(object sender, EventArgs e)
        {

        }
    }
}
