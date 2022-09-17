

namespace GuildInterface.GuildeClasses {
    public class Heroi {
        public int? id { get; set; }
        public string nome { get; set; }
        public int nivel { get; set; }
        public int idade { get; set; }
        public PictureBox foto { get; set; }
        public string classe_cod { get; set; }

        public Heroi(int? id, string nome, int nivel, int idade, PictureBox fotoPath, string classe_cod) {
            this.id = id;
            this.nome = nome;
            this.nivel = nivel;
            this.idade = idade;
            this.foto = fotoPath;
            this.classe_cod = classe_cod;
        }
        public Heroi(string nome, int nivel, int idade, PictureBox foto, string classe_cod) {
            this.nome = nome;
            this.nivel = nivel;
            this.idade = idade;
            this.foto = foto;
            this.classe_cod = classe_cod;
        }
    }
}
