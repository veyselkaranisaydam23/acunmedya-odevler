using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProductAPI.Models;

namespace ProductAPI.Data
{
    public class ProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        // Tüm ürünleri getir
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Id, Name, Price, Stock FROM Products", connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"])
                        };
                        products.Add(product);
                    }
                }
            }

            return products;
        }

        // Belirli bir ürünü getir
        public Product GetProductById(int id)
        {
            Product product = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT Id, Name, Price, Stock FROM Products WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Stock = Convert.ToInt32(reader["Stock"])
                        };
                    }
                }
            }

            return product;
        }

        // Yeni ürün ekle
        public int AddProduct(Product product)
        {
            int newProductId = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(
                    "INSERT INTO Products (Name, Price, Stock) VALUES (@Name, @Price, @Stock); SELECT SCOPE_IDENTITY();",
                    connection);

                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);

                connection.Open();
                newProductId = Convert.ToInt32(command.ExecuteScalar());
            }

            return newProductId;
        }

        // Ürünü güncelle
        public bool UpdateProduct(int id, Product product)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Products SET Name = @Name, Price = @Price, Stock = @Stock WHERE Id = @Id",
                    connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }

        // Ürünü sil
        public bool DeleteProduct(int id)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Products WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected > 0;
        }
    }
}