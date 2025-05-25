using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsTourism
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password= ;database=TourismDB;";
        private MySqlConnection conn;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            btnLoad.Click += new EventHandler(LoadTours);
            btnDelete.Click += new EventHandler(DeleteTour);
            btnAdd.Click += new EventHandler(AddTourist);
            btnUpdate.Click += new EventHandler(UpdateTourist);
        }

        private void LoadTours(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                string query = "SELECT * FROM Tours";
                dataAdapter = new MySqlDataAdapter(query, conn);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки туров: {ex.Message}");
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        private void DeleteTour(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0) return;

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string query = $"DELETE FROM Tours WHERE ID={id}";
                ExecuteQuery(query);
                LoadTours(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления тура: {ex.Message}");
            }
        }

        private void AddTourist(object sender, EventArgs e)
        {
            string query = "INSERT INTO Tourists (FullName, Phone, Email) VALUES (@FullName, @Phone, @Email)";
            ExecuteQuery(query);
            LoadTours(sender, e);
        }

        private void UpdateTourist(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            string query = $"UPDATE Tourists SET FullName=@FullName, Phone=@Phone, Email=@Email WHERE ID={id}";
            ExecuteQuery(query);
            LoadTours(sender, e);
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (query.Contains("Tourists"))
                {
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }
    }
}
