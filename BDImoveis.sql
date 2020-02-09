create database DBImoveis
use DbImoveis
create table TB_Imovel (
	--Tabela com informações do imovel
	CodImovel int identity primary key,
	Cidade varchar(50),
	Rua varchar(50),
	Bairro varchar(50),
	Estado char(2),
	Tipo varchar(20),
	Foto1 varchar(200),
	Foto2 varchar(200),
	Foto3 varchar(200),
	Foto4 varchar(200),
	AreaT int,
	Quartos int,
	Banheiros int,
	Matricula int,
	AreaC int,
	Esp varchar(20),
	Valor money,
	TelefoneCliente varchar(9),
	Creci int,
	NomeCliente varchar(50),
	CpfCliente char (9),
	EmailCliente varchar (100),
	NomeFuncionario varchar(50),
	TelefoneFuncionario varchar(9)
)