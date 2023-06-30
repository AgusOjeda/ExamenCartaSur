create database CartaSur;

use CartaSur;

CREATE TABLE ventas(
	ID_VENTA int not null identity,
	Fecha_venta datetime,
	Dni_cliente varchar(100),
	Nombre_empleado varchar(100),
	Nombre_cliente varchar(100),
	Importe_total decimal(10,2),
	Direccion_envio_cliente varchar(100),
	Direccion_sucursal_venta varchar(100),
	Nombre_sucursal_venta varchar(100),
	Producto varchar(20),
	Cantidad int,
	PRIMARY KEY(ID_VENTA)
);

INSERT INTO ventas (Fecha_venta, Dni_cliente, Nombre_empleado, Nombre_cliente, Importe_total, Direccion_envio_cliente, Direccion_sucursal_venta, Nombre_sucursal_venta, Producto, Cantidad)
VALUES 
('2023-06-21', '42363376', 'John Doe', 'Agustin', 24023.34, 'Calchaqui 2230, Quilmes Oeste, Buenos Aires', 'Solis 1025, CABA', 'Sede Principal', 'Camisetas', 6),
('2023-06-24', '38932948', 'John Doe', 'Ezequiel', 209353.8, 'Mexico 2280, Ezpeleta Oeste, Buenos Aires', 'Av. Hipolito Yrigoyen 8562, Lomas de Zamora, Buenos Aires', 'Sede Lomas de Zamora', 'Pantalones', 60),
('2023-06-24', '14093403', 'John Doe', 'Facundo', 12011.67, 'Paula Albarracin 4566, Quilmes Oeste, Buenos Aires', 'Lavalle 663, Quilmes', 'Sede Quilmes', 'Camisetas', 3),
('2023-06-28', '79857345', 'John Doe', 'Luis', 60058.35, 'Calchaqui 1231, Quilmes Oeste, Buenos Aires', 'Solis 1025, CABA', 'Sede Principal', 'Camisetas', 15),
('2023-06-28', '43840120', 'John Doe', 'Patricia', 6000.53, 'Cariboni 3200, Florencio Varela, Buenos Aires', 'Lavalle 663, Quilmes', 'Sede Quilmes', 'Shorts', 2),
('2023-06-28', '41261367', 'John Doe', 'Gabriela', 36979.34, 'Trinvirato 2400, Quilmes, Buenos Aires', 'Solis 1025, CABA', 'Sede Principal', 'Conjuntos', 4);


SELECT TOP 1 Fecha_venta, Count(*) as Total_ventas FROM ventas GROUP BY Fecha_venta ORDER BY Total_ventas DESC;