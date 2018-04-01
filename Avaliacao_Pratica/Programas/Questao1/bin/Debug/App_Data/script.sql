drop table if exists SalesOrders;
drop table if exists Users;

create table Users(id integer primary key, 
name varchar(50) not null);

insert into Users(id, name) values (1, 'Ricardo Takemura');
insert into Users(id, name) values (2, 'Test');

create table SalesOrders(salesOrderNumber varchar(5) primary key, 
totalValue number(10,2) not null, 
itensCount integer not null, 
userId integer not null, 
foreign key (userId) references Users(id));

insert into SalesOrders(salesOrderNumber, totalValue, itensCount, userId) values ('00001',120.15, 2, 1);
insert into SalesOrders(salesOrderNumber, totalValue, itensCount, userId) values ('00002',1.02, 7, 1);
insert into SalesOrders(salesOrderNumber, totalValue, itensCount, userId) values ('00003',98.91, 12, 1);
insert into SalesOrders(salesOrderNumber, totalValue, itensCount, userId) values ('00004',19.15, 2, 1);
insert into SalesOrders(salesOrderNumber, totalValue, itensCount, userId) values ('00005',29.12, 4, 2);
insert into SalesOrders(salesOrderNumber, totalValue, itensCount, userId) values ('00006',28.28, 5, 2);