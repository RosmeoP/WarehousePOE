using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class ProductRepo
    {
        private string _connectionString;

        public ProductRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        //CREAR UN PRODUCTO

        public void CrearProducto(Productos producto, ConexionDB ConexionDB)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                string query = "INSERT INTO Productos (Nombre, Precio, Stock, Id_Categoria, Id_Proveedor) VALUES (@Nombre, @Precio, @Stock, @Id_Categoria, @Id_Proveedor)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                command.Parameters.AddWithValue("@Id_Categoria", producto.Id_Categoria);
                command.Parameters.AddWithValue("@", producto.Id_Proveedor);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al crear el producto: " + ex.Message);
                }
            }
        }
    }
}
