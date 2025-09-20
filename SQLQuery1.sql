use UCE

create table usuario(
id int primary key identity,
NombreUsuario varchar(50) not null,
clave varchar(50) not null
)

insert into usuario(NombreUsuario, clave) values ('admin','123')