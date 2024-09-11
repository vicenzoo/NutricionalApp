using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string CheckUserAdm(string email, string pass)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT CheckUserAdm(@Email, @Pass);", db.GetConnection()))
                {
                    // Adicione os parâmetros para a função
                    comm.Parameters.AddWithValue("@Email", email);
                    comm.Parameters.AddWithValue("@Pass", pass);

                    try
                    {
                        var result = comm.ExecuteScalar();
                        return result.ToString(); // O resultado será 'true' ou 'false'
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao chamar a função: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public string CheckNutricionista(string email, string pass)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT CheckNutricionista(@Email, @Pass);", db.GetConnection()))
                {
                    // Adicione os parâmetros para a função
                    comm.Parameters.AddWithValue("@Email", email);
                    comm.Parameters.AddWithValue("@Pass", pass);

                    try
                    {
                        var result = comm.ExecuteScalar();
                        return result.ToString(); // O resultado será 'true' ou 'false'
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao chamar a função: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public string CheckEmailNutricionista(string email)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT verificar_email_cadastrado_nutricionista(@Email);", db.GetConnection()))
                {
                    // Adicione os parâmetros para a função
                    comm.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        var result = comm.ExecuteScalar();
                        return result.ToString(); // O resultado será 'true' ou 'false'
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao chamar a função: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public string CheckCadastroNutri(string id)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT verificar_cadastro_nutricionista(@id);", db.GetConnection()))
                {
                    // Adicione os parâmetros para a função
                    comm.Parameters.AddWithValue("@id", id);

                    try
                    {
                        var result = comm.ExecuteScalar();
                        return result.ToString(); // O resultado será 'true' ou 'false'
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao chamar a função: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public class Paciente
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            public Paciente(int id, string nome)
            {
                Id = id;
                Nome = nome;
            }

            // Sobrescreva o método ToString para que o ComboBox exiba o nome do paciente
            public override string ToString()
            {
                return Nome;
            }
        }

        public void GetPacientes(int Id_Nutricionista, ComboBox comboBox)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id_paciente,  nome ||' ' || sobrenome as NomeCompleto  FROM public.paciente where nutricionista_id = @idNutri", db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@idNutri", Id_Nutricionista);

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idPaciente = Convert.ToInt32(reader["id_paciente"]);
                                string nomePaciente = reader["NomeCompleto"].ToString();

                                comboBox.Items.Add(new Paciente(idPaciente, nomePaciente));
                            }

                            // Verifica se encontrou pacientes
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum paciente encontrado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter os pacientes: {ex.Message}");
                    }
                }
            }
        }

        public class Perfil
        {
            public Image Imagem { get; set; }
            public string Nome { get; set; }
            public int Id { get; set; }
        }

        public Perfil RetornaPerfil(string email)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();

                using (var comm = new NpgsqlCommand("SELECT \"Nut_icon\", \"Nome\", \"id_nutricionista\" FROM nutricionista WHERE \"Email\" = @Email;", db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var perfil = new Perfil
                                {
                                    Nome = reader["Nome"].ToString(),
                                    Id = Convert.ToInt32(reader["id_nutricionista"])
                                };

                                var result = reader["Nut_icon"];
                                if (result != DBNull.Value && result is byte[])
                                {
                                    var imageBytes = (byte[])result;
                                    using (var ms = new MemoryStream(imageBytes))
                                    {
                                        perfil.Imagem = Image.FromStream(ms);
                                    }
                                }

                                return perfil;
                            }
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter o perfil: {ex.Message}");
                        return null;
                    }
                }
            }
        }


    }
}
