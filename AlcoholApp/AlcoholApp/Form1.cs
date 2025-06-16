using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AlcoholApp
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=127.0.0.1;user=root;password=0000;database=alcohol_database;";

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string filter = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM alcohol";
                    if (!string.IsNullOrEmpty(filter))
                    {
                        sql += " WHERE brand LIKE @filter OR type LIKE @filter";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        if (!string.IsNullOrEmpty(filter))
                            cmd.Parameters.AddWithValue("@filter", $"%{filter}%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні даних: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            LoadData(searchText);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Оберіть товар для замовлення");
                return;
            }

            string product = dataGridView1.CurrentRow.Cells["brand"].Value.ToString();

            MessageBox.Show($"Замовлено продукт: {product}");
            // Можеш сюди додати логіку для замовлення в БД
        }
    }
}
