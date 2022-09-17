using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class LugarCriatura {
        public int? id { get; set; }
        public int lugarId { get; set; }
        public int criaturaId { get; set; }

        public LugarCriatura(int? id, int lugarId, int criaturaId) {
            this.id = id;
            this.lugarId = lugarId;
            this.criaturaId = criaturaId;
        }
        public LugarCriatura(int lugarId, int criaturaId) {
            this.id = id;
            this.lugarId = lugarId;
            this.criaturaId = criaturaId;
        }
    }
}
