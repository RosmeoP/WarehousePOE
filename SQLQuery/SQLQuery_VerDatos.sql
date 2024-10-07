
-- MOSTRAR TODAS LAS TABLAS
SELECT * FROM Categorias;
SELECT * FROM Proveedores;
SELECT * FROM Productos;

-- MOSTRAR TABLA PRODUCTOS
SELECT 
    p.Nombre AS Producto,
    p.Precio,
    p.Stock,
    c.Nombre AS Categoria,
    pr.Nombre AS Proveedor
FROM Productos p
JOIN Categorias c ON p.IdCategoria = c.Id
JOIN Proveedores pr ON p.IdProveedor = pr.Id;
