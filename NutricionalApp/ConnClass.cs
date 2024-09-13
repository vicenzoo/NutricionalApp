using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
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

        public class TacoCombo
        {
            public int Id { get; set; }
            public string Descricao { get; set; }

            public TacoCombo(int id, string descricao)
            {
                Id = id;
                Descricao = descricao;
            }

            // Sobrescreva o método ToString para que o ComboBox exiba a descrição da tabela TACO
            public override string ToString()
            {
                return Descricao;
            }
        }

        public void GetTacoCombo(ComboBox comboBox)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id, grupo, descricao, umidade, energia_kcal, energia_kj, proteina, lipideos, colesterol, fibra_alimentar, cinzas, calcio, magnesio, manganes, fosforo, ferro, sodio, potassio, cobre, zinco, retinol, re, rae, tiamina, riboflavina, piridoxina, niacina, vitamina_c, ativo, carboidrato FROM public.tabela_taco4;", db.GetConnection()))
                {

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idTaco = Convert.ToInt32(reader["id"]);
                                string descrição = reader["descricao"].ToString();

                                comboBox.Items.Add(new TacoCombo(idTaco, descrição));
                            }

                            // Verifica se encontrou Alimentos
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum alimento encontrado.");
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

        public class Recordatorio
        {
            public int Id { get; set; }
            public string RecordatorioDesc { get; set; }

            public Recordatorio(int id, string recordatorioDesc)
            {
                Id = id;
                RecordatorioDesc = recordatorioDesc;
            }

            // Sobrescreva o método ToString para que o ComboBox exiba a descrição da tabela TACO
            public override string ToString()
            {
                return RecordatorioDesc;
            }
        }

        public void GetRecordatorioCombobox(int Id_Paciente, ComboBox comboBox)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id_rec, paciente_id, nutricionista_id, ativo, descricao_nome FROM public.recordatorio_24h where paciente_id = @paciente_id", db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@paciente_id", Id_Paciente);

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idrec = Convert.ToInt32(reader["id_rec"]);
                                string descricaoRecordatorio = reader["descricao_nome"].ToString();

                                comboBox.Items.Add(new Recordatorio(idrec, descricaoRecordatorio));
                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum Recordatorio encontrado para esse Paciente.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter os Recordatorio: {ex.Message}");
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

        public void CarregarDados(string query, int filtro, DataGridView dataGridView)
        {
            try
            {
                using (var db = new DatabaseConnection())
                {
                    using (NpgsqlConnection connection = db.GetConnection())
                    {
                        connection.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                        {
                            // Passa o filtro como inteiro
                            command.Parameters.AddWithValue("@Filtro", filtro);

                            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                dataGridView.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum item encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
