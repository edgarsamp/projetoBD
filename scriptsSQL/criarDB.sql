CREATE DATABASE IF NOT EXISTS GerenciadorGuild;
USE GerenciadorGuild;

-- -----------------------------------------------------
-- Table Classe
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Classe (
  codigo VARCHAR(3) NOT NULL PRIMARY KEY,
  nome VARCHAR(45) NOT NULL);

-- -----------------------------------------------------
-- Table Grupo
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Grupo (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(45) NOT NULL,
  descricao VARCHAR(45) NULL);

-- -----------------------------------------------------
-- Table Contratante
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Contratante (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(45) NOT NULL,
  profissao VARCHAR(45) NOT NULL);

-- -----------------------------------------------------
-- Table criatura
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Criatura (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(45) NULL,
  nivelPericulosidade INT NOT NULL);

-- -----------------------------------------------------
-- Table Categoria
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Categoria (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(45) NOT NULL);

-- -----------------------------------------------------
-- Table Heroi
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Heroi (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(45) NOT NULL,
  nivel INT NOT NULL,
  idade INT NOT NULL,
  foto LONGBLOB NULL,
  classe_cod VARCHAR(3) NOT NULL,
  INDEX fk_Heroi_Classe1_idx (classe_cod ASC) VISIBLE,
  CONSTRAINT fk_Heroi_Classe1
    FOREIGN KEY (classe_cod)
    REFERENCES Classe (codigo)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
    
-- -----------------------------------------------------
-- Table Lugar
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Lugar (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(45) NOT NULL,
  descricao VARCHAR(45) NULL);
  
-- -----------------------------------------------------
-- Table missao
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Missao (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  dtInicio DATE NOT NULL,
  dtTermino DATE NULL,
  foiConcluida BOOL NOT NULL,
  nivelDificuldade INT NOT NULL,
  contratante_Id INT NOT NULL,
  grupo_Id INT NOT NULL,
  lugar_Id INT NOT NULL,
  INDEX fk_Missão_Contratante1_idx (contratante_Id ASC) VISIBLE,
  INDEX fk_Missão_Grupo1_idx (grupo_Id ASC) VISIBLE,
  INDEX fk_Missão_Lugar1_idx (lugar_Id ASC) VISIBLE,
  CONSTRAINT fk_Missão_Contratante1
    FOREIGN KEY (Contratante_Id)
    REFERENCES Contratante (Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT fk_Missão_Grupo1
    FOREIGN KEY (Grupo_Id)
    REFERENCES Grupo (Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT fk_Missão_Lugar1
    FOREIGN KEY (Lugar_Id)
    REFERENCES Lugar (Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- -----------------------------------------------------
-- Table Recompensa
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Recompensa (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  missao_id INT NOT NULL,
  dinheiro INT NULL,
  INDEX fk_Recompensa_Missao1_idx (Missao_id ASC) VISIBLE,
  CONSTRAINT fk_Recompensa_Missao1
    FOREIGN KEY (missao_id)
    REFERENCES Missao (id)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- -----------------------------------------------------
-- Table Item
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS Item (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(45) NOT NULL,
  raridade INT NOT NULL,
  descricao VARCHAR(45) NULL,
  precoMedio INT NULL,
  categoria_id INT NOT NULL,
  INDEX fk_Item_Categoria1_idx (categoria_id ASC) VISIBLE,
  CONSTRAINT fk_Item_Categoria1
    FOREIGN KEY (categoria_id)
    REFERENCES Categoria (id)
    ON DELETE CASCADE
    ON UPDATE CASCADE
    );
   
-- -----------------------------------------------------
-- Table ItemRecompensa
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS ItemRecompensa (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  item_id INT NOT NULL,
  recompensa_id INT NOT NULL,
  quantidade INT NOT NULL, 
  INDEX fk_Item_has_Recompensa_Recompensa1_idx (Recompensa_id ASC) VISIBLE,
  INDEX fk_Item_has_Recompensa_Item1_idx (Item_Id ASC) VISIBLE,
  CONSTRAINT fk_Item_has_Recompensa_Item1
    FOREIGN KEY (Item_Id)
    REFERENCES Item (Id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT fk_Item_has_Recompensa_Recompensa1
    FOREIGN KEY (Recompensa_id)
    REFERENCES Recompensa (id)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- -----------------------------------------------------
-- Table Lugarcriatura
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS LugarCriatura (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  lugar_id INT NOT NULL,
  criatura_id INT NOT NULL,
  INDEX fk_Lugar_has_criatura_criatura1_idx (criatura_id ASC) VISIBLE,
  INDEX fk_Lugar_has_criatura_Lugar1_idx (Lugar_id ASC) VISIBLE,
  CONSTRAINT fk_Lugar_has_criatura_Lugar1
    FOREIGN KEY (Lugar_id)
    REFERENCES Lugar (id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT fk_Lugar_has_criatura_criatura1
    FOREIGN KEY (criatura_id)
    REFERENCES criatura (id)
    ON DELETE CASCADE
    ON UPDATE CASCADE);

-- -----------------------------------------------------
-- Table HeroiGrupo
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS HeroiGrupo (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  heroi_id INT NOT NULL,
  grupo_id INT NOT NULL,
  INDEX fk_Heroi_has_Grupo_Grupo1_idx (Grupo_id ASC) VISIBLE,
  INDEX fk_Heroi_has_Grupo_Heroi1_idx (Heroi_id ASC) VISIBLE,
  CONSTRAINT fk_Heroi_has_Grupo_Heroi1
    FOREIGN KEY (Heroi_id)
    REFERENCES Heroi (id)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT fk_Heroi_has_Grupo_Grupo1
    FOREIGN KEY (Grupo_id)
    REFERENCES Grupo (id)
    ON DELETE CASCADE
    ON UPDATE CASCADE);
