--CREATE DATABASE Sklad;
--GO

--USE Sklad;
--GO
-- Создание таблицы для типов товаров
CREATE TABLE ProductTypes (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- Уникальный идентификатор типа товара
    TypeName NVARCHAR(50) NOT NULL      -- Название типа товара
);

-- Создание таблицы для поставщиков
CREATE TABLE Suppliers (
    Id INT IDENTITY(1,1) PRIMARY KEY,   -- Уникальный идентификатор поставщика
    SupplierName NVARCHAR(100) NOT NULL  -- Название поставщика
);

-- Создание таблицы для товаров
CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY,   -- Уникальный идентификатор товара
    ProductName NVARCHAR(100) NOT NULL, -- Название товара
    ProductTypeId INT NOT NULL,          -- Идентификатор типа товара
    SupplierId INT NOT NULL,              -- Идентификатор поставщика
    Quantity INT NOT NULL,                -- Количество товара
    Cost DECIMAL(10, 2) NOT NULL,        -- Себестоимость товара
    SupplyDate DATE NOT NULL,            -- Дата поставки
    FOREIGN KEY (ProductTypeId) REFERENCES ProductTypes(Id), -- Внешний ключ для типа товара
    FOREIGN KEY (SupplierId) REFERENCES Suppliers(Id)        -- Внешний ключ для поставщика
);

-- Вставка типов товаров
INSERT INTO ProductTypes (TypeName) VALUES ('Электроника');
INSERT INTO ProductTypes (TypeName) VALUES ('Книги');

-- Вставка поставщиков
INSERT INTO Suppliers (SupplierName) VALUES ('Компания А');
INSERT INTO Suppliers (SupplierName) VALUES ('Организация Б');

-- Вставка товаров
INSERT INTO Products (ProductName, ProductTypeId, SupplierId, Quantity, Cost, SupplyDate) 
VALUES ('Ноутбук', 1, 1, 50, 60000.00, '2023-10-15');

INSERT INTO Products (ProductName, ProductTypeId, SupplierId, Quantity, Cost, SupplyDate) 
VALUES ('Роман', 2, 2, 100, 500.00, '2023-10-16');
