using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class Classe {
        public string? codigo { get; set; }
        public string nome { get; set; }

        public Classe(string? codigo, string nome) {
            this.codigo = codigo;
            this.nome = nome;
        }
        public Classe(string nome) {
            this.nome = nome;
        }
    }
}
