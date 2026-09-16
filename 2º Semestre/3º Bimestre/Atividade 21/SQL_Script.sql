--Criação de tabelas
CREATE TABLE professores 
( 
ID_PROFESSOR INT IDENTITY(1,1) PRIMARY KEY NOT NULL , 
NOME_PROFESSOR VARCHAR(50)  NOT NULL, 
EMAIL_PROFESSOR VARCHAR(100) NOT NULL, 
); 
CREATE TABLE usuario 
( 
ID_USUARIO INT IDENTITY(1,1) PRIMARY KEY NOT NULL , 
NOME_USUARIO VARCHAR(50) NOT NULL, 
EMAIL_USUARIO VARCHAR(100) NOT NULL, 
SENHA_USUARIO VARCHAR(6) NOT NULL,
);


--Inserts
insert into professores (NOME_PROFESSOR,EMAIL_PROFESSOR)  
values ('DENILCE','denilce@gmail.com'); 
insert into professores values ( 'ANGELICA ','angelica@gmail.com'); 
insert into professores values ( 'JEFFERSON','jefferson@gmail.com'); 
insert into professores (nome_professor, email_professor) values 
('CRISTIANE','cris@gmail.com'); 