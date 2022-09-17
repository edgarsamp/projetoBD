using GuildInterface.GuildeClasses;
using MySql.Data.MySqlClient;


namespace GuildInterface.Persistencia {
    public class HeroiDAO {
        private readonly string dt_source = "datasource=localhost;username=root;password=Ep525Cqaj;database=GerenciadorGuild";
        private MySqlConnection conexao;

        public HeroiDAO() {
            conexao = new MySqlConnection(dt_source);
        }

        public List<string[]> ConsultarByNome(string nome) {

            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();

            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Heroi where nome like @nome;";
                cmd.Parameters.AddWithValue("@nome", $"%{nome}%");


                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //id
                        r.GetString(1), //nome
                        r.GetString(2), //nivel
                        r.GetString(3), //idade
                        r.GetString(4), //foto
                        r.GetString(5), //classeCod
                    };
                    linhas.Add(linha);
                }

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
            return linhas;

        }

        public byte[] ConsultarImagem(string id) {
            MySqlCommand cmd = new MySqlCommand();
            byte[] img = new byte[1];
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select id, foto from Heroi where id=@id;";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                var r = cmd.ExecuteReader();


                while (r.Read()) {
                    byte[] temp = (byte[])r.GetValue(1);
                    img = (byte[])r.GetValue(1);
                }


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }

            return img;
        }
        public List<string[]> ConsultarByNome() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Heroi ORDER by id asc;";
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //id
                        r.GetString(1), //nome
                        r.GetString(2), //nivel
                        r.GetString(3), //idade
                        r.GetString(4), //idade
                        r.GetString(5), //classeCod
                    };
                    linhas.Add(linha);
                }


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }

            return linhas;
        }

        public void Editar(Heroi hero) {
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"UPDATE Heroi SET nome=@nome, nivel=@nivel, idade=@idade, foto=@foto, classe_cod=@classe WHERE id=@id ;";

                cmd.Parameters.AddWithValue("@id", hero.id);
                cmd.Parameters.AddWithValue("@nome", hero.nome);
                cmd.Parameters.AddWithValue("@nivel", hero.nivel);
                cmd.Parameters.AddWithValue("@idade", hero.idade);
                cmd.Parameters.AddWithValue("@foto", TrataImagem.imageToByte(hero.foto.Image));
                cmd.Parameters.AddWithValue("@classe", hero.classe_cod);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public void Excluir(int? id) {
            try {
                if (id == null) return;

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;


                cmd.CommandText = "DELETE from Heroi WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public void Incluir(Heroi hero) {
            try {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"INSERT INTO Heroi (nome, nivel, idade, foto, classe_cod) VALUES (@nome, @nivel, @idade, @foto, @classe);";

                cmd.Parameters.AddWithValue("@nome", hero.nome);
                cmd.Parameters.AddWithValue("@nivel", hero.nivel);
                cmd.Parameters.AddWithValue("@idade", hero.idade);
                var img = TrataImagem.imageToByte(hero.foto.Image);
                cmd.Parameters.AddWithValue("@foto", img);
                cmd.Parameters.AddWithValue("@classe", hero.classe_cod);
                cmd.Prepare();

                cmd.ExecuteNonQuery();


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public List<string[]> getClasses() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Classe;";
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //codigo
                        r.GetString(1), //nome
                    };
                    linhas.Add(linha);
                }


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }

            return linhas;
        }
    }
}
