-- -----------------------------------------------------
-- Table Classe
-- -----------------------------------------------------
insert into Classe value('mag', 'Mago');
insert into Classe value('brd', 'Bardo');
insert into Classe value('clr', 'Clérigo');
insert into Classe value('gue', 'Guerreiro');
insert into Classe value('ldn', 'Ladino');
insert into Classe value('pld', 'Paladino');
-- select * from Classe;

-- -----------------------------------------------------
-- Table Grupo
-- -----------------------------------------------------
insert into Grupo (nome, descricao) value('Grupo1', 'Um grupo legal');
insert into Grupo (nome, descricao) value('Grupo2', 'Um grupo bacana');
insert into Grupo (nome, descricao) value('Grupo3', 'Um grupo joia');
insert into Grupo (nome, descricao) value('Grupo4', 'Um grupo formidável');
insert into Grupo (nome, descricao) value('Grupo5', 'Um grupo dahora');
-- select * from Grupo;

-- -----------------------------------------------------
-- Table Contratante
-- -----------------------------------------------------
insert into Contratante (nome, profissao) value('Contratante1', 'Padeiro');
insert into Contratante (nome, profissao) value('Contratante2', 'Padre');
insert into Contratante (nome, profissao) value('Contratante3', 'Rainha');
insert into Contratante (nome, profissao) value('Contratante4', 'Curandeiro');
insert into Contratante (nome, profissao) value('Contratante5', 'Viajante');
-- select * from Contratante;

-- -----------------------------------------------------
-- Table Criaturas
-- -----------------------------------------------------
insert into Criatura (nome, nivelPericulosidade) value('Esqueleto', 1);
insert into Criatura (nome, nivelPericulosidade) value('Zumbi', 1);
insert into Criatura (nome, nivelPericulosidade) value('Dragão', 10);
insert into Criatura (nome, nivelPericulosidade) value('Ogro', 3);
insert into Criatura (nome, nivelPericulosidade) value('Orc lider', 3);
-- select * from Criatura;

-- -----------------------------------------------------
-- Table Categoria
-- -----------------------------------------------------
INSERT INTO  Categoria (nome) VALUES('Arma');
INSERT INTO  Categoria (nome) VALUES('Armadura');
INSERT INTO  Categoria (nome) VALUES('Comida');
INSERT INTO  Categoria (nome) VALUES('Valioso');
INSERT INTO  Categoria (nome) VALUES('Produto de criatura');
-- select * from Categoria;

-- -----------------------------------------------------
-- Table Heroi
-- -----------------------------------------------------
-- INSERT INTO Heroi (nome, nivel, idade, foto, classe_cod) VALUES('Gustavo', 1, 30, LOAD_FILE('1.jpg'), 'mag');
-- INSERT INTO Heroi (nome, nivel, idade, foto, classe_cod) VALUES('Maria', 1, 27, LOAD_FILE('2.jpg'), 'brd');
-- INSERT INTO Heroi (nome, nivel, idade, foto, classe_cod) VALUES('Joana', 1, 45, LOAD_FILE('3.jpg'), 'mag');
-- INSERT INTO Heroi (nome, nivel, idade, foto, classe_cod) VALUES('Mario', 1, 24, LOAD_FILE('4.jpg'), 'ldn');
-- INSERT INTO Heroi (nome, nivel, idade, foto, classe_cod) VALUES('Fernanda', 1, 19, LOAD_FILE('5.jpg'), 'clr');
-- select * from Heroi;

-- -----------------------------------------------------
-- Table Lugar
-- -----------------------------------------------------
INSERT INTO Lugar (nome, descricao) VALUES('Floresta normal', 'Uma floresta normal');
INSERT INTO Lugar (nome, descricao) VALUES('Deserto', 'Um simples deserto');
INSERT INTO Lugar (nome, descricao) VALUES('Tumba do faraó', 'A tumba do grande faraó');
INSERT INTO Lugar (nome, descricao) VALUES('Torre mágica', 'Uma torre mágica abandonada');
INSERT INTO Lugar (nome, descricao) VALUES('Acampamento de orcs', 'Um acampamento de orcs');
-- select * from Lugar;

-- -----------------------------------------------------
-- Table Missao
-- -----------------------------------------------------
INSERT INTO Missao (dtInicio, dtTermino, foiConcluida, nivelDificuldade, contratante_id, grupo_id, lugar_Id)
			VALUES (NOW(), NOW(), TRUE, 2, 1, 1, 1);
INSERT INTO Missao (dtInicio, dtTermino, foiConcluida, nivelDificuldade, contratante_id, grupo_id, lugar_Id)
			VALUES (NOW(), NOW(), TRUE, 2, 2, 2, 2);
