CREATE DATABASE BPMS
GO

USE BPMS
GO

CREATE TABLE Book
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	type NVARCHAR(100) NOT NULL DEFAULT N'Chưa có thể loại',
	author NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tác giả',
	price FLOAT DEFAULT 0,
	isHidden INT DEFAULT 0
)
GO


CREATE TABLE Account
(
	id INT IDENTITY PRIMARY KEY,
	UserName NVARCHAR(100),
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Admin',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	type INT NOT NULL DEFAULT 0,
	address NVARCHAR(100) NOT NULL DEFAULT N'Chưa có địa chỉ',
	isHidden INT DEFAULT 0
)
GO


CREATE TABLE Publisher
(
	id INT IDENTITY PRIMARY KEY,
	idAccount INT NOT NULL,
	AccountNumber NVARCHAR(100) NOT NULL DEFAULT N'Chưa có số tài khoản',
	PhoneNumber NVARCHAR(100) NOT NULL DEFAULT N'Chưa có số điện thoại',
	FOREIGN KEY (idAccount) REFERENCES dbo.Account(id),
	isHidden INT DEFAULT 0
)
GO


CREATE TABLE Accountant
(
	id INT IDENTITY PRIMARY KEY,
	idAccount INT NOT NULL,
	AccountNumber NVARCHAR(100) NOT NULL DEFAULT N'Chưa có số tài khoản',
	PhoneNumber NVARCHAR(100) NOT NULL DEFAULT N'Chưa có số điện thoại',
	FOREIGN KEY (idAccount) REFERENCES dbo.Account(id),
	isHidden INT DEFAULT 0
)
GO

CREATE TABLE Agency
(
	id INT IDENTITY PRIMARY KEY,
	idAccount INT NOT NULL,
	debt FLOAT NOT NULL DEFAULT 0,
	BookReceived INT, --1: true, 0: false
	PaidMoney INT, --1: true, 0: false
	FOREIGN KEY (idAccount) REFERENCES dbo.Account(id),
	isHidden INT DEFAULT 0
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	Receiver NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người nhận',
	Sender NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người gửi',
	CreateDate DATETIME NOT NULL DEFAULT GETDATE(),
	idCreatePerson INT NOT NULL,
	isPaid INT, --1: đã trả, 0: chưa trả 
	isReceived INT, --1: đã nhận, 0: chưa nhận 
	FOREIGN KEY (idCreatePerson) REFERENCES dbo.Account(id)
)
GO

CREATE TABLE ExportReport
(
	id INT IDENTITY PRIMARY KEY,
	idAgency INT NOT NULL,
	idBill INT,
	ReceiptPerson NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người nhận',
	ExportDate DATETIME NOT NULL DEFAULT GETDATE(),
	TotalPrice FLOAT NOT NULL DEFAULT 0,
	FOREIGN KEY (idAgency) REFERENCES dbo.Agency(id),
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id)
)
GO



CREATE TABLE ExportReportDetail
(
	id INT IDENTITY PRIMARY KEY,
	idBook INT NOT NULL,
	idExport INT NOT NULL,
	quantity INT NOT NULL,
	quality NVARCHAR(100) NOT NULL DEFAULT N'Chưa đạt yêu cầu',--Đạt yêu cầu, Chưa đạt yêu cầu
	FOREIGN KEY (idBook) REFERENCES dbo.Book(id),
	FOREIGN KEY (idExport) REFERENCES dbo.ExportReport(id)
)
GO


CREATE TABLE ImportReport
(
	id INT IDENTITY PRIMARY KEY,
	idPublisher INT NOT NULL,
	idBill INT,
	DeliveryPerson NVARCHAR(100) NOT NULL DEFAULT N'Chưa có người giao',
	ImportDate DATETIME NOT NULL DEFAULT GETDATE(),
	UnitLeader NVARCHAR(100) NOT NULL DEFAULT N'Chưa có thủ trưởng',
	TotalPrice FLOAT NOT NULL DEFAULT 0,
	FOREIGN KEY (idPublisher) REFERENCES dbo.Publisher(id),
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id)
)
GO

CREATE TABLE ImportReportDetail
(
	id INT IDENTITY PRIMARY KEY,
	idBook INT NOT NULL,
	idImport INT NOT NULL,
	quantity INT NOT NULL,
	quality NVARCHAR(100) NOT NULL DEFAULT N'Chưa đạt yêu cầu',--Đạt yêu cầu, Chưa đạt yêu cầu
	FOREIGN KEY (idBook) REFERENCES dbo.Book(id),
	FOREIGN KEY (idImport) REFERENCES dbo.ImportReport(id)
)
GO



INSERT INTO Book (name, type, author, price) VALUES (N'Nhà Giả Kim', 'Tiểu thuyết', N'Paulo Coelho', 50000)
INSERT INTO Book (name, type, author, price) VALUES (N'Đắc nhân tâm', 'Self Help', N'Dale Carnegie', 75000)
INSERT INTO Book (name, type, author, price) VALUES (N'Bố Già', 'Novel', N'Mario Puzo', 250000)
INSERT INTO Book (name, type, author, price) VALUES (N'Cuộc sống không giới hạn', 'Self Help', N'Nick Vujicic', 25000)
INSERT INTO Book (name, type, author, price) VALUES (N'Tuổi trẻ đáng giá bao nhiêu', 'Self Help', N'Rosie Nguyen', 25000)
GO

INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('Admin', 'Admin', 'AD', 0, 'a')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('FHS', N'Fahasa', 'DL', 4, 'c')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('PN', N'Phương Nam Book City', 'DL', 4, 'd')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('MK', N'Minh Khai', 'DL', 4, 'e')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('VL', N'Văn Lang', 'DL', 4, 'f')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('NVC', N'Nguyễn Văn Cừ', 'DL', 4, 'g')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('KD', N'Kim Đồng', 'NXB', 3, 'b')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('LD', N'Lao Động', 'NXB', 3, 'd')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('NN', N'Nhã Nam', 'NXB', 3, 's')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('PN', N'Phụ nữ Việt Nam', 'NXB', 3, 'b')
INSERT INTO Account (UserName, DisplayName, PassWord, type, address) VALUES ('DA', N'Đông A', 'NXB', 3, 'l')
GO

INSERT INTO Agency (idAccount, debt, BookReceived, PaidMoney) VALUES (2, 2000000,1,0)
INSERT INTO Agency (idAccount, debt, BookReceived, PaidMoney) VALUES (3, 3800000,1,0)
INSERT INTO Agency (idAccount, debt, BookReceived, PaidMoney) VALUES (4, 1500000,0,0)
INSERT INTO Agency (idAccount, debt, BookReceived, PaidMoney) VALUES (5, 0,1,1)
INSERT INTO Agency (idAccount, debt, BookReceived, PaidMoney) VALUES (6, 0,0,1)
GO


INSERT INTO Publisher (idAccount, AccountNumber, PhoneNumber) VALUES (7, '87654427282', '0988765432')
INSERT INTO Publisher (idAccount, AccountNumber, PhoneNumber) VALUES (8, '37185808328', '0804165833')
INSERT INTO Publisher (idAccount, AccountNumber, PhoneNumber) VALUES (9, '57530201136', '0331993578')
INSERT INTO Publisher (idAccount, AccountNumber, PhoneNumber) VALUES (10, '35452033514', '0294557750')
INSERT INTO Publisher (idAccount, AccountNumber, PhoneNumber) VALUES (11, '71596496195', '0382758627')
GO


INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (1, '11/05/2023', N'Nguyễn Văn A', N'Trương Hoàng B')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (2, '12/05/2023', N'Trương Hoàng B', N'Hoàng Đức C')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (3, '10/05/2023', N'Nguyễn Văn C', N'Trương Hoàng A')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (4, '12/05/2023', N'Trương Hoàng D', N'Hoàng Đức C')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (2, '04/05/2023', N'Nguyễn Văn E', N'Hoàng Đức S')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (5, '01/05/2023', N'Hoàng Đức F', N'Hoàng Đức F')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (2, '02/07/2023', N'Nguyễn Văn S', N'Hoàng Đức E')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (3, '03/08/2023', N'Nguyễn Văn B', N'Hoàng Đức R')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (4, '05/05/2023', N'Hoàng Đức C', N'Hoàng Đức A')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (5, '04/02/2023', N'Nguyễn Văn A', N'Hoàng Đức S')
INSERT INTO ImportReport (idPublisher, ImportDate, DeliveryPerson, UnitLeader) VALUES (1, '08/01/2023', N'Nguyễn Văn D', N'Trương Hoàng B')
GO

INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (1, '05/05/2023', N'Nguyễn Văn A')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (2, '11/02/2023', N'Trương Hoàng B')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (3, '10/20/2023', N'Nguyễn Văn C')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (4, '12/24/2023', N'Trương Hoàng S')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (2, '04/13/2023', N'Nguyễn Văn E')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (5, '02/15/2023', N'Trương Hoàng B')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (2, '03/27/2023', N'Nguyễn Văn S')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (3, '09/08/2023', N'Hoàng Đức F')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (4, '02/01/2023', N'Hoàng Đức A')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (5, '12/20/2023', N'Nguyễn Văn A')
INSERT INTO ExportReport (idAgency, ExportDate, ReceiptPerson) VALUES (1, '02/01/2023', N'Hoàng Đức S')
GO

INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (1, 10, 1, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (2, 15, 1, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (3, 11, 1, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (1, 10, 2, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (2, 10, 2, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (3, 10, 2, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (1, 10, 3, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (2, 10, 3, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (3, 10, 3, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (1, 10, 4, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (2, 10, 4, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (3, 10, 4, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (1, 10, 5, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (2, 10, 5, N'Đạt yêu cầu')
INSERT INTO ImportReportDetail (idBook, quantity, idImport, quality) VALUES (3, 10, 5, N'Đạt yêu cầu')
GO

INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (1, 10, 1, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (2, 15, 1, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (3, 13, 1, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (1, 10, 2, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (2, 10, 2, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (3, 10, 2, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (1, 10, 3, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (2, 10, 3, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (3, 10, 3, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (1, 10, 4, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (2, 10, 4, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (3, 10, 4, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (1, 10, 5, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (2, 10, 5, N'Đạt yêu cầu')
INSERT INTO ExportReportDetail (idBook, quantity, idExport, quality) VALUES (3, 10, 5, N'Đạt yêu cầu')
GO



SELECT * FROM Account
SELECT * FROM Agency
SELECT * FROM Publisher
SELECT * FROM ImportReport
SELECT * FROM ExportReport
GO