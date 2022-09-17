using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class Recompensa {
        public int? id { get; set; }
        public int missaoId { get; set; }
        public int dinheiro { get; set; }

        public Recompensa(int? id, int missaoId, int dinheiro) {
            this.id = id;
            this.missaoId = missaoId;
            this.dinheiro = dinheiro;
        }
        public Recompensa(int missaoId, int dinheiro) {
            this.missaoId = missaoId;
            this.dinheiro = dinheiro;
        }
    }
}
