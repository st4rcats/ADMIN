using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACT1A_CRUD
{
    public partial class Admin : Form
    {
        private MySqlConnection connection;
        public Admin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=bermudo;username=root;password=;");
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            loaddata();

        }
        private void loaddata()
        {
            try
            {
                connection.Open();
                string showallrecordquery = "SELECT ID, username, name, role FROM users ORDER BY ID ASC";
                MySqlCommand command = new MySqlCommand(showallrecordquery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( e.RowIndex == 0) 
            {
                DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
                txtID.Text= Row.Cells["ID"].Value.ToString();
                txtName.Text = Row.Cells["name"].Value.ToString();
                txtUsername.Text = Row.Cells["username"].Value.ToString();
                cbRole.Text = Row.Cells["role"].Value.ToString();
            }
        }
    }
}
