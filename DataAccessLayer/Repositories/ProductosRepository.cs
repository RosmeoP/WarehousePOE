﻿using DataAccessLayer.DbConnection;
using EntitiLayer.Entities;
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

        public void AddProduct(Productos producto)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Productos (Nombre, Precio, Stock, IdCategoria, IdProveedor) 
                                 VALUES (@Nombre, @Precio, @Stock, @IdCategoria, @IdProveedor)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                command.Parameters.AddWithValue("@IdCategoria", producto.CategoriaId);
                command.Parameters.AddWithValue("@IdProveedor", producto.ProveedorId);

                connection.Open();
                command.ExecuteNonQuery();  
            }
        }

        public DataTable GetProducts()
        {
            DataTable productoTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    p.Id AS Id,
                                    p.Nombre AS Producto,  
                                    p.Precio,  
                                    p.Stock,  
                                    c.Nombre AS Categoria, 
                                    pr.Nombre AS Proveedor,
                                    c.Id AS CategoriaId,
                                    pr.Id AS ProveedorId
                                FROM Productos p  
                                JOIN Categorias c ON p.IdCategoria = c.Id 
                                JOIN Proveedores pr ON p.IdProveedor = pr.Id";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                productoTable.Load(reader);
            }

            return productoTable;
        }

        public void UpdateProduct(Productos producto)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Productos 
                                 SET Nombre = @Nombre, 
                                     Precio = @Precio, 
                                     Stock = @Stock, 
                                     IdCategoria = @IdCategoria, 
                                     IdProveedor = @IdProveedor
                                 WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.Parameters.AddWithValue("@Stock", producto.Stock);
                command.Parameters.AddWithValue("@IdCategoria", producto.CategoriaId);
                command.Parameters.AddWithValue("@IdProveedor", producto.ProveedorId);
                command.Parameters.AddWithValue("@Id", producto.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteProduct(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"DELETE FROM Productos WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
