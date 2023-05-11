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
	idPublisher INT NOT NULL,
	DeliveryDate DATETIME NOT NULL DEFAULT GETDATE(),
	DeliveryPerson NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người giao',
	UnitLeader NVARCHAR(100) NOT NULL DEFAULT N'Chưa có thủ trưởng',
	FOREIGN KEY (idPublisher) REFERENCES dbo.Publisher(id)
)
GO

CREATE TABLE ReceiptReport
(
	id INT IDENTITY PRIMARY KEY,
	idAgency INT NOT NULL,
	ReceiptDate DATETIME NOT NULL DEFAULT GETDATE(),
	ReceiptPerson NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người nhận',
	FOREIGN KEY (idAgency) REFERENCES dbo.Agency(id)
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
