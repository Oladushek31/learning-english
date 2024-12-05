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
    public partial class theory5 : Form
    {
        public theory5()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            theory5 theory5 = new theory5();
            theory5.Show();
            this.Hide();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            test5 test5 = new test5();
            test5.Show();
            this.Hide();
        }

        private void theory5_Load(object sender, EventArgs e)
        {

        }
    }
}
