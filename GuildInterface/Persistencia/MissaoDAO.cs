using GuildInterface.GuildeClasses;
using MySql.Data.MySqlClient;


namespace GuildInterface.Persistencia {
    public class MissaoDAO {
        private readonly string dt_source = "datasource=localhost;username=root;password=Ep525Cqaj;database=GerenciadorGuild";
        private MySqlConnection conexao;

        public MissaoDAO() {
            conexao = new MySqlConnection(dt_source);
        }

        public List<string[]> ConsultarByGrupoId(int? id) {

            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();

            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Missao where grupo_Id=@grupoId;";

                cmd.Parameters.AddWithValue("@grupoId", id);

                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //id
                        r.GetString(1), //dtInicio
                        r.GetString(2), //dtTermino
                        r.GetString(3), //foiConcluida
                        r.GetString(4), //nivelDificuldade
                        r.GetString(5), //contratanteId
                        r.GetString(6), //grupoId
                        r.GetString(7), //lugarId
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

        public List<string[]> ConsultarByGrupoId() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Missao ORDER by id asc;";
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //id
                        r.GetString(1), //dtInicio
                        r.GetString(2), //dtTermino
                        r.GetString(3), //foiConcluida
                        r.GetString(4), //nivelDificuldade
                        r.GetString(5), //contratanteId
                        r.GetString(6), //grupoId
                        r.GetString(7), //lugarId
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

        public void Editar(Missao miss) {
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"UPDATE Missao SET dtInicio=@dtInicio, dtTermino=@dtTermino, foiConcluida=@foiConcluida, nivelDificuldade=@nivelDificuldade, contratante_id=@contratanteId, grupo_Id=@grupoId, lugar_Id=@lugarId WHERE id=@id ;";

                cmd.Parameters.AddWithValue("@id", miss.id);
                cmd.Parameters.AddWithValue("@dtInicio", miss.dtInicio);
                cmd.Parameters.AddWithValue("@dtTermino", miss.dtTermino);
                cmd.Parameters.AddWithValue("@foiConcluida", miss.foiConcluida);
                cmd.Parameters.AddWithValue("@nivelDificuldade", miss.nivelDificuldade);
                cmd.Parameters.AddWithValue("@contratanteId", miss.contratanteId);
                cmd.Parameters.AddWithValue("@grupoId", miss.grupoId);
                cmd.Parameters.AddWithValue("@lugarId", miss.lugarId);
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


                cmd.CommandText = "DELETE from Missao WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public void Incluir(Missao miss) {
            try {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"INSERT INTO Missao (dtInicio, dtTermino, foiConcluida, nivelDificuldade, contratante_id, grupo_id, lugar_Id) VALUES (@dtInicio, @dtTermino, @foiConcluida, @nivelDificuldade, @contratanteId, @grupoId, @lugarId);";

                cmd.Parameters.AddWithValue("@dtInicio", miss.dtInicio);
                cmd.Parameters.AddWithValue("@dtTermino", miss.dtTermino);
                cmd.Parameters.AddWithValue("@foiConcluida", miss.foiConcluida);
                cmd.Parameters.AddWithValue("@nivelDificuldade", miss.nivelDificuldade);
                cmd.Parameters.AddWithValue("@contratanteId", miss.contratanteId);
                cmd.Parameters.AddWithValue("@grupoId", miss.grupoId);
                cmd.Parameters.AddWithValue("@lugarId", miss.lugarId);
                cmd.Prepare();

                cmd.ExecuteNonQuery();


            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }
        }

        public List<string[]> getGrupos() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select id, nome from Grupo ORDER by id asc;";
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

        public List<string[]> getLugares() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select id, nome from Lugar ORDER by id asc;";
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
        public List<string[]> getContratantes() {
            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();

                cmd.Connection = conexao;

                cmd.CommandText = $"select id, nome from Contratante ORDER by id asc;";
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