INSERT INTO Missao (dtInicio, dtTermino, foiConcluida, nivelDificuldade, contratante_id, grupo_id, lugar_Id)
			VALUES (NOW(), NOW(), TRUE, 2, 3, 4, 3);
INSERT INTO Missao (dtInicio, dtTermino, foiConcluida, nivelDificuldade, contratante_id, grupo_id, lugar_Id)
			VALUES (NOW(), NOW(), TRUE, 2, 4, 4, 4);
INSERT INTO Missao (dtInicio, dtTermino, foiConcluida, nivelDificuldade, contratante_id, grupo_id, lugar_Id)
			VALUES (NOW(), NOW(), TRUE, 2, 5, 5, 5);
-- select * from Missao;

-- -----------------------------------------------------
-- Table Recompensa
-- -----------------------------------------------------
INSERT INTO Recompensa (missao_id, dinheiro) VALUES (1, 0);
INSERT INTO Recompensa (missao_id, dinheiro) VALUES (2, 10);
INSERT INTO Recompensa (missao_id, dinheiro) VALUES (3, 20);
INSERT INTO Recompensa (missao_id, dinheiro) VALUES (4, 450);
INSERT INTO Recompensa (missao_id, dinheiro) VALUES (5, 10000);
-- select * from Recompensa;

SET FOREIGN_KEY_CHECKS=0;
-- -----------------------------------------------------
-- Table ItemRecompensa
-- -----------------------------------------------------
INSERT INTO ItemRecompensa (item_id, recompensa_id, quantidade) VALUE (4, 1, 2);
INSERT INTO ItemRecompensa (item_id, recompensa_id, quantidade) VALUE (1, 3, 1);
INSERT INTO ItemRecompensa (item_id, recompensa_id, quantidade) VALUE (2, 3, 1);
INSERT INTO ItemRecompensa (item_id, recompensa_id, quantidade) VALUE (5, 2, 20);
INSERT INTO ItemRecompensa (item_id, recompensa_id, quantidade) VALUE (3, 4, 10);
-- select * from ItemRecompensa;

-- -----------------------------------------------------
-- Table Lugarcriatura
-- -----------------------------------------------------
INSERT INTO LugarCriatura (lugar_id, criatura_id) value (1, 1);
INSERT INTO LugarCriatura (lugar_id, criatura_id) value (2, 2);
INSERT INTO LugarCriatura (lugar_id, criatura_id) value (3, 3);
INSERT INTO LugarCriatura (lugar_id, criatura_id) value (4, 4);
INSERT INTO LugarCriatura (lugar_id, criatura_id) value (5, 5);
-- select * from LugarCriatura;

-- -----------------------------------------------------
-- Table HeroiGrupo
-- -----------------------------------------------------
-- INSERT INTO HeroiGrupo (heroi_id, grupo_id) value (1, 1);
-- INSERT INTO HeroiGrupo (heroi_id, grupo_id) value (2, 1);
-- INSERT INTO HeroiGrupo (heroi_id, grupo_id) value (3, 1);
-- INSERT INTO HeroiGrupo (heroi_id, grupo_id) value (4, 2);
-- INSERT INTO HeroiGrupo (heroi_id, grupo_id) value (5, 2);
-- INSERT INTO HeroiGrupo (heroi_id, grupo_id) value (1, 3);
-- INSERT INTO HeroiGrupo (heroi_id, grupo_id) value (2, 4);
-- INSERT INTO HeroiGrupo (heroi_id, grupo_id) value (3, 5);
-- select * from HeroiGrupo;

-- -----------------------------------------------------
-- Table Item
-- -----------------------------------------------------
INSERT INTO Item (nome, raridade, descricao, precoMedio, categoria_id) VALUES ('Espada linda', 3, 'Uma espada bem bonita', 500, 1);
INSERT INTO Item (nome, raridade, descricao, precoMedio, categoria_id) VALUES ('Armadura verde', 2, 'Uma armadura normal porem verde', 10, 2);
INSERT INTO Item (nome, raridade, descricao, precoMedio, categoria_id) VALUES ('Pão', 1, 'Pão quentinho', 1, 3);
INSERT INTO Item (nome, raridade, descricao, precoMedio, categoria_id) VALUES ('Diamante', 5, 'Um diamente polido', 50, 4);
INSERT INTO Item (nome, raridade, descricao, precoMedio, categoria_id) VALUES ('Lã', 1, 'Um pouco de lã', 3, 5);
 select * from Item;
 SET FOREIGN_KEY_CHECKS=1;