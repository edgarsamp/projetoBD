using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class HeroiGrupo {
        public int? id { get; set; }
        public int heroiId { get; set; }
        public int grupoId { get; set; }

        public HeroiGrupo(int? id, int heroiId, int grupoId) {
            this.id = id;
            this.heroiId = heroiId;
            this.grupoId = grupoId;
        }
        public HeroiGrupo(int heroiId, int grupoId) {
            this.id = id;
            this.heroiId = heroiId;
            this.grupoId = grupoId;
        }
    }
}
