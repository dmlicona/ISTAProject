use AkaPopsDb;

DROP TABLE IF EXISTS dbo.batter;

CREATE TABLE dbo.batter
(
  BatterID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_batter PRIMARY KEY,
  batterType VARCHAR(20) NOT NULL,
);

select * from batter;

INSERT INTO dbo.batter(batterType)
  VALUES('Chocolate');

 INSERT INTO dbo.batter(batterType)
  VALUES('Vanilla');

  DROP TABLE IF EXISTS dbo.frosting;

  CREATE TABLE dbo.frosting
(
  FrostingID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_frosting PRIMARY KEY,
  frostingName VARCHAR(20) NOT NULL,
);

select * from frosting;

 INSERT INTO dbo.frosting(frostingName)
  VALUES('Turquoize') 
   INSERT INTO dbo.frosting(frostingName)
  VALUES('Orange') 
   INSERT INTO dbo.frosting(frostingName)
  VALUES('Pink') 
   INSERT INTO dbo.frosting(frostingName)
  VALUES('Black') 
   INSERT INTO dbo.frosting(frostingName)
  VALUES('Vibrant Green') 
  INSERT INTO dbo.frosting(frostingName)
  VALUES('Lavender') 
   INSERT INTO dbo.frosting(frostingName)
  VALUES('Red') 
  INSERT INTO dbo.frosting(frostingName)
  VALUES('Royal Blue') 
  INSERT INTO dbo.frosting(frostingName)
  VALUES('Yellow') 

DROP TABLE IF EXISTS dbo.drizzle;

  CREATE TABLE dbo.drizzle
(
  drizzleID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_drizzle PRIMARY KEY,
  drizzleName VARCHAR(20) NOT NULL,
);

select * from drizzle;

 INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Turquoize') 
   INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Orange') 
   INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Pink') 
   INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Black') 
   INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Vibrant Green') 
  INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Lavender') 
   INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Red') 
  INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Royal Blue') 
  INSERT INTO dbo.drizzle(drizzleName)
  VALUES('Yellow') 

DROP TABLE IF EXISTS dbo.sprikles;

  CREATE TABLE dbo.sprinkles
(
  sprinklesID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_sprinkles PRIMARY KEY,
  sprinklesName VARCHAR(20) NOT NULL,
);

select * from sprinkles;
INSERT INTO dbo.sprinkles(sprinklesName)
  VALUES('Purple Pony Party') 

insert into dbo.sprinkles(sprinklesName)
values('Roller Disco')

insert into dbo.sprinkles(sprinklesName)
values('Little Blue')

insert into dbo.sprinkles(sprinklesName)
values('Hop Scotch')

insert into dbo.sprinkles(sprinklesName)
values('LoL Sprinkle')

select * from dbo.kpopOrders;
select * from Customers;

DROP TABLE IF EXISTS dbo.kpoOrders;

  CREATE TABLE dbo.orders
(
  ordersID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_orders PRIMARY KEY,
    customerID int not null,
    constraint FK_Customers Foreign key(customerID)
    references Customers(customerID)
    );

    select * from orders

    select * from Customers;
    select * from kpopProduct_Details;
    select * from kpopPayment
    select * from kpopOrders
    select * from kpopCompany

select * from orders;
select * from Customers;

CREATE TABLE dbo.orderDetails
(
  ordersID INT NOT NULL,
    constraint FK_Orders Foreign key(ordersID)
    references Orders(ordersID),
    batterID int not null,
    constraint FK_batter foreign key(batterID)
    references batter(batterID),
    drizzleID int not null,
    constraint FK_drizzle foreign key(drizzleID)
    references drizzle(drizzleID),
    frostingID int not null,
    constraint FK_frosting foreign key(frostingID)
    references frosting(frostingID),
    sprinklesID int not null,
    constraint FK_sprinkles foreign key(sprinklesID)
    references sprinkles(sprinklesID),
    dozenPrice money not null,
    qty smallint not null
    );

DROP TABLE IF EXISTS dbo.Orders;
select * from Customers;
  CREATE TABLE dbo.orders
(
  ordersID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_orders PRIMARY KEY,
    customerID int not null,
    constraint FK_customers Foreign key(customerID)
    references Customers(customerID)
    );

select * from orders

alter table orders
add customerID int not null,
constraint FK_customers foreign key(customerID)
references customers(customerID)

alter table orderdetails
drop column ordersID;

alter table orderdetails
add ordersID int not null,
constraint FK_orders foreign key(ordersID)
references orders(ordersID);

select * from orderDetails;

DROP TABLE IF EXISTS dbo.orderDetails;

CREATE TABLE dbo.orderDetails
(
  ordersID INT NOT NULL,
    constraint FK_orders foreign key(ordersID)
references orders(ordersID),
    batterID int not null,
    constraint FK_batter foreign key(batterID)
    references batter(batterID),
    drizzleID int not null,
    constraint FK_drizzle foreign key(drizzleID)
    references drizzle(drizzleID),
    frostingID int not null,
    constraint FK_frosting foreign key(frostingID)
    references frosting(frostingID),
    sprinklesID int not null,
    constraint FK_sprinkles foreign key(sprinklesID)
    references sprinkles(sprinklesID),
    dozenPrice money not null,
    qty smallint not null
    );

    select * from orderDetails

