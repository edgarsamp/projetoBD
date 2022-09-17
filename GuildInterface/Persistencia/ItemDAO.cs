using GuildInterface.GuildeClasses;
using MySql.Data.MySqlClient;


namespace GuildInterface.Persistencia {
    public class ItemDAO {
        private readonly string dt_source = "datasource=localhost;username=root;password=Ep525Cqaj;database=GerenciadorGuild";
        private MySqlConnection conexao;

        public ItemDAO() {
            conexao = new MySqlConnection(dt_source);
        }

        public List<string[]> ConsultarByNome(string nome) {

            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();

            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Item where nome like @querry;";

                cmd.Parameters.AddWithValue("@querry", $"%{nome}%");
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //id
                        r.GetString(1), //nome
                        r.GetString(2), //raridade
                        r.GetString(3), //descricao
                        r.GetString(4), //precoMedio
                        r.GetString(5) //categoria_id
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

                cmd.CommandText = $"select * from Item ORDER by id asc;";
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //id
                        r.GetString(1), //nome
                        r.GetString(2), //raridade
                        r.GetString(3), //descricao
                        r.GetString(4), //precoMedio
                        r.GetString(5) //categoria_id
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

        public void Editar(Item item) {
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"UPDATE Item SET nome=@nome, raridade=@raridade, descricao=@descricao, precoMedio=@precoMedio, categoria_id=@categoriaId WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", item.id);
                cmd.Parameters.AddWithValue("@nome", item.nome);
                cmd.Parameters.AddWithValue("@raridade", item.raridade);
                cmd.Parameters.AddWithValue("@descricao", item.descricao);
                cmd.Parameters.AddWithValue("@precoMedio", item.precoMedio);
                cmd.Parameters.AddWithValue("@categoriaId", item.categoriaId);
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


                cmd.CommandText = "DELETE from Item WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public void Incluir(Item item) {
            try {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"INSERT INTO Item (nome, raridade, descricao, precoMedio, categoria_id) VALUES (@nome, @raridade, @descricao, @precoMedio, @categoria_id);";

                cmd.Parameters.AddWithValue("@nome", item.nome);
                cmd.Parameters.AddWithValue("@raridade", item.raridade);
                cmd.Parameters.AddWithValue("@descricao", item.descricao);
                cmd.Parameters.AddWithValue("@precoMedio", item.precoMedio);
                cmd.Parameters.AddWithValue("@categoria_id", item.categoriaId);
                cmd.Prepare();

                cmd.ExecuteNonQuery();


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public List<string[]> getCategoria() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Categoria ORDER by id asc;";
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
