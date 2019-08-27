
namespace ApiWebZabud.Core.Repositories.ClientRepository
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


    public class ClientRepository : IClientRepository
    {

        
     

        public async Task<Client> GetByIdClient(long id)
        {
            var getConn = BaseRepository.GetConnection();
            using (var conn = new SqlConnection(getConn))
            {
                using (var cmd = new SqlCommand("ST_SELETBYIDCLIENT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", id));
                    await conn.OpenAsync();
                    var client = new Client();
                    var reader = await cmd.ExecuteReaderAsync();
                    while(await reader.ReadAsync())
                    {
                        client.Id = (long)reader["Id"];
                        client.Name = reader["Name"].ToString();
                        client.LastName = reader["LastName"].ToString();
                        client.Address = reader["Address"].ToString();
                        client.Cellphone = reader["Cellphone"].ToString();
                        client.Identification = reader["Identification"].ToString();
                        client.Nit = reader["Nit"].ToString();

                    }
                    reader.Close();
                     conn.Close();
                    return client;
                }

            }
        }

        public async Task<List<Client>> GetClientsAll()
        {

            var getConn = BaseRepository.GetConnection();
            using (var conn = new SqlConnection(getConn))
            {
                using (var cmd = new SqlCommand("ST_SELETCLIENT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await conn.OpenAsync();
                    var listclient = new List<Client>();
                    var client = new Client();
                    var reader = await cmd.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            client.Id = (long)reader["Id"];
                            client.Name = reader["Name"].ToString();
                            client.LastName = reader["LastName"].ToString();
                            client.Address = reader["Address"].ToString();
                            client.Cellphone = reader["Cellphone"].ToString();
                            client.Identification = reader["Identification"].ToString();
                            client.Nit = reader["Nit"].ToString();
                        }
                        listclient.Add(client);
                        await reader.NextResultAsync();
                    }
                    reader.Close();
                    conn.Close();
                    return listclient;
                }

            }
        }

 

        public async Task<Client> UpdateClient(Client client)
        {
            var getConn = BaseRepository.GetConnection();
            using (var conn = new SqlConnection(getConn))
            {
                using (var cmd = new SqlCommand("ST_UPDATECLIENT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", client.Id));
                    cmd.Parameters.Add(new SqlParameter("@Name", client.Name));
                    cmd.Parameters.Add(new SqlParameter("@LastName", client.LastName));
                    cmd.Parameters.Add(new SqlParameter("@Address", client.Address));
                    cmd.Parameters.Add(new SqlParameter("@Telephone", client.Telephone));
                    cmd.Parameters.Add(new SqlParameter("@Cellphone", client.Cellphone));
                    cmd.Parameters.Add(new SqlParameter("@Identification", client.Identification));
                    cmd.Parameters.Add(new SqlParameter("@Nit", client.Nit));
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();

                    conn.Close();
                    return client;
                }

            }
        }

        public async Task<Client> SaveClient(Client client)
        {
            var getConn = BaseRepository.GetConnection();
                using (var conn = new SqlConnection(getConn))
                {
                    using (var cmd = new SqlCommand("ST_SAVECLIENT", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@Name", client.Name));
                        cmd.Parameters.Add(new SqlParameter("@LastName", client.LastName));
                        cmd.Parameters.Add(new SqlParameter("@Address", client.Address));
                        cmd.Parameters.Add(new SqlParameter("@Telephone", client.Telephone));
                        cmd.Parameters.Add(new SqlParameter("@Cellphone", client.Cellphone));
                        cmd.Parameters.Add(new SqlParameter("@Identification", client.Identification));
                        cmd.Parameters.Add(new SqlParameter("@Nit", client.Nit));
                        await  conn.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                       
                    conn.Close();
                        return client;
                    }
                  
                }
           
        }

    }
}
