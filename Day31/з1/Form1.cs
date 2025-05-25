using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsAirlineStaff
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password= ;database=AirlineStaffDB;";
        private MySqlConnection conn;
        private MySqlDataAdapter dataAdapter;
        private DataTable employeesTable;

        public Form1()
        {
            InitializeComponent();
            btnLoad.Click += new EventHandler(LoadData);
            btnAdd.Click += new EventHandler(AddEmployee);
            btnUpdate.Click += new EventHandler(UpdateEmployee);
            btnDelete.Click += new EventHandler(DeleteEmployee);
        }

        private void LoadData(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                string query = "SELECT * FROM Employees";
                dataAdapter = new MySqlDataAdapter(query, conn);
                employeesTable = new DataTable();
                dataAdapter.Fill(employeesTable);
                dataGridView1.DataSource = employeesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
            finally
            {
                if (conn != null) conn.Close();
            }
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employees (FirstName, LastName, Position, Salary, HireDate) VALUES (@FirstName, @LastName, @Position, @Salary, @HireDate)";
            ExecuteQuery(query);
            LoadData(sender, e);
        }

        private void UpdateEmployee(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            string query = $"UPDATE Employees SET FirstName=@FirstName, LastName=@LastName, Position=@Position, Salary=@Salary, HireDate=@HireDate WHERE ID={id}";
            ExecuteQuery(query);
            LoadData(sender, e);
        }

        private void DeleteEmployee(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            string query = $"DELETE FROM Employees WHERE ID={id}";
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
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Position", txtPosition.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                cmd.Parameters.AddWithValue("@HireDate", DateTime.Parse(txtHireDate.Text));
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
