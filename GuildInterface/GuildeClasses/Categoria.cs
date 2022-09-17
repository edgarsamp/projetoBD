using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class Categoria {
        public int? id { get; set; }
        public string nome { get; set; }

        public Categoria(int? id, string nome) {
            this.id = id;
            this.nome = nome;
        }
        public Categoria(string nome) {
            this.nome = nome;
        }
    }
}
