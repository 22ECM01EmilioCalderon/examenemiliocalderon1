create database Producto2;
use producto2;
create table perfumes(
id int not null identity,
nombre varchar(50) not null,
precio decimal(6,2),
stock float,
);
create table loginapp(
username varchar(50)not null,
passsword varchar (50)not null,
);
insert into loginapp values ('DonBosco','2025');
select*from loginapp;
select*from perfumes;