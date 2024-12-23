using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SkladUI
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            this.connectionString = "Data Source=LAPTOP-5BDQ3HL0;Initial Catalog=Sklad;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            this.connection = new SqlConnection(connectionString);

            queryBox.Items.Add("Select * from products");
            queryBox.Items.Add("Select * from productTypes");
            queryBox.Items.Add("Select * from Suppliers");
            queryBox.Items.Add("SELECT * FROM Products WHERE Quantity = (SELECT MAX(quantity) FROM Products);");
            queryBox.Items.Add("SELECT * FROM Products WHERE Quantity = (SELECT MIN(quantity) FROM Products);");
            queryBox.Items.Add("SELECT * FROM Products WHERE Cost = (SELECT MIN(Cost) FROM Products);");
            queryBox.Items.Add("SELECT * FROM Products WHERE Cost = (SELECT MAX(Cost) FROM Products);");
            queryBox.Items.Add("SELECT P.Id AS ProductId,  P.ProductName,  P.Quantity,  P.Cost, P.SupplyDate FROM   Products P JOIN   Suppliers S ON P.SupplierId = S.Id WHERE S.SupplierName = @SupplierName;");
            queryBox.Items.Add("SELECT P.Id, P.ProductName, P.Quantity, P.Cost, P.SupplyDate FROM Products P JOIN ProductTypes PT ON P.ProductTypeId = PT.Id WHERE PT.TypeName = 'Электроника';");

        }

        private void Disconnection_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                    MessageBox.Show("Успешно отключено от базы данных \"Склад\"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка отключения: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Вы уже отключены от базы данных.");
            }
        }

        private void Connection_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MessageBox.Show("Успешно подключено к базе данных \"Склад\"");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Непредвиденная ошибка: {ex.Message}");
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            string sqlQuery = queryBox.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {


                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }


    }
}
