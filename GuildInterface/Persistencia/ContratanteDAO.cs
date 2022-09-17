using GuildInterface.GuildeClasses;
using MySql.Data.MySqlClient;

namespace GuildInterface.Persistencia {
    public class ContratanteDAO {
        private readonly string dt_source = "datasource=localhost;username=root;password=Ep525Cqaj;database=GerenciadorGuild";
        private MySqlConnection conexao;

        public ContratanteDAO() {
            conexao = new MySqlConnection(dt_source);
        }

        public List<string[]> ConsultarByNome(string nome) {

            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();

            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Contratante where nome like @querry;";

                cmd.Parameters.AddWithValue("@querry", $"%{nome}%");
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //index
                        r.GetString(1), //nome
                        r.GetString(2)  //profissao
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

        public List<string[]> ConsultarByNome() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Contratante ORDER by id asc;";
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //index
                        r.GetString(1), //nome
                        r.GetString(2)  //profissao
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

        public void Editar(Contratante contr) {
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"UPDATE Contratante SET nome=@nome, profissao=@profissao WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", contr.id);
                cmd.Parameters.AddWithValue("@nome", contr.nome);
                cmd.Parameters.AddWithValue("@profissao", contr.profissao);
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

                cmd.CommandText = $"DELETE FROM Contratante WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }

        }

        public void Incluir(Contratante contr) {
            try {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"insert into Contratante (nome, profissao) value(@nome, @profissao);";

                cmd.Parameters.AddWithValue("@nome", contr.nome);
                cmd.Parameters.AddWithValue("@profissao", contr.profissao);
                cmd.Prepare();

                cmd.ExecuteNonQuery();


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }
    }


}
