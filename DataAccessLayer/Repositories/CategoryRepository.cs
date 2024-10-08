using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DbConnection;
using EntitiLayer.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;


namespace DataAccessLayer.Repositories
{
    public class CategoryRepository
    {
        private readonly SqlDataAccess _dbConnection;
        public CategoryRepository() { 

            _dbConnection = new SqlDataAccess();
        
        }

        public void CreateCategory(Categorias categorias)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Categorias (Nombre) 
                                 VALUES (@Nombre)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", categorias.Nombre);
               

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetCategories()
        {

           DataTable categoriesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT Id, Nombre FROM Categorias";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                categoriesTable.Load(reader);
            }

            return categoriesTable;
        }

        public void UpdateCategory(Categorias categorias)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Categorias SET Nombre = @Nombre WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", categorias.Nombre);
                command.Parameters.AddWithValue("@Id", categorias.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteCategory(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE FROM Categorias WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
