Create Database GFT_Architecture_Exercise

go

use GFT_Architecture_Exercise


go

Create Table Employee
(
Id int primary key Not null identity(1,1),
FirstName varchar(50) Not null,
LastName varchar(50) Not null,
Email varchar(50) Not null
)

insert into Employee (FirstName,LastName,Email) values ('Carlos','Amador Gutierrez','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('Arnoldo','Arroyo Cardenas','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('David','Pastor Jiménez','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('Andrea','Castro Morales','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('Jonathan','Bravo Mora','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('Catalina','Cascante Ulate','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('Ruben','Barquero Araya','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('Rodolfo','Areas Zapata','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('Marcela','Gutierrez Campos','cag@gft.com')
insert into Employee (FirstName,LastName,Email) values ('Carla','Cortéz Corrales','cag@gft.com')
