CREATE DATABASE BPMS
GO

USE BPMS
GO

﻿CREATE TABLE Book
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên' ,
	amount INT NOT NULL DEFAULT 0,
	price FLOAT DEFAULT 0,
	type NVARCHAR(100) NOT NULL DEFAULT N'Chưa có thể loại',
	author NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tác giả'
)
GO

CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	UserName NVARCHAR(100),
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Admin',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	type INT NOT NULL DEFAULT 0,
	address NVARCHAR(100) NOT NULL DEFAULT N'Chưa có địa chỉ'
)
GO


CREATE TABLE Publisher
(
	id INT IDENTITY PRIMARY KEY,
	idAccount INT NOT NULL,
	AccountNumber NVARCHAR(100) NOT NULL DEFAULT N'Chưa có số tài khoản',
	PhoneNumber NVARCHAR(100) NOT NULL DEFAULT N'Chưa có số điện thoại',
	FOREIGN KEY (idAccount) REFERENCES dbo.Account(id)
)
GO

CREATE TABLE Accountant
(
	id INT IDENTITY PRIMARY KEY,
	idAccount INT NOT NULL,
	AccountNumber NVARCHAR(100) NOT NULL DEFAULT N'Chưa có số tài khoản',
	PhoneNumber NVARCHAR(100) NOT NULL DEFAULT N'Chưa có số điện thoại',
	FOREIGN KEY (idAccount) REFERENCES dbo.Account(id)
)
GO

CREATE TABLE Agency
(
	id INT IDENTITY PRIMARY KEY,
	idAccount INT NOT NULL,
	debt FLOAT NOT NULL DEFAULT 0,
	BookReceived INT, --1: true, 0: false
	PaidMoney INT, --1: true, 0: false
	FOREIGN KEY (idAccount) REFERENCES dbo.Account(id)
)
GO

CREATE TABLE DeliveryReport
(
	id INT IDENTITY PRIMARY KEY,
	idAgency INT NOT NULL,
	DeliveryDate DATETIME NOT NULL DEFAULT GETDATE(),
	DeliveryPerson NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người giao',
	UnitLeader NVARCHAR(100) NOT NULL DEFAULT N'Chưa có thủ trưởng',
	FOREIGN KEY (idAgency) REFERENCES dbo.Agency(id)
)
GO

CREATE TABLE ReceiptReport
(
	id INT IDENTITY PRIMARY KEY,
	idPublisher INT NOT NULL,
	ReceiptDate DATETIME NOT NULL DEFAULT GETDATE(),
	ReceiptPerson NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người nhận',
	FOREIGN KEY (idPublisher) REFERENCES dbo.Publisher(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	idReceiver INT NOT NULL,
	idSender INT NOT NULL,
	ReceiptDate DATETIME NOT NULL DEFAULT GETDATE(),
	ReceiptPerson NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người nhận',
	isPaid INT, --1: đã trả, 0: chưa trả 
	isReceived INT, --1: đã nhận, 0: chưa nhận 
	FOREIGN KEY (idReceiver) REFERENCES dbo.Account(id),
	FOREIGN KEY (idSender) REFERENCES dbo.Account(id)
)
GO


INSERT INTO DeliveryReport (idAgency, DeliveryDate, DeliveryPerson, UnitLeader) VALUES (1, '11/05/2023', N'Nguyễn Văn A', N'Trương Hoàng B')
INSERT INTO DeliveryReport (idAgency, DeliveryDate, DeliveryPerson, UnitLeader) VALUES (2, '12/05/2023', N'Nguyễn Văn B', N'Hoàng Đức C')
INSERT INTO DeliveryReport (idAgency, DeliveryDate, DeliveryPerson, UnitLeader) VALUES (3, '10/05/2023', N'Nguyễn Văn C', N'Trương Hoàng A')
INSERT INTO DeliveryReport (idAgency, DeliveryDate, DeliveryPerson, UnitLeader) VALUES (4, '19/05/2023', N'Nguyễn Văn A', N'Hoàng Đức C')
INSERT INTO DeliveryReport (idAgency, DeliveryDate, DeliveryPerson, UnitLeader) VALUES (2, '04/05/2023', N'Nguyễn Văn B', N'Hoàng Đức C')
GO

INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('Admin', 'Admin', 'AD', 1, 'a')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('FHS', N'Fahasa', 'DL', 0, 'c')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('PN', N'Phương Nam Book City', 'DL', 0, 'd')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('MK', N'Minh Khai', 'DL', 0, 'e')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('VL', N'Văn Lang', 'DL', 0, 'f')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('NVC', N'Nguyễn Văn Cừ', 'DL', 0, 'g')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('KD', N'Kim Đồng', 'NXB', 0, 'b')
GO

INSERT INTO Agency (idAccount, debt, BookReceived, PaidMoney) VALUES ()

SELECT * FROM Account
SELECT * FROM Agency
SELECT * FROM DeliveryReport
