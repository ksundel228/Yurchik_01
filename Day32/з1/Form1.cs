using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsTravelAgency
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password= ;database=TravelAgencyDB;";
        private MySqlConnection conn;
        private MySqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
            btnLoad.Click += new EventHandler(LoadData);
            btnDelete.Click += new EventHandler(DeleteTour);
            btnAdd.Click += new EventHandler(AddTourist);
            btnUpdate.Click += new EventHandler(UpdateTourist);
        }

        private void LoadData(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                dataSet = new DataSet();

                string queryTours = "SELECT * FROM Tours";
                dataAdapter = new MySqlDataAdapter(queryTours, conn);
                dataAdapter.Fill(dataSet, "Tours");

                string queryTourists = "SELECT * FROM Tourists";
                dataAdapter = new MySqlDataAdapter(queryTourists, conn);
                dataAdapter.Fill(dataSet, "Tourists");

                string queryBookings = "SELECT * FROM Bookings";
                dataAdapter = new MySqlDataAdapter(queryBookings, conn);
                dataAdapter.Fill(dataSet, "Bookings");

                dataGridView1.DataSource = dataSet.Tables["Tours"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
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
                LoadData(sender, e);
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
            LoadData(sender, e);
        }

        private void UpdateTourist(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            string query = $"UPDATE Tourists SET FullName=@FullName, Phone=@Phone, Email=@Email WHERE ID={id}";
            ExecuteQuery(query);
            LoadData(sender, e);
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
