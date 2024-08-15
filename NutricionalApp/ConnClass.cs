using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutricionalApp
{
    public class DatabaseConnection : IDisposable
    {
        private NpgsqlConnection _connection;

        // Construtor que inicializa a conexão usando variáveis de ambiente ou valores padrão
        public DatabaseConnection()
        {
            string host = Environment.GetEnvironmentVariable("DB_HOST") ?? "localhost";
            string port = Environment.GetEnvironmentVariable("DB_PORT") ?? "5432";
            string userId = Environment.GetEnvironmentVariable("DB_USER") ?? "postgres";
            string password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "adm";
            string database = Environment.GetEnvironmentVariable("DB_NAME") ?? "postgres";

            // Conexão SSL para o Banco
            var connectionString = $"Server={host};Port={port};User Id={userId};Password={password};Database={database};SslMode=Prefer;";
            _connection = new NpgsqlConnection(connectionString);
        }

        // Método para abrir a conexão
        public void OpenConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                    Console.WriteLine("Conexão com o banco de dados aberta com sucesso.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao abrir a conexão: {ex.Message}");
            }
        }

        // Método para fechar a conexão
        public void CloseConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                {
                    _connection.Close();
                    Console.WriteLine("Conexão com o banco de dados fechada com sucesso.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fechar a conexão: {ex.Message}");
            }
        }

        // Método para obter a conexão (útil se você precisar da conexão em outros lugares)
        public NpgsqlConnection GetConnection()
        {
            return _connection;
        }

        // Implementação da interface IDisposable para liberar recursos
        public void Dispose()
        {
            CloseConnection();
            _connection.Dispose();
        }
    }
}
