using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class Item {
        public int? id { get; set; }
        public string nome { get; set; }
        public int raridade { get; set; }
        public string descricao { get; set; }
        public int precoMedio { get; set; }
        public int categoriaId { get; set; }

        public Item(int? id, string nome, int raridade, string descricao, int precoMedio, int categoriaId) {
            this.id = id;
            this.nome = nome;
            this.raridade = raridade;
            this.descricao = descricao;
            this.precoMedio = precoMedio;
            this.categoriaId = categoriaId;
        }
        public Item(string nome, int raridade, string descricao, int precoMedio, int categoriaId) {
            this.nome = nome;
            this.raridade = raridade;
            this.descricao = descricao;
            this.precoMedio = precoMedio;
            this.categoriaId = categoriaId;
        }
    }
}
