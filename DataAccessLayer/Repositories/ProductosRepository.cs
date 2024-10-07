using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProductosRepository
    {
        private SqlDataAccess _dbConnection;

        public ProductosRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetProducts()
        {
            DataTable productsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    p.Nombre AS Producto,  
                                    p.Precio,  
                                    p.Stock,  
                                    c.Nombre AS Categoria, 
                                    pr.Nombre AS Proveedor
                                FROM Productos p  
                                JOIN Categorias c ON p.IdCategoria = c.Id 
                                JOIN Proveedores pr ON p.IdProveedor = pr.Id";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                productsTable.Load(reader);
            }

            return productsTable;
        }
    }
}
