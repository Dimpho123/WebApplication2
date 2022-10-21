create database website;
use website

CREATE TABLE userinfo2(
						email VARCHAR(40) NOT NULL,
                        Password varchar(40) not null)
                        
                        
CREATE TABLE MoneyDonations(money_id VARCHAR(8) PRIMARY KEY,
						date date,
						Amount VARCHAR(30) )
                        
                        
                        
CREATE TABLE goods(GOODS_ID VARCHAR(8) PRIMARY KEY,
						DATE date,
						Number_of_items int NOT NULL,
                        Category varchar(40) not null,
                        Description_of_each_item varchar(40) not null) 

CREATE TABLE Disaster(Disaster_ID VARCHAR(8) PRIMARY KEY,
						StartDATE date,
						EndDATE date,
						Location varchar (40) NOT NULL,
                        Description varchar(40) not null,
                       Aid_Types varchar(40) not null) 



INSERT INTO userinfo2 VALUES('Di@gmail.com','abcd')
INSERT INTO userinfo VALUES('Mo@gmail.com','abcd12')
INSERT INTO userinfo VALUES('linda@gmail.com','1234567')

INSERT INTO MoneyDonations VALUES('S1','18/October/2022','R1250')
INSERT INTO MoneyDonations VALUES('S2','3/November/2022','R5000')
INSERT INTO MoneyDonations VALUES('S3','24/December/2022','R2500')

INSERT INTO goods VALUES('1','20/September/2022',3,'Clothes', 'Hats')
INSERT INTO goods VALUES('2','11/October/2022',10,'Food', 'Tinned food')
INSERT INTO goods VALUES('3','18/December/2022',5,'Toiletries', 'Sanitary towels')


INSERT INTO Disaster VALUES('1','20/September/2022','20/October/2022','Pretoria', 'Water pipe', 'Water provision')
INSERT INTO Disaster VALUES('3','18/December/2022','21/October/2022','Mamelodi', 'Raining', 'Clothes')


select * from MoneyDonations;
select * from userinfo;
select * from goods;
select * from Disaster;
