USE almacenDB
GO
-- INSERTAR VARIAS CATEGORIAS
INSERT INTO Categorias (Nombre)
VALUES ('Electronica'),
       ('Ropa'),
	   ('Cocina'),
	   ('Coches'),
	   ('Tegnologia'),
       ('Muebles');


-- INSERTAR VARIOS PROVEEDORES
INSERT INTO Proveedores (Nombre, Direccion, Telefono)
VALUES ('Comercial Mauricio', 'Calle 123', '1234567890'),
	   ('Comercial Ana', 'Calle 13', '837657876'),
       ('Tienda Elim', 'Avenida Siempreviva 742', '0987654321');


-- INSERTAR UN PROVEEDOR
INSERT INTO Proveedores (Nombre, Direccion, Telefono)
VALUES ('Comercial Luz', 'calle esquina', '99999');


-- INSERTAR VARIOS PRODUCTOS 
INSERT INTO Productos (Nombre, Precio, Stock, IdCategoria, IdProveedor)
VALUES ('Smartphone', 499.99, 50, 1, 1),  -- Producto de la categoria 1 y proveedor 1
       ('Camiseta', 19.99, 200, 2, 2),   -- Producto de lacategoria 2 y proveedor 2
       ('Sofa', 899.50, 10, 3, 1);       -- Producto de la categoria 3 y proveedor 1


-- INSERTAR UN PRODUCTO 
INSERT INTO Productos (Nombre, Precio, Stock, IdCategoria, IdProveedor)
VALUES ('Laptop', 500, 4, 5, 4);  -- Producto de la categoria 5 y proveedor 4