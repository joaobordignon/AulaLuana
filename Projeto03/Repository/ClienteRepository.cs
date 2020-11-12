using Projeto03.Entity;
using System.Configuration;
using System.Data.SqlClient;
using System;


namespace Projeto03.Repository
{
    public class ClienteRepository
    {
        private string connectionString;

        public ClienteRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings
            ["banco"].ConnectionString;
        }

        public void Insert(Cliente obj)
        {
            string query = "insert into Cliente(Nome, DataNascimento, Email, Telefone) "
                         + "values(@Nome, @DataNascimento, @Email, @Telefone); SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", obj.Nome);
                command.Parameters.AddWithValue("@DataNascimento", obj.DataNascimento);
                command.Parameters.AddWithValue("@Email", obj.Email);
                command.Parameters.AddWithValue("@Telefone", obj.Telefone);
                obj.IdCliente = Convert.ToInt32(command.ExecuteScalar());

            }
        }
    }
}
