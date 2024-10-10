CREATE DATABASE QuanLySanPham;

USE QuanLySanPham;

CREATE TABLE Catalog 
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	CatalogCode NVARCHAR(50),
	CatalogName NVARCHAR(250)
)

CREATE TABLE Product
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	CatalogId INT,
	ProductCode NVARCHAR(50),
	ProductName NVARCHAR(250),
	Picture NVARCHAR(MAX),
	UnitPrice FLOAT
)

ALTER TABLE Product 
ADD CONSTRAINT FK_PC FOREIGN KEY (CatalogID) REFERENCES Catalog(Id)

INSERT INTO Catalog(CatalogCode, CatalogName)
VALUES
('DM01', N'Điện Thoại'),
('DM02',N'Máy Tính'),
('DM03', N'Thời Trang'),
('DM04', N'Gia Dụng'),
('CAT113',N'Hàng Cháy Nổ')

INSERT INTO Product(CatalogId, ProductCode, ProductName, Picture, UnitPrice)
VALUES
(1,'PRO01', 'SamSung J7', 'PRO01.PNG', 10000000),
(1, 'PRO02', 'Iphone X', 'PRO02.PNG', 30000000),
(2, 'PRO03', 'Dell Inspiron 15', 'PRO03.PNG', 12000000),
(2, 'PRO4', 'Dell Inspiron 16', 'PRO04.PNG', 13000000),
(2, 'PRO05', 'Acer AS A315', 'PRO05.PNG', 9000000)
