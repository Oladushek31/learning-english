using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LessonEnglish
{
    public partial class Statistics : Form
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-P3UN1B9\\SQLEXPRESS09; Initial Catalog=LessonEnglishBD; Integrated Security=True;";

        public Statistics()
        {
            InitializeComponent();
        }

        private void StatisticsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM Result";

            using (connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                StatisticsDGV.DataSource = table;
            }
        }
    }
}
