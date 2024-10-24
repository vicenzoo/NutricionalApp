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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            public float Gramas { get; set; }

            /* Carboidrato Totais */

            public float Carboidrato { get; set; }

            /* Calorias Totais */

            public float Energia_kcal { get; set; }
            public float Proteinas { get; set; }

            /* Gorduras Totais */

            public float Lipidios { get; set; }

            /* Fibras Totais */

            public float FibraAlimentar { get; set; }

            /* Vitaminas Totais */

            public float Re { get; set; }
            public float Vitamina_C { get; set; }

            /* Minerais Totais */

            public float Calcio { get; set; }
            public float Ferro { get; set; }
            public float Magnesio { get; set; }


            public TacoCombo(int id, string descricao,float gramas,float carboidrato, float energia_kcal, float proteinas, float lipidios,float fibra_alimentar,float re, float vitamina_c,float calcio, float ferro, float magnesio)
            {
                Id = id;
                Descricao = descricao;
                Gramas = gramas;

                /* Carboidrato Totais */
                Carboidrato = carboidrato;

                /* Calorias Totais */
                Energia_kcal = energia_kcal;
                Proteinas = proteinas;

                /* Gorduras Totais */
                Lipidios = lipidios;

                /* Fibras Totais */
                FibraAlimentar = fibra_alimentar;

                /* Vitaminas Totais */
                Re = re;
                Vitamina_C = vitamina_c;

                /* Minerais Totais */
                Calcio = calcio;
                Ferro = ferro;
                Magnesio = magnesio;

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
                using (var comm = new NpgsqlCommand("SELECT id, grupo, descricao,grama, umidade, energia_kcal, energia_kj, proteina, lipideos, colesterol, fibra_alimentar, cinzas, calcio, magnesio, manganes, fosforo, ferro, sodio, potassio, cobre, zinco, retinol, re, rae, tiamina, riboflavina, piridoxina, niacina, vitamina_c, ativo, carboidrato FROM public.tabela_taco4;", db.GetConnection()))
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

                                float grama = reader["grama"] != DBNull.Value ? Convert.ToInt32(reader["grama"]) : 0;


                                /* Carboidrato Totais */
                                float carboidrato = reader["carboidrato"] != DBNull.Value ? Convert.ToInt32(reader["carboidrato"]) : 0;

                                /* Calorias Totais */
                                float energiaKcal = reader["energia_kcal"] != DBNull.Value ? Convert.ToInt32(reader["energia_kcal"]) : 0;
                                float proteinas = reader["proteina"] != DBNull.Value ? Convert.ToInt32(reader["proteina"]) : 0;

                                /* Gorduras Totais */
                                float lipidio = reader["lipideos"] != DBNull.Value ? Convert.ToInt32(reader["lipideos"]) : 0;

                                /* Fibras Totais */
                                float fibra = reader["fibra_alimentar"] != DBNull.Value ? Convert.ToInt32(reader["fibra_alimentar"]) : 0;

                                /* Vitaminas Totais */
                                float vitamina_a = reader["re"] != DBNull.Value ? Convert.ToInt32(reader["re"]) : 0;
                                float vitamina_c = reader["vitamina_c"] != DBNull.Value ? Convert.ToInt32(reader["vitamina_c"]) : 0;

                                /* Minerais Totais */
                                float calcio = reader["calcio"] != DBNull.Value ? Convert.ToInt32(reader["calcio"]) : 0;
                                float ferro = reader["ferro"] != DBNull.Value ? Convert.ToInt32(reader["ferro"]) : 0;
                                float magnesio = reader["magnesio"] != DBNull.Value ? Convert.ToInt32(reader["magnesio"]) : 0;


                                comboBox.Items.Add(new TacoCombo(
                                    idTaco, 
                                    descrição,
                                    grama,
                                    carboidrato,
                                    energiaKcal,
                                    proteinas,
                                    lipidio, 
                                    fibra, 
                                    vitamina_a, 
                                    vitamina_c,
                                    calcio,
                                    ferro,
                                    magnesio));
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
                        MessageBox.Show($"Erro ao obter os Taco: {ex.Message}");
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

        public void GetRecordatorioComboboxFiltroID(int id_Rec, ComboBox comboBox)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id_rec, paciente_id, nutricionista_id, ativo, descricao_nome FROM public.recordatorio_24h where id_rec = @id_rec", db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@id_rec", id_Rec);

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

        public void ExcluirRecordatorio(int id)
        {
            using (var db = new DatabaseConnection())
            {
                using (NpgsqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM recordatorio_24h WHERE id_rec = @id_rec";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id_rec", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Tratar exceção conforme necessário
                        Console.WriteLine("Erro ao excluir item: " + ex.Message);
                        throw;
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
                                dataGridView.Columns.Clear();
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

        public void CarregarDadosSemFiltro(string query, DataGridView dataGridView)
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

        public void ExcluirItemRecordatorio(int id)
        {
            using (var db = new DatabaseConnection())
            {
                using (NpgsqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM itens_recordatorio WHERE id_itensrec = @id_itensrec";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id_itensrec", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Tratar exceção conforme necessário
                        Console.WriteLine("Erro ao excluir item: " + ex.Message);
                        throw;
                    }
                }

            }
        }

        public class GastoEnergetico
        {
            public int Id { get; set; }
            public string GastoEnergetic { get; set; }

            public float Altura { get; set; }

            public float Peso { get; set; }

            public int Idade { get; set; }

            public string Sexo { get; set; }

            public GastoEnergetico(int id, string gastoenergetico,float altura,float peso, int idade, string sexo )
            {
                Id = id;
                GastoEnergetic = gastoenergetico;
                Altura = altura;
                Peso = peso;
                Idade = idade;
                Sexo = sexo;
            }

            // Sobrescreva o método ToString para que o ComboBox exiba a descrição da tabela TACO
            public override string ToString()
            {
                return GastoEnergetic;
            }
        }

        public void GetGastoEnergeticoCombobox(int Id_Paciente, ComboBox comboBox, TextBox altura, TextBox peso,Label idade, Label sexo)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT ga.id, ga.paciente_id, ga.ativo, ga.descricao,pa.altura,pa.peso,pa.idade,pa.sexo FROM public.gastos_caloricos ga JOIN paciente pa on pa.id_paciente = ga.paciente_id where paciente_id = @paciente_id", db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@paciente_id", Id_Paciente);

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idGasto = Convert.ToInt32(reader["id"]);
                                string descricaoGasto = reader["descricao"].ToString();

                                float altura_paciente = reader["altura"] != DBNull.Value ? Convert.ToInt32(reader["altura"]) : 0;
                                float peso_paciente = reader["peso"] != DBNull.Value ? Convert.ToInt32(reader["peso"]) : 0;
                                int idadePaciente = Convert.ToInt32(reader["idade"]);
                                string sexoPaciente = reader["sexo"].ToString();

                                comboBox.Items.Add(new GastoEnergetico(idGasto, descricaoGasto, altura_paciente, peso_paciente, idadePaciente, sexoPaciente));
                                
                                if (altura_paciente != 0) 
                                    altura.Text = Convert.ToString(altura_paciente);
                                if (peso_paciente != 0) 
                                    peso.Text = Convert.ToString(peso_paciente);
                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum Gasto Energetico encontrado para esse Paciente.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter os Gastos Energeticos: {ex.Message}");
                    }
                }
            }
        }

        public void ExcluirItemGastoEnergetico(int id)
        {
            using (var db = new DatabaseConnection())
            {
                using (NpgsqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM gasto_atividade WHERE \"id_gastoAtv\" = @id";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Tratar exceção conforme necessário
                        Console.WriteLine("Erro ao excluir item: " + ex.Message);
                        throw;
                    }
                }

            }
        }


        public class NivelAtividade
        {
            public int Id { get; set; }
            public string NivelAtv { get; set; }
            public decimal Calc { get; set; }

            public string Complemento { get; set; }

            public NivelAtividade(int id, string nivelatividade,decimal calc, string complemento)
            {
                Id = id;
                NivelAtv = nivelatividade;
                Calc = calc;
                Complemento = complemento;
            }

            // Sobrescreva o método ToString para que o ComboBox exiba a descrição da tabela TACO
            public override string ToString()
            {
                return NivelAtv;
            }
        }

        public void GetGNivelAtividadeCombobox(ComboBox comboBox, Label complemento)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT nv.id_nivel, nv.calculo, nv.descricao,nv.complemento FROM public.nivel_atividade nv order by nv.id_nivel", db.GetConnection()))
                {

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id_nivel"]);
                                string descricao = reader["descricao"].ToString();
                                string complement = reader["complemento"].ToString();
                                decimal calc = Convert.ToDecimal(reader["calculo"]);


                                comboBox.Items.Add(new NivelAtividade(id,descricao,calc, complement));
                                complemento.Text = $"{descricao} ({calc.ToString("F3")}): {complement}";

                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum Gasto Nivel de Atividade Cadastrado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter o Nivel de Atividade: {ex.Message}");
                    }
                }
            }
        }

        public class AtividadeFisica
        {
            public int Id { get; set; }
            public string Atividade { get; set; }

            public string Descricao { get; set; }

            public decimal Met { get; set; }

            public AtividadeFisica(int id, string atividade, decimal met, string descricao)
            {
                Id = id;
                Atividade = atividade;
                Met=met;
                Descricao=descricao;
            }

            // Sobrescreva o método ToString para que o ComboBox exiba a descrição da tabela TACO
            public override string ToString()
            {
                return Atividade;
            }
        }

        public void GetAtividadeFisicaGastosCombobox(ComboBox comboBox, Label label_met)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id_atividade,met,atividade,descricao FROM public.atividade_fisica", db.GetConnection()))
                {

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id_atividade"]);
                                string atividade = reader["atividade"].ToString();
                                string descricao = reader["descricao"].ToString();
                                decimal met = Convert.ToDecimal(reader["met"]);


                                comboBox.Items.Add(new AtividadeFisica(id, atividade, met,descricao));
                                label_met.Text = $"{met.ToString("F2")}. {descricao}";
                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma Atividade Fisica Cadastrada.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter as Atividades Fisicas: {ex.Message}");
                    }
                }
            }
        }

        public class Protocolos
        {
            public int Id { get; set; }
            public string Descricao { get; set; }

            public Protocolos(int id, string descricao)
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

        public void GetProtocolosCombobox(ComboBox comboBox)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id_protocolo, descricao FROM public.protocolos", db.GetConnection()))
                {

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idProtocolo = Convert.ToInt32(reader["id_protocolo"]);
                                string descricaoProtocolo = reader["descricao"].ToString();

                                comboBox.Items.Add(new Protocolos(idProtocolo, descricaoProtocolo));
                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum Protocolo encontrado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter os Protocolos: {ex.Message}");
                    }
                }
            }
        }
        public class Antropometria
        {
            public int Id { get; set; }
            public string AntropometriaDesc { get; set; }

            public int Idade { get; set; }

            public string Sexo { get; set; }

            public Antropometria(int id, string antropometriaDesc, int idade, string sexo)
            {
                Id = id;
                AntropometriaDesc = antropometriaDesc;
                Sexo = sexo;
                Idade = idade;
            }

            // Sobrescreva o método ToString para que o ComboBox exiba a descrição da tabela TACO
            public override string ToString()
            {
                return AntropometriaDesc;
            }
        }

        public void GetAntropometriaCombobox(int Id_Paciente, ComboBox comboBox, Label idade, Label sexo)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT at.id_antro, at.paciente_id,pa.idade,pa.sexo, at.\"Descricao\", at.\"Data\", at.ativo FROM public.antropometria at JOIN paciente pa ON pa.id_paciente = at.paciente_id  where at.paciente_id = @paciente_id", db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@paciente_id", Id_Paciente);

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idant = Convert.ToInt32(reader["id_antro"]);
                                string descricaoAntropometria = reader["Descricao"].ToString();
                                int idadePaciente = Convert.ToInt32(reader["idade"]);
                                string sexoPaciente = reader["sexo"].ToString();

                                comboBox.Items.Add(new Antropometria(idant, descricaoAntropometria, idadePaciente,sexoPaciente));
                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma Atividade Física cadastrada encontrada para esse Paciente.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter as Atividade Física: {ex.Message}");
                    }
                }
            }
        }

        public class ProtocolosPC
        {
            public int Id { get; set; }
            public string Descricao { get; set; }

            public ProtocolosPC(int id, string descricao)
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

        public void GetProtocolosPCCombobox(ComboBox comboBox)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id_protocolo_pc, descricao_pc FROM public.\"protocolos_Pregas_Cutaneas\"", db.GetConnection()))
                {

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idProtocolo = Convert.ToInt32(reader["id_protocolo_pc"]);
                                string descricaoProtocolo = reader["descricao_pc"].ToString();

                                comboBox.Items.Add(new ProtocolosPC(idProtocolo, descricaoProtocolo));
                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum Protocolo encontrado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter os Protocolos: {ex.Message}");
                    }
                }
            }
        }

        public class PlanoAlimentar
        {
            public int Id { get; set; }
            public string PlanoAlimentarDesc { get; set; }

            public PlanoAlimentar(int id, string planoalimentardesc)
            {
                Id = id;
                PlanoAlimentarDesc = planoalimentardesc;
            }

            // Sobrescreva o método ToString para que o ComboBox exiba a descrição da tabela TACO
            public override string ToString()
            {
                return PlanoAlimentarDesc;
            }
        }

        public void GetPlanoAlimentarCombobox(int Id_Paciente, ComboBox comboBox)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id_plano, paciente_id, nutricionista_id, ativo, descricao FROM public.plano_alimentar where paciente_id = @paciente_id", db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@paciente_id", Id_Paciente);

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idPlanoAli = Convert.ToInt32(reader["id_plano"]);
                                string descricaoPlanoAlimentar = reader["descricao"].ToString();

                                comboBox.Items.Add(new PlanoAlimentar(idPlanoAli, descricaoPlanoAlimentar));
                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum Plano Alimentar encontrado para esse Paciente.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter os Plano Alimentar: {ex.Message}");
                    }
                }
            }
        }

        public void GetPlanoAlimentarComboboxFiltroID(int id_plano, ComboBox comboBox)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT id_plano, paciente_id, nutricionista_id, ativo, descricao FROM public.plano_alimentar where id_plano = @id_plano", db.GetConnection()))
                {
                    comm.Parameters.AddWithValue("@id_plano", id_plano);

                    try
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            comboBox.Items.Clear();

                            while (reader.Read())
                            {

                                int idPlanoAli = Convert.ToInt32(reader["id_plano"]);
                                string descricaoPlanoAlimentar = reader["descricao"].ToString();

                                comboBox.Items.Add(new PlanoAlimentar(idPlanoAli, descricaoPlanoAlimentar));
                            }

                            // Verifica se encontrou
                            if (comboBox.Items.Count > 0)
                            {

                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Nenhum Plano Alimentar encontrado para esse Paciente.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter os Plano Alimentar: {ex.Message}");
                    }
                }
            }
        }

        public void ExcluirItemPlanoAlimentar(int id)
        {
            using (var db = new DatabaseConnection())
            {
                using (NpgsqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM itens_plano_alimentar WHERE id_itensplano = @id_itensplano";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id_itensplano", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Tratar exceção conforme necessário
                        Console.WriteLine("Erro ao excluir item: " + ex.Message);
                        throw;
                    }
                }

            }
        }

        public void ExcluirPlanoAlimentar(int id)
        {
            using (var db = new DatabaseConnection())
            {
                using (NpgsqlConnection connection = db.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM plano_alimentar WHERE id_plano = @id_plano";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id_plano", id);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Tratar exceção conforme necessário
                        Console.WriteLine("Erro ao excluir item: " + ex.Message);
                        throw;
                    }
                }

            }
        }

        public string CheckNutricionistaAtivo(int id)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();


                using (var comm = new NpgsqlCommand("SELECT checkNutricionistaAtivo(@id);", db.GetConnection()))
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

    }
}
