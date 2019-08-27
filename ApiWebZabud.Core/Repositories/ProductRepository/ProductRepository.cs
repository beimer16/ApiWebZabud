

namespace ApiWebZabud.Core.Repositories.ProductRepository
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ApiWebZabud.Core.Models;


    using ApiWebZabud.Core.Repositories.BaseRepository;


    public class ProductRepository : IProductRepository
    {



        public async Task<Product> GetByIdProduct(long id)
        {
            var getConn = BaseRepository.GetConnection();
            using (var conn = new SqlConnection(getConn))
            {
                using (var cmd = new SqlCommand("ST_SELETPRODUCT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    await conn.OpenAsync();
                    var listproduct = new List<Product>();
                    var product = new Product();
                    var reader = await cmd.ExecuteReaderAsync();
                    while (await reader.ReadAsync())
                        {
                            product.Id = (long)reader["Id"];
                            product.Name = reader["Name"].ToString();
                            product.Price = (decimal)reader["Price"];
                            product.Iva = (int)reader["Iva"];
                            product.IvaValue = (decimal)reader["IvaValue"];

                        }
                                
                    reader.Close();
                    conn.Close();
                    return product;

                }

            }


          
        }

        public async Task<List<Product>> GetProductsAll()
        {
            var getConn = BaseRepository.GetConnection();
            using (var conn = new SqlConnection(getConn))
            {
                using (var cmd = new SqlCommand("ST_SELECTPRODUCT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await conn.OpenAsync();
                    var listproduct = new List<Product>();
                    var product = new Product();
                    var reader = await cmd.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            product.Id = (long)reader["Id"];
                            product.Name = reader["Name"].ToString();
                            product.Price =(decimal) reader["Price"];
                            product.Iva =(int) reader["Iva"];
                            product.IvaValue =(decimal) reader["IvaValue"];
                     
                        }
                        listproduct.Add(product);
                        await reader.NextResultAsync();
                    }
                    reader.Close();
                    conn.Close();
                    return listproduct;
                }

            }
        }

        public async Task<Product> SaveProduct(Product product)
        {
            var getConn = BaseRepository.GetConnection();
            using (var conn = new SqlConnection(getConn))
            {
                using (var cmd = new SqlCommand("ST_SAVEPRODUCT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", product.Name));
                    cmd.Parameters.Add(new SqlParameter("@Price", product.Price));
                    cmd.Parameters.Add(new SqlParameter("@Iva", product.Iva));
                    cmd.Parameters.Add(new SqlParameter("@IvaValue", product.IvaValue));
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                    conn.Close();
                    return product;
                }

            }
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var getConn = BaseRepository.GetConnection();
            using (var conn = new SqlConnection(getConn))
            {
                using (var cmd = new SqlCommand("ST_UPDATEPRODUCT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", product.Id));
                    cmd.Parameters.Add(new SqlParameter("@Name", product.Name));
                    cmd.Parameters.Add(new SqlParameter("@Price", product.Price));
                    cmd.Parameters.Add(new SqlParameter("@Iva", product.Iva));
                    cmd.Parameters.Add(new SqlParameter("@IvaValue", product.IvaValue));
               
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                    conn.Close();
                    return product;
                }

            }
        }
    }
}
