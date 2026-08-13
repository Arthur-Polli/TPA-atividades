create database db_curso;
use db_curso;

create table tb_curso(
id_curso int primary key,
nm_curso varchar(45) not null,
cargahoraria_curso int not null,
valor_curso int not null
);