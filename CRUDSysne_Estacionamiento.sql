create database CRUDSysne_EstacionamientoDataBase;
go
use CRUDSysne_EstacionamientoDataBase;
go
create table Autos
(
	id_auto smallint identity primary key,
	matricula_auto varchar(14) not null,
	tipo_auto varchar(20) not null,
	Nombre_Conductor varchar(20) not null
);
