using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class Criatura {
        public int? id { get; set; }
        public string nome { get; set; }
        public int nivelPericulosidade { get; set; }

        public Criatura(int? id, string nome, int nivelPericulosidade) {
            this.id = id;
            this.nome = nome;
            this.nivelPericulosidade = nivelPericulosidade;
        }
        public Criatura(string nome, int nivelPericulosidade) {
            this.nome = nome;
            this.nivelPericulosidade = nivelPericulosidade;
        }
    }
}
