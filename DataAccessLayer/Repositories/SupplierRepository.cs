using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DbConnection;
using EntitiLayer.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace DataAccessLayer
{
    public class SupplierRepository
    {
        private readonly SqlDataAccess _dbConnection;
      public SupplierRepository() { 
        _dbConnection = new SqlDataAccess();
      }

        public void CreateSupplier(Proveedores proveedores)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Proveedores (Nombre, Direccion, Telefono) 
                                 VALUES (@Nombre, @Direccion, @Telefono)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", proveedores.Nombre);
                command.Parameters.AddWithValue("@Direccion", proveedores.Direccion);
                command.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
               

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetSupplier()
        {
            DataTable suppliersTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT Id, Nombre, Direccion, Telefono FROM Proveedores";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                suppliersTable.Load(reader);
            }

            return suppliersTable;
        }

        public void UpdateSupplier(Proveedores proveedores)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Proveedores 
                                 SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono
                                 WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", proveedores.Nombre);
                command.Parameters.AddWithValue("@Direccion", proveedores.Direccion);
                command.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
                command.Parameters.AddWithValue("@Id", proveedores.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSupplier(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE FROM Proveedores WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
