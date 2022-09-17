USE GerenciadorGuild;

DELIMITER $$
CREATE PROCEDURE seleciona_heroi_nome_e_classe(IN id int)
begin
	select h.id,  h.nome, c.nome from heroi h, classe c where h.classe_cod = c.codigo and h.id = id;
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE seleciona_herois_nome_e_classe()
begin
	select h.id,  h.nome, c.nome from heroi h, classe c where h.classe_cod = c.codigo;
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE seleciona_item_nome_e_categoria(IN id int)
begin
	select i.id,  i.nome, c.nome from item i, categoria c where i.categoria_id = c.id and i.id = id;
end $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE seleciona_itens_nome_e_categoria()
begin
	select i.id,  i.nome, c.nome from item i, categoria c where i.categoria_id = c.id;
end $$
DELIMITER ;


call seleciona_heroi_nome_e_classe(2);
call seleciona_item_nome_e_categoria(1);
call seleciona_itens_nome_e_categoria();
call seleciona_herois_nome_e_classe();




