using System.Data.SqlClient;
using System.Data;

namespace targilSium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = FillTable();
        }
        static DataTable FillTable()
        {
            string connectionString = "Server=PINISHTERNIGOLD;Database=test;User Id=sa;Password=1234;";

            string queiry = " SELECT * FROM Mivchan";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(queiry, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new();
            adapter.Fill(dt);
            return dt;
        }
    }
}
