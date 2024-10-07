
USE almacenDB
GO
-- INSERTAR VARIAS CATEGORIAS
INSERT INTO Categorias (Nombre)
VALUES ('Electrónica'),
       ('Ropa'),
	   ('Cocina'),
	   ('Coches'),
	   ('Tegnologia'),
       ('Muebles');


-- INSERTAR VARIOS PROVEEDORES
INSERT INTO Proveedores (Nombre, Direccion, Telefono)
VALUES ('Proveedor A', 'Calle Falsa 123', '1234567890'),
	   ('Proveedor B', 'Calle 13', '837657876'),
       ('Proveedor C', 'Avenida Siempreviva 742', '0987654321');


-- INSERTAR UN PROVEEDOR
INSERT INTO Proveedores (Nombre, Direccion, Telefono)
VALUES ('Comercial Luz', 'XDXD', '99999');


-- INSERTAR VARIOS PRODUCTOS 
INSERT INTO Productos (Nombre, Precio, Stock, IdCategoria, IdProveedor)
VALUES ('Smartphone', 499.99, 50, 1, 1),  -- Producto de la categoría 1 y proveedor 1
       ('Camiseta', 19.99, 200, 2, 2),   -- Producto de la categoría 2 y proveedor 2
       ('Sofá', 899.50, 10, 3, 1);       -- Producto de la categoría 3 y proveedor 1


-- INSERTAR UN PRODUCTO 
INSERT INTO Productos (Nombre, Precio, Stock, IdCategoria, IdProveedor)
VALUES ('Laptop', 500, 4, 5, 4);  -- Producto de la categoría 5 y proveedor 4