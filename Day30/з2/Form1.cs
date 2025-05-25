using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsTurFirm
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password= ;database=DBTur_firm;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowTours_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Тур";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите тур для удаления!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                string query = "DELETE FROM Тур WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Тур успешно удален!");
                btnShowTours_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAddTourist_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "INSERT INTO Клиент (ФИО, Телефон, Email) VALUES (@name, @phone, @email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Турист успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdateTourist_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string query = "UPDATE Клиент SET ФИО = @name, Телефон = @phone, Email = @email WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные туриста обновлены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
