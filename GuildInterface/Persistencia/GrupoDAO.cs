using GuildInterface.GuildeClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.Persistencia {
    public class GrupoDAO {
        private readonly string dt_source = "datasource=localhost;username=root;password=Ep525Cqaj;database=GerenciadorGuild";
        private MySqlConnection conexao;

        public GrupoDAO() {
            conexao = new MySqlConnection(dt_source);
        }

        public List<string[]> ConsultarByNome(string nome) {

            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();

            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Grupo where nome like @querry;";

                cmd.Parameters.AddWithValue("@querry", $"%{nome}%");
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //index
                        r.GetString(1), //nome
                        r.GetString(2)  //descrição
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

                cmd.CommandText = $"select * from Grupo ORDER by id asc;";
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //index
                        r.GetString(1), //nome
                        r.GetString(2)  //descrição
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

        public void Editar(Grupo grup) {
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"UPDATE Grupo SET nome=@nome, descricao=@descricao WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", grup.id);
                cmd.Parameters.AddWithValue("@nome", grup.nome);
                cmd.Parameters.AddWithValue("@descricao", grup.descricao);
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

                cmd.CommandText = $"DELETE FROM Grupo WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }

        }

        public void Incluir(Grupo grup) {
            try {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"insert into Grupo (nome, descricao) value(@nome, @descricao);";

                cmd.Parameters.AddWithValue("@nome", grup.nome);
                cmd.Parameters.AddWithValue("@descricao", grup.descricao);
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
