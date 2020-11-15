using Projeto03.Entity;
using Projeto03.Input;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Repository
{
    public class EnderecoRepository
    {
        private string connectionString;

        public EnderecoRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["banco"].ConnectionString;
        }

        public void InsertEnd(Endereco obj)
        {
            string query = "insert into Endereco(Logradouro, Bairro, Cidade, Estado, Cep, IdCliente) "
                         + "values(@Logradouro, @Bairro, @Cidade, @Estado, @Cep, @IdCliente);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Logradouro", obj.Logradouro);
                command.Parameters.AddWithValue("@Bairro", obj.Bairro);
                command.Parameters.AddWithValue("@Estado", obj.Estado);
                command.Parameters.AddWithValue("@Cidade", obj.Cidade);
                command.Parameters.AddWithValue("@Cep", obj.Cep);
                command.Parameters.AddWithValue("@IdCliente", obj.IdCliente);
                command.ExecuteNonQuery();
            }

        }

        public void Update(Endereco obj)
        {
            string query = "update Endereco set Logradouro = @Logradouro, "
                + "Bairro = @Bairro, Cidade = @Cidade, Estado = @Estado, "
                + "Cep = @Cep, IdCliente = @IdCliente where IdEndereco = @IdEndereco";

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Logradouro", obj.Logradouro);
                command.Parameters.AddWithValue("@Bairro", obj.Bairro);
                command.Parameters.AddWithValue("@Cidade", obj.Cidade);
                command.Parameters.AddWithValue("@Estado", obj.Estado);
                command.Parameters.AddWithValue("@Cep", obj.Cep);
                command.Parameters.AddWithValue("IdCliente", obj.IdCliente);
                command.Parameters.AddWithValue("@IdEndereco", obj.IdEndereco);
                command.ExecuteNonQuery();
            }
        }

        public Endereco Load(Endereco obj)
        {
            string query = "SELECT Logradouro, Bairro, Cidade, Estado, Cep, IdCliente, IdEndereco from Endereco" +
                           "WHERE IdEndereco = " + obj.IdEndereco;

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            obj.Logradouro = reader.GetString(reader.GetOrdinal("Logradouro"));
                            obj.Bairro = reader.GetString(reader.GetOrdinal("Bairro"));
                            obj.Cidade = reader.GetString(reader.GetOrdinal("Cidade"));
                            obj.Estado = reader.GetString(reader.GetOrdinal("Estado"));
                            obj.Cep = reader.GetString(reader.GetOrdinal("Cep"));
                            obj.IdCliente = reader.GetOrdinal("IdCliente");
                            obj.IdEndereco = reader.GetOrdinal("IdEndereco");

                        }
                    }
                    return obj;
                }
                
            }
        }


    }
}
