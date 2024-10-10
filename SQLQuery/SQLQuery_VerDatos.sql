
-- MOSTRAR TODAS LAS TABLAS
SELECT * FROM Categorias;
SELECT * FROM Proveedores;
SELECT * FROM Productos;

SELECT 
	p.Id AS Id,
    p.Nombre AS Producto,
    p.Precio,
    p.Stock,
    c.Nombre AS Categoria,
	c.Id AS CategoriaId,
    pr.Nombre AS Proveedor,
    pr.Id AS ProveedorId
FROM Productos p
JOIN Categorias c ON p.IdCategoria = c.Id
JOIN Proveedores pr ON p.IdProveedor = pr.Id;