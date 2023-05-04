create database dbagenda20231;
use dbagenda20231;

create table tuser
(
idUser char(36) not null,
firstName varchar(70) not null,
surName varchar(40) not null,
email varchar(100) not null,
password varchar(700) not null,
registerDate datetime not null,
updatedDate datetime not null,
primary key(idUser)
);

create table tcity
(
idCity char(36) not null,
name varchar(100) not null,
registerDate datetime not null,
updatedDate datetime not null,
primary key(idCity)
);

create table tperson
(
idPerson char(36) not null,
idUser char(36) not null,
idCity char(36) not null,
firstName varchar(70) not null,
surName varchar(40) not null,
phone varchar(20) not null,
email varchar(100) null,
registerDate datetime not null,
updatedDate datetime not null,
foreign key(idUser) references tuser(idUser),
foreign key(idCity) references tcity(idCity),
primary key(idPerson)
);