create database transacciones_C_Sharp;
use transacciones_C_Sharp;

create table productos(
	id				int primary key auto_increment,
    claveENA_13 	char(13) not null,
    nombre 			varchar(50) not null,
    existencia		int not null,
    precio			decimal(10,2) not null,
    descontinuado	bool default false not null,
    descripcion		text null,
    contenidoNetogr	int null
);
-- 1
insert into productos(claveENA_13, nombre, existencia, precio) values
('0123456789123', 'Galletas', 15, 20.5);
-- 2
INSERT INTO productos 
(claveENA_13, nombre, existencia, precio, descripcion, contenidoNetogr) 
VALUES 
('7501000100102', 'Gansito Marinela', 150, 18.50, 'Pastelito de chocolate con mermelada de fresa y crema.', 50);
-- 3
INSERT INTO productos 
(claveENA_13, nombre, existencia, precio, descripcion, contenidoNetogr) 
VALUES 
('7501011115303', 'Sabritas Adobadas', 200, 17.00, 'Papas fritas de maíz con sabor adobado.', 45);
-- 4
INSERT INTO productos 
(claveENA_13, nombre, existencia, precio, descripcion, contenidoNetogr) 
VALUES 
('7501055300075', 'Coca-Cola 600ml', 500, 20.00, 'Refresco de cola carbonatado no retornable.', 600);
-- 5
INSERT INTO productos 
(claveENA_13, nombre, existencia, precio, descripcion, contenidoNetogr) 
VALUES 
('7501031301013', 'Salsa Valentina Et. Amarilla', 120, 22.00, 'Salsa picante con chiles secos puya y de árbol.', 370);

select * from productos;