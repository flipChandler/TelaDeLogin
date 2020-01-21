# Tela de Login em C#
### Tela de Login (Usuário e Senha) na arquitetura MVC, desenvolvido em C# e SGBD MySQL
### Login Screen (User and Password) in MVC architecture, developed in C # and MySQL DBMS
#### rodar esse script no MySQL

create database projeto_1;
use projeto_1;
 
create table login(
id int primary key auto_increment,
usuario varchar(50),
senha varchar(100));
 
insert into login values(default, "admin", "123456");
