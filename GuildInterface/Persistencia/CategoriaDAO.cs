using GuildInterface.GuildeClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.Persistencia {
    public class CategoriaDAO {
        private readonly string dt_source = "datasource=localhost;username=root;password=Ep525Cqaj;database=GerenciadorGuild";
        private MySqlConnection conexao;

        public CategoriaDAO() {
            conexao = new MySqlConnection(dt_source);
        }

        public List<string[]> ConsultarByNome(string nome) {

            MySqlCommand cmd = new MySqlCommand();
            var linhas = new List<string[]>();

            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                cmd.Connection = conexao;

                cmd.CommandText = $"select * from Categoria where nome like @nome;";

                cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
                cmd.Prepare();

                var r = cmd.ExecuteReader();

                while (r.Read()) {
                    string[] linha = {
                        r.GetString(0), //index
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

        public List<string[]> ConsultarByNome() {
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
                        r.GetString(0), //index
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

        public void Editar(Categoria cat) {
            try {
                conexao = new MySqlConnection(dt_source);
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"UPDATE Categoria SET nome=@nome WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", cat.id);
                cmd.Parameters.AddWithValue("@nome", cat.nome);
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

                cmd.CommandText = $"DELETE FROM Categoria WHERE id=@id;";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();

            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            } finally {
                conexao.Close();
            }

        }

        public void Incluir(Categoria cat) {
            try {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;

                cmd.CommandText = $"insert into Categoria (nome) value(@nome);";

                cmd.Parameters.AddWithValue("@nome", cat.nome);
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
