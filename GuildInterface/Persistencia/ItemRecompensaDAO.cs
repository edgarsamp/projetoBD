using GuildInterface.GuildeClasses;
using MySql.Data.MySqlClient;


namespace GuildInterface.Persistencia {
    public class ItemRecompensaDAO {
        private readonly string dt_source = "datasource=localhost;username=root;password=Ep525Cqaj;database=GerenciadorGuild";
        private MySqlConnection conexao;

        public ItemRecompensaDAO() {
            conexao = new MySqlConnection(dt_source);
        }

        public List<string[]> ConsultarById(int? itemId) {

            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();

            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                cmd.Connection = conexao;

                cmd.CommandText = $"select * from ItemRecompensa where item_id=@itemId ORDER by id asc;";

                cmd.Parameters.AddWithValue("@itemId", itemId);

                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //id
                        r.GetString(1), //item_id
                        r.GetString(2), //recompensa_id
                        r.GetString(3), //quantidade
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

        public List<string[]> ConsultarByName() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select * from ItemRecompensa ORDER by id asc;";
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //id
                        r.GetString(1), //item_id
                        r.GetString(2), //recompensa_id
                        r.GetString(3), //quantidade
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

        public void Editar(ItemRecompensa itmRecom) {
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"UPDATE ItemRecompensa SET item_id=@itemId, recompensa_id=@recompensaId, quantidade=@quantidade WHERE id=@id ;";

                cmd.Parameters.AddWithValue("@id", itmRecom.id);
                cmd.Parameters.AddWithValue("@itemId", itmRecom.itemId);
                cmd.Parameters.AddWithValue("@recompensaId", itmRecom.recompensaId);
                cmd.Parameters.AddWithValue("@quantidade", itmRecom.quantidade);
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


                cmd.CommandText = "DELETE from ItemRecompensa WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public void Incluir(ItemRecompensa itmRecom) {
            try {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"INSERT INTO ItemRecompensa (item_id, recompensa_id, quantidade) VALUES (@itemId, @recompensaId, @quantidade);";

                cmd.Parameters.AddWithValue("@id", itmRecom.id);
                cmd.Parameters.AddWithValue("@itemId", itmRecom.itemId);
                cmd.Parameters.AddWithValue("@recompensaId", itmRecom.recompensaId);
                cmd.Parameters.AddWithValue("@quantidade", itmRecom.quantidade);
                cmd.Prepare();

                cmd.ExecuteNonQuery();


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public List<string[]> getItens() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select id, nome from Item ORDER by id asc;";
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

        public List<string[]> getRecompensas() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select id, missao_id from Recompensa ORDER by id asc;";
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
