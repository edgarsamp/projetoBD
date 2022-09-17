using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class Contratante {
        public int? id { get; set; }
        public string nome { get; set; }
        public string profissao { get; set; }

        public Contratante(int? idNovo, string nom, string prof) {
            nome = nom;
            profissao = prof;
            id = idNovo;
        }
        public Contratante(string nom, string prof) {
            nome = nom;
            profissao = prof;
        }

    }
}
