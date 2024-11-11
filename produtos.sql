create database bd_produtos;
use bd_produtos;

drop table produtos;
create table produtos(
id int not null primary key auto_increment,
nome varchar(45),
bar_code int not null,
preco decimal(7,2) not null
);
select * from produtos; 
-- Pode existir apenas um elemento com auto_increment por tabela