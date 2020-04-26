USE TSQLV4;

DROP TABLE IF EXISTS dbo.kpopCustomers;

CREATE TABLE dbo.kpopCustomers
(
  customerID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_kpopCustomers PRIMARY KEY,
  fName VARCHAR(20) NOT NULL,
  lName VARCHAR(20) NOT NULL,
  address VARCHAR(20) NOT NULL,
  city VARCHAR (10) NOT NULL,
  state VARCHAR (5) NOT NULL,
  zipcode VARCHAR(10) NOT NULL,
  phone VARCHAR (20) NOT NULL,
  email VARCHAR (20) NOT NULL
);

INSERT INTO dbo.kpopCustomers(fName, lName, address, city, state, zipcode, phone, email)
  VALUES('Denis', 'Licona', '10 Bainbridge Ct', 'Stafford', 'VA', '22556', '540-940-9867', 'denysoph@gmail.com');

select * from dbo.kpopCustomers

DROP TABLE IF EXISTS dbo.kpopProduct_Details;

create table dbo.kpopProduct_Details
(
    productID INT NOT NULL identity(1000, 1)
    CONSTRAINT PK_kpopProduct_Details PRIMARY KEY,
    customerID INT NOT NULL,
  batter VARCHAR(20) NOT NULL,
  frosting VARCHAR(20) NOT NULL,
  drizzle VARCHAR(20),
  sprinkles VARCHAR(20),
   CONSTRAINT FK_kpopProduct_Details FOREIGN KEY(customerID)
    REFERENCES dbo.kpopCustomers(customerID)
  )

INSERT INTO dbo.kpopProduct_Details(customerID, batter, frosting, drizzle)
  VALUES(1, 'Vanilla', 'White', 'Red, White, and Blue');

select * from dbo.kpopProduct_Details;

DROP TABLE IF EXISTS dbo.kpopOrders;

create table dbo.kpopOrders
(
    orderID INT NOT NULL identity(10000, 1)
    CONSTRAINT PK_kpopOrders PRIMARY KEY,
    productID INT NOT NULL,
  quantity int NOT NULL,
  orderdate date NOT NULL,
  deliveryDate date NOT NULL,
  Total money NOT NULL,
   CONSTRAINT FK_kpopOrders FOREIGN KEY(productID)
    REFERENCES dbo.kpopProduct_Details(productID)
)
INSERT INTO dbo.kpopOrders(productID, quantity, orderdate, deliveryDate, Total)
  VALUES(1000, 24, '02-19-2020', '03-06-2020', '36');

select * from kpopOrders;

DROP TABLE IF EXISTS dbo.kpopCompany;

create table dbo.kpopCompany
(
    companyID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_kpopCompany PRIMARY KEY,
    paymentID INT NOT NULL,
  Contactname varchar(20) NOT NULL,
  phone varchar(20) NOT NULL,
  email varchar(50) NOT NULL,
  address varchar(20) NOT NULL,
  city varchar(20) NOT NULL,
  state varchar(20) NOT NULL,
  zipcode varchar(20) NOT NULL
)
select * from dbo.kpopCompany;

DROP TABLE IF EXISTS dbo.kpopPayment;

create table dbo.kpopPayment
(
    paymentID INT NOT NULL identity(1, 1)
    CONSTRAINT PK_kpopPayment PRIMARY KEY,
    companyID INT NOT NULL,
    paymentdate date NOT NULL,
    amount money NOT NULL,
    CONSTRAINT FK_kpopPayment FOREIGN KEY(companyID)
    REFERENCES dbo.kpopCompany(companyID)
)
select * from dbo.kpoppayment

ALTER TABLE dbo.kpopcompany
add constraint FK_kpopCompany FOREIGN KEY (paymentID)
references dbo.kpopPayment(paymentID);

select * from kpopCustomers;
select * from kpopProduct_Details;
select * from kpopOrders;
select * from kpopCompany;
select * from kpopPayment;


ALTER TABLE dbo.kpopPayment
add orderID INT not null,
constraint FK_kpopPayment2 FOREIGN KEY (orderID)
references dbo.kpopOrders(orderID);

INSERT INTO dbo.kpopPayment (paymentdate, amount, orderID)
values ('2-19-2020', '36', 10000);

select * from kpopPayment;

INSERT INTO dbo.kpopCompany (paymentID, Contactname, phone, email, address, city, state,zipcode)
values (3, 'Carlos Soto', '858-405-9163', 'sotokpops@gmail.com', '123 St Davis Dr', 'Stafford', 'VA', '22556');

select * from dbo.kpopCompany;
