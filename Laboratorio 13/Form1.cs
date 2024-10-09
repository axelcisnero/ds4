using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);

            try
            {
                conexion.Open();
                MessageBox.Show("Conexión abierta con éxito.");

                // Consulta para obtener los nombres de los productos
                string query = "SELECT ProductName FROM [dbo].[Products]";

                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();

                // Limpia el ListBox antes de llenarlo
                productos_listbox.Items.Clear();

                // Llena el ListBox con los nombres de los productos
                while (reader.Read())
                {
                    productos_listbox.Items.Add(reader["ProductName"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("Conexión cerrada.");
                }
            }
        }
    }
}
