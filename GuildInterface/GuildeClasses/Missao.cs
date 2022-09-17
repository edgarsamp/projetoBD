using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class Missao {
        public int? id { get; set; }
        public DateTime dtInicio { get; set; }
        public DateTime dtTermino { get; set; }
        public bool foiConcluida { get; set; }
        public int nivelDificuldade { get; set; }
        public int contratanteId { get; set; }
        public int grupoId { get; set; }
        public int lugarId { get; set; }

        public Missao(int? id, DateTime dtInicio, DateTime dtTermino, bool foiConcluida, int nivelDificuldade, int contratanteId, int grupoId, int lugarId) {
            this.id = id;
            this.dtInicio = dtInicio;
            this.dtTermino = dtTermino;
            this.foiConcluida = foiConcluida;
            this.nivelDificuldade = nivelDificuldade;
            this.contratanteId = contratanteId;
            this.grupoId = grupoId;
            this.lugarId = lugarId;
        }
        public Missao(DateTime dtInicio, DateTime dtTermino, bool foiConcluida, int nivelDificuldade, int contratanteId, int grupoId, int lugarId) {
            this.dtInicio = dtInicio;
            this.dtTermino = dtTermino;
            this.foiConcluida = foiConcluida;
            this.nivelDificuldade = nivelDificuldade;
            this.contratanteId = contratanteId;
            this.grupoId = grupoId;
            this.lugarId = lugarId;
        }
    }
}
