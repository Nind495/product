--************Создание таблиц***************
create table client (idclient int PRIMARY KEY IDENTITY (1,1), firstname nvarchar(255) ,lastname nvarchar(255));
create table product (idproduct int PRIMARY KEY IDENTITY (1,1),name nvarchar(255), expiration_date datetime);
create table sale (idsale int PRIMARY KEY IDENTITY (1,1),
	datasale TimeStamp,
	client_id int ,
	product_id int,
	rn_ktk bigint,
	CONSTRAINT  fk_idclient FOREIGN  key (client_id) references client (idclient),
	CONSTRAINT fk_idproduct FOREIGN  key (product_id) references  product (idproduct));
--***************************наполнение Client*********************8
use BaseDevice;
insert client  (firstname,lastname) values ('Иванов', 'Иван');
insert client  (firstname,lastname) values ('Петров', 'Иван');
insert client  (firstname,lastname) values ('Сидоров', 'Андрей');
insert client  (firstname,lastname) values ('Test', 'Test');

--****************************наполнение product **************8
insert product (name,expiration_date) values ('Хлеб','2009-06-04 18:25:08');
insert product (name,expiration_date) values ('Молоко','2014-06-05 19:25:08');
insert product (name,expiration_date) values ('Колбаса','2015-01-05 16:25:08');
--*****************************Наполение sale ********************* 
insert into sale (datasale,client_id,product_id,rn_ktk) select null,idclient,idproduct,123123123 from client,product where idclient=1 and idproduct= 3;
insert into sale (datasale,client_id,product_id,rn_ktk) select null,idclient,idproduct,123123123 from client,product where idclient=2 and idproduct= 2;
insert into sale (datasale,client_id,product_id,rn_ktk) select null,idclient,idproduct,123123123 from client,product where idclient=3 and idproduct= 1;
select * from sale



select * from sale
select * from client
select * from client,product where idclient=1 and idproduct=4
delete from sale





