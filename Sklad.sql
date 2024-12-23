--CREATE DATABASE Sklad;
--GO

--USE Sklad;
--GO
-- �������� ������� ��� ����� �������
CREATE TABLE ProductTypes (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- ���������� ������������� ���� ������
    TypeName NVARCHAR(50) NOT NULL      -- �������� ���� ������
);

-- �������� ������� ��� �����������
CREATE TABLE Suppliers (
    Id INT IDENTITY(1,1) PRIMARY KEY,   -- ���������� ������������� ����������
    SupplierName NVARCHAR(100) NOT NULL  -- �������� ����������
);

-- �������� ������� ��� �������
CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,   -- ���������� ������������� ������
    ProductName NVARCHAR(100) NOT NULL, -- �������� ������
    ProductTypeId INT NOT NULL,          -- ������������� ���� ������
    SupplierId INT NOT NULL,              -- ������������� ����������
    Quantity INT NOT NULL,                -- ���������� ������
    Cost DECIMAL(10, 2) NOT NULL,        -- ������������� ������
    SupplyDate DATE NOT NULL,            -- ���� ��������
    FOREIGN KEY (ProductTypeId) REFERENCES ProductTypes(Id), -- ������� ���� ��� ���� ������
    FOREIGN KEY (SupplierId) REFERENCES Suppliers(Id)        -- ������� ���� ��� ����������
);

-- ������� ����� �������
INSERT INTO ProductTypes (TypeName) VALUES ('�����������');
INSERT INTO ProductTypes (TypeName) VALUES ('�����');

-- ������� �����������
INSERT INTO Suppliers (SupplierName) VALUES ('�������� �');
INSERT INTO Suppliers (SupplierName) VALUES ('����������� �');

-- ������� �������
INSERT INTO Products (ProductName, ProductTypeId, SupplierId, Quantity, Cost, SupplyDate) 
VALUES ('�������', 1, 1, 50, 60000.00, '2023-10-15');

INSERT INTO Products (ProductName, ProductTypeId, SupplierId, Quantity, Cost, SupplyDate) 
VALUES ('�����', 2, 2, 100, 500.00, '2023-10-16');
