using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class ItemRecompensa {
        public int? id { get; set; }
        public int itemId { get; set; }
        public int recompensaId { get; set; }
        public int quantidade { get; set; }

        public ItemRecompensa(int? id, int itemId, int recompensaId, int quantidade) {
            this.id = id;
            this.itemId = itemId;
            this.recompensaId = recompensaId;
            this.quantidade = quantidade;
        }
        public ItemRecompensa(int itemId, int recompensaId, int quantidade) {
            this.itemId = itemId;
            this.recompensaId = recompensaId;
            this.quantidade = quantidade;
        }
    }
}
