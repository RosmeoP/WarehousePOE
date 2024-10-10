CREATE DATABASE almacenDB
GO

USE almacenDB
GO

-- tabla de categorías
CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

-- tabla de proveedores
CREATE TABLE Proveedores (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(255),
    Telefono NVARCHAR(20)
);

-- tabla de productos
CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
	Stock DECIMAL NOT NULL,
    IdCategoria INT,
	NombreCategoria INT,
    IdProveedor INT,
	NombreProveedor NVARCHAR,
    FOREIGN KEY (IdCategoria) REFERENCES Categorias(Id),
    FOREIGN KEY (IdProveedor) REFERENCES Proveedores(Id)
);

