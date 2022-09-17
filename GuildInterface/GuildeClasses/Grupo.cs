﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildInterface.GuildeClasses {
    public class Grupo {
        public int? id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public Grupo(int? id, string nome, string descricao) {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
        }
        public Grupo(string nome, string descricao) {
            this.nome = nome;
            this.descricao = descricao;
        }
    }
}
