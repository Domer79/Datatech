use master
go

create database Datatech
go

use Datatech
go

create table AddressBook
(
	id int not null primary key identity,
	fio varchar(300) not null,
	phone varchar(50),
	email varchar(300) not null,
	unit varchar(300) not null,
	post varchar(300) not null
)
go

create unique index UQ_Email on AddressBook (email)
create unique index UQ_Unit_Post_fio on AddressBook(unit, post, fio)