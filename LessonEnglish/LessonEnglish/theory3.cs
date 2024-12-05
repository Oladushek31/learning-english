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
    public partial class theory3 : Form
    {
        public theory3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            choiceTheory choiceTheory = new choiceTheory();
            choiceTheory.Show();
            this.Hide();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            test3 test3 = new test3();
            test3.Show();
            this.Hide();
        }

        private void theory3_Load(object sender, EventArgs e)
        {

        }
    }
}
