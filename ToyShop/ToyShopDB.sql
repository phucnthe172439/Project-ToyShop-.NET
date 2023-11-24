drop database ToyShopDB;
create database ToyShopDB;

use ToyShopDB;

-- Create Categories table
CREATE TABLE categories (
    categoryid INT PRIMARY KEY,
    name VARCHAR(100)
);

-- Create Toys table
CREATE TABLE toys (
    toyid INT not null identity(1,1)  PRIMARY KEY,
    name VARCHAR(100) not null,
    description VARCHAR(500),
	image varbinary(MAX),
    price DECIMAL(10, 2) not null,
    quantity INT,
	categoryid int not null,
	foreign key(categoryid) references categories(categoryid)
);

-- Create Customers table
CREATE TABLE users (
    userid INT not null identity(1,1) PRIMARY KEY,
    nickname varchar(100) not null,
    email VARCHAR(100) not null,
    password VARCHAR(100) not null,
    address VARCHAR(200),
    postalcode VARCHAR(20),
    country VARCHAR(100),
	roleid int not null
);

-- Create Orders table
CREATE TABLE orders (
    orderid INT PRIMARY KEY,
    userid INT,
    orderdate DATE,
    totalamount DECIMAL(10, 2),
    FOREIGN KEY (userid) REFERENCES users(userid)
);

-- Create OrderItems table
CREATE TABLE orderitems (
    orderitemid INT PRIMARY KEY,
    orderid INT,
    toyid INT,
    quantity INT,
    unitprice DECIMAL(10, 2),
    FOREIGN KEY (orderid) REFERENCES orders(orderid),
    FOREIGN KEY (toyid) REFERENCES toys(toyid)
);

insert into users(nickname, email, password, address, postalcode, country, roleid)
values('Phuc Nguyen','phucnthe172439@gmail.com','songngu1','Tien Hai, Thai Binh',06000, 'Vietnam',1);
insert into users(nickname, email, password, address, postalcode, country, roleid)
values('Phuc User','user@gmail.com','songngu1','Tien Hai, Thai Binh',06000, 'Vietnam',0);

insert into categories(categoryid,name)
values(1,'Boys');
insert into categories(categoryid,name)
values(2,'Girls');
insert into categories(categoryid,name)
values(3,'Figures');
insert into categories(categoryid,name)
values(4,'Teddy Bears');

insert into toys(name, description, price, quantity, categoryid)
values('Gengar','A pokemon evolved from Haunter, which is a ghost Type.',200000,1,4);
insert into toys(name, description, price, quantity, categoryid)
values('Pikachu','A pokemon evolved from Pichu, which is an Electric Type.',250000,2,4);
