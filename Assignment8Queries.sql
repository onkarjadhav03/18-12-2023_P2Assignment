create database Day8AsignDb

use Day8AsignDb

create table Products(
Pid nvarchar(10) primary key,
Pname nvarchar(20) not null,
Pprice float not null,
MnfDate date not null,
ExpDate date not null)

insert into Products values('P0001','Laptop',50000,'10/20/2019','05/09/2090')


insert into Products values('P0002','Mobile',58000,'10/20/2019','05/09/2090')
insert into Products values('P0003','Laptop',60000,'11/02/2015','05/09/2050')
insert into Products values('P0004','Earphones',1000,'05/03/2020','03/11/2026')
insert into Products values('P0005','Mobile',90000,'10/20/2017','05/09/2024')
insert into Products values('P0006','Tablet',32000,'01/01/2022','05/16/2030')
insert into Products values('P0007','Laptop',40000,'05/30/2015','04/19/2045')
insert into Products values('P0008','Earphones',900,'02/20/2023','09/09/2095')
insert into Products values('P0009','Laptop',75000,'10/29/2013','12/17/2070')
insert into Products values('P0010','Mobile',19000,'10/18/2021','05/27/2039')

select * from Products

