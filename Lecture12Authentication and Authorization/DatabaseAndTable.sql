-- for create databse
create database authente


-- for use database
use authente
-- for create table 
create table info2(
-- identity auto increment primary key not null
Id int identity(4210134,2) primary key not null,
Name nvarchar(50),
Email nvarchar(50),
CurrentPassword  nvarchar(50),
ComparedPassword nvarchar(50),
)
select *from  info2



