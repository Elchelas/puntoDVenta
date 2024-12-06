create database puntoDVenta;
use puntoDVenta;

-- drop database puntoDVenta;
 -- select * from ORDENES;
 -- select * from DETALLES_ORDENES;
-- select * from CLIENTES;
-- show tables;
CREATE TABLE EMPLEADOS (
	IDempleado	VARCHAR(10)		PRIMARY KEY,	-- Es la clave propia del EMPLEADO
    CLAVE_EMP 	VARBINARY(256) 	NOT NULL,  		-- Contraseña encriptada, almacenada como datos binarios
    NOMBRE 		VARCHAR(100) 	NOT NULL,     	-- Nombre del empleado
    RANGO	 	VARCHAR(50)		NOT NULL,       -- Rango del empleado (puede variar en longitud)
    NUM_VENTAS 	INT DEFAULT 0              		-- Número de ventas con valor por defecto de 0
);

CREATE TABLE CATEGORIAS (
    IDcategoria    CHAR(4)        PRIMARY KEY,
    descripcion    VARCHAR(150)   NOT NULL,
    nombre         VARCHAR(50)    NOT NULL
);

CREATE TABLE CLIENTES(
	IDcliente char(4) primary key,
    nombre varchar(50),
    tipo_cuenta enum('Mayorista', 'Menudeo')
);

CREATE TABLE PRODUCTOS (
    IDproducto     SMALLINT       PRIMARY KEY AUTO_INCREMENT,
    nombre         VARCHAR(50)    NOT NULL,
    descripcion    VARCHAR(150)   NOT NULL,
    stock          SMALLINT       NOT NULL,
    precio         DECIMAL(10, 2) NOT NULL,    
    idCategoria    CHAR(4)        NOT NULL,
    FOREIGN KEY (IDcategoria) REFERENCES CATEGORIAS(IDcategoria)
);

CREATE TABLE ORDENES (
	IDorden		INT				primary key auto_increment,
	fecha		DATE			NOT NULL,
	total		decimal(10,2)	NOT NULL,
	idEmpleado	varchar(10) 	NOT NULL, 
    IDcliente	char(4) 		NOT NULL,
	FOREIGN KEY (idEmpleado) 	REFERENCES EMPLEADOS(IdEmpleado),
    FOREIGN KEY (IDcliente) 	REFERENCES CLIENTES(IDcliente)
);

CREATE TABLE DETALLES_ORDENES (
    IDdetalle INT PRIMARY KEY AUTO_INCREMENT,
    IDorden INT NOT NULL,
    IDproducto 	SMALLINT 		NOT NULL,
    cantidad 	INT 			NOT NULL,
    precio 		DECIMAL(10,2) 	NOT NULL,
    monto 		DECIMAL(10,2) 	NOT NULL,
    IVA 		DECIMAL(10,2) 	NOT NULL,
    subtotal 	DECIMAL(10,2) 	NOT NULL,
    FOREIGN KEY (IDorden) REFERENCES ORDENES(IDorden),
    FOREIGN KEY (IDproducto) REFERENCES PRODUCTOS(IDproducto)
);

INSERT INTO EMPLEADOS (IDempleado, CLAVE_EMP, NOMBRE, RANGO, NUM_VENTAS)
VALUES
('EMP001', SHA2('password123', 256), 'Juan Pérez', 'Gerente de Ventas', 0),
('EMP002', SHA2('ventas2024', 256), 'María López', 'Vendedor Senior', 10),
('EMP003', SHA2('claveempleado', 256), 'Carlos Gómez', 'Vendedor Junior', 4),
('EMP004', SHA2('admin2023', 256), 'Ana Martínez', 'Supervisor', 15),
('EMP005', SHA2('securepass', 256), 'Luis Fernández', 'Vendedor Senior', 8),
('EMP006', SHA2('asistente001', 256), 'Laura Sánchez', 'Asistente de Ventas', 0),
('EMP007', SHA2('trabajador07', 256), 'José Ramírez', 'Supervisor', 12),
('EMP008', SHA2('juniorvendedor', 256), 'Claudia Torres', 'Vendedor Junior', 3),
('EMP009', SHA2('empleado009', 256), 'Miguel Castillo', 'Vendedor Senior', 7),
('EMP010', SHA2('ventasglobal', 256), 'Patricia Delgado', 'Gerente de Ventas', 18),
('EMP011', SHA2('asistente011', 256), 'Rafael Ortega', 'Asistente de Ventas', 0),
('EMP012', SHA2('supervisor012', 256), 'Sofía Estrada', 'Supervisor', 11),
('EMP013', SHA2('clave013', 256), 'Andrés Morales', 'Vendedor Junior', 5),
('EMP014', SHA2('ventaspecial', 256), 'Gabriela Reyes', 'Vendedor Senior', 9),
('EMP015', SHA2('asistente015', 256), 'Ricardo Vega', 'Asistente de Ventas', 0),
('EMP016', SHA2('password123', 256), 'Pedro López', 'Vendedor', 5),
('EMP017', SHA2('abcde6789', 256), 'Laura Díaz', 'Supervisor', 12),
('EMP018', SHA2('qwerty0987', 256), 'José García', 'Vendedor', 3),
('EMP019', SHA2('securepass42', 256), 'Marta Fernández', 'Gerente', 20);


INSERT INTO CLIENTES (IDcliente, nombre, tipo_cuenta)
VALUES
('C001', 'María García', 'Mayorista'),
('C002', 'Juan Pérez', 'Menudeo'),
('C003', 'Ana López', 'Menudeo'),
('C004', 'Carlos Gómez', 'Mayorista'),
('C005', 'Laura Martínez', 'Menudeo'),
('C006', 'Luis Sánchez', 'Mayorista'),
('C007', 'Claudia Torres', 'Menudeo'),
('C008', 'Miguel Castillo', 'Mayorista'),
('C009', 'Patricia Delgado', 'Menudeo'),
('C010', 'Rafael Ortega', 'Mayorista'),
('C011', 'Sofía Estrada', 'Menudeo'),
('C012', 'Andrés Morales', 'Mayorista'),
('C013', 'Gabriela Reyes', 'Menudeo'),
('C014', 'Ricardo Vega', 'Mayorista'),
('C015', 'Sandra Ramírez', 'Menudeo'),
('C016', 'Fernando Jiménez', 'Mayorista'),
('C017', 'Monica Ortiz', 'Menudeo'),
('C018', 'Javier Hernández', 'Mayorista'),
('C019', 'Lorena Rivas', 'Menudeo'),
('C020', 'Diego Vargas', 'Mayorista'),
('C021', 'Isabel Navarro', 'Menudeo'),
('C022', 'Oscar Silva', 'Mayorista'),
('C023', 'Carmen Díaz', 'Menudeo'),
('C024', 'Hugo Mendoza', 'Mayorista'),
('C025', 'Elena Romero', 'Menudeo'),
('C026', 'Adriana Paredes', 'Mayorista'),
('C027', 'Francisco Luna', 'Menudeo'),
('C028', 'Paula Guerrero', 'Mayorista'),
('C029', 'Alberto Flores', 'Menudeo'),
('C030', 'Fátima Ruiz', 'Mayorista');


INSERT INTO CATEGORIAS (idCategoria, descripcion, nombre) VALUES
('COM1', 'Aperitivo o gosolinas de variedad', 'Snacks'),
('COM2', 'Todo tipo de bebidas ecepto alcoholicas', 'Bebidas'),
('COM3', 'Carnes o embutidos', 'Carniceria'),
('COM4', 'Todas las bebidad que contengan un grado alcoholico', 'Licoreria'),
('COM5', 'Comida de la canasta basica ', 'Canasta basica'),

('HOG1', 'Todo tipo de muebles', 'Muebles'),
('HOG2', 'Cubiertos, plateria y demas productos', 'Vajilla'),
('HOG3', 'Decoracion dentro del hogar', 'Decoracion'),
('HOG4', 'Aparatos electricos basicos', 'Electrodomésticos'),

('LIM1', 'Productos de aseo personal', 'Aseo personal'),
('LIM2', 'Limpieza dentro del hogar', 'Limpiza hogar'),
('LIM3', 'Herramientas para el aseo', 'Utencilios'),
('LIM4', 'Prodcutos para la limpieza del carro', 'Limpieza carro'),

('MAS1', 'Alimento para mascotas', 'Alimento'),
('MAS2', 'Recompenzas para mascotas', 'Premios'),
('MAS3', 'Juguetes para animales', 'Juguetes'),
('MAS4', 'Ropa especial para todo tipo de mascotas', 'Ropa'),

('REF1', 'Todo tipo de llantas para carro y moto', 'Llantas'),
('REF2', 'Piezas/refacciones varias', 'Piezas'),
('REF3', 'Liquidos basicos de los vehiculos a motor', 'Aceites y lubricantes'),
('REF4', 'Articulos varios', 'Accesorios'),

('TEC1', 'Televisores, pantallas y demas articulos audivisuales', 'Televisores'),
('TEC2', 'Laptops, torres, pc y demas', 'Computo'),
('TEC3', 'Smartphones y telefonia variada', 'Telefonia'),
('TEC4', 'Relojes inteligentes','Smartwacht');

-- Snacks (COM1)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Papas Fritas', 'Bolsa de papas fritas 200g', 1023, 2.50, 'COM1'),
('Chocolate', 'Barra de chocolate oscuro 100g', 1578, 1.75, 'COM1'),
('Galletas', 'Paquete de galletas de vainilla 300g', 1890, 2.20, 'COM1'),
('Palomitas', 'Bolsa de palomitas para microondas 100g', 1203, 1.00, 'COM1'),
('Chicles', 'Caja de chicles sabor menta', 1987, 0.80, 'COM1'),
('Caramelos', 'Paquete de caramelos surtidos', 1444, 2.50, 'COM1'),
('Pretzels', 'Bolsa de pretzels salados 250g', 1329, 3.00, 'COM1'),
('Nueces', 'Bolsa de nueces mixtas 200g', 1765, 4.50, 'COM1'),
('Churros', 'Paquete de churros dulces 300g', 1089, 2.30, 'COM1'),
('Paletas', 'Paquete de paletas de frutas', 1011, 1.99, 'COM1');

-- Bebidas (COM2)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Refresco de Cola', 'Refresco de cola 2 litros', 1198, 1.20, 'COM2'),
('Agua Mineral', 'Botella de agua mineral 500ml', 1342, 0.80, 'COM2'),
('Jugo de Naranja', 'Jugo de naranja natural 1 litro', 1576, 2.50, 'COM2'),
('Té Helado', 'Botella de té helado sabor limón', 1789, 1.50, 'COM2'),
('Cerveza 0', 'Lata de cerveza 355ml', 1934, 1.20, 'COM2'),
('Energizante', 'Bebida energética lata 250ml', 1264, 2.00, 'COM2'),
('Leche Saborizada', 'Leche con sabor a chocolate 1 litro', 1753, 1.50, 'COM2'),
('Agua Natural', 'Botella de agua natural 1 litro', 1897, 0.70, 'COM2'),
('Soda de Frutas', 'Refresco sabor frutas 1 litro', 1644, 1.00, 'COM2'),
('Cafe ole', 'Cafe ole de 350 ml', 1412, 1.00, 'COM2');

-- Carnicería (COM3)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Pollo Entero', 'Pollo entero fresco', 1399, 4.50, 'COM3'),
('Chorizo', 'Chorizo artesanal 500g', 1188, 3.20, 'COM3'),
('Carne Molida', 'Carne molida de res 1kg', 1320, 5.50, 'COM3'),
('Pechuga de Pollo', 'Pechuga de pollo sin piel 1kg', 1777, 6.00, 'COM3'),
('Salchichas', 'Paquete de salchichas 500g', 1966, 2.50, 'COM3'),
('Costillas de Cerdo', 'Costillas de cerdo frescas 1kg', 1012, 7.50, 'COM3'),
('Filete de Res', 'Filete de res selecto 1kg', 1256, 12.00, 'COM3'),
('Tocino', 'Paquete de tocino ahumado 500g', 1632, 3.99, 'COM3'),
('Pata de Pollo', 'Patas de pollo para caldo 1kg', 1507, 2.00, 'COM3'),
('Jamón', 'Paquete de jamón de pavo 500g', 1800, 3.50, 'COM3');

-- Licorería (COM4)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Vino Tinto', 'Vino tinto reserva 750ml', 1023, 15.99, 'COM4'),
('Whisky', 'Whisky 12 años 700ml', 1057, 29.99, 'COM4'),
('Tequila', 'Tequila blanco 750ml', 1111, 19.99, 'COM4'),
('Ron', 'Botella de ron añejo 750ml', 1778, 14.50, 'COM4'),
('Vodka', 'Vodka premium 1 litro', 1449, 12.99, 'COM4'),
('Cerveza Artesanal', 'Cerveza artesanal 330ml', 1122, 3.50, 'COM4'),
('Licor de Café', 'Licor de café dulce 750ml', 1276, 11.99, 'COM4'),
('Brandy', 'Brandy añejo 750ml', 1400, 13.50, 'COM4'),
('Champaña', 'Champaña premium 750ml', 1633, 25.00, 'COM4'),
('Anís', 'Botella de anís dulce 750ml', 1589, 9.99, 'COM4');

-- Canasta Básica (COM5)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Huevos', 'Cartón de 30 huevos frescos', 1234, 3.50, 'COM5'),
('Cereal Integral', 'Caja de cereal integral 500g', 1410, 2.99, 'COM5'),
('Frijoles Negros', 'Bolsa de frijoles negros 1kg', 1322, 1.80, 'COM5'),
('Lentejas', 'Bolsa de lentejas 1kg', 1911, 1.60, 'COM5'),
('Puré de Tomate', 'Lata de puré de tomate 500g', 1104, 0.99, 'COM5'),
('Atún en Lata', 'Lata de atún en agua 170g', 1203, 1.20, 'COM5'),
('Azúcar Morena', 'Bolsa de azúcar morena 1kg', 1599, 1.50, 'COM5'),
('Harina de Maíz', 'Bolsa de harina de maíz 1kg', 1654, 1.30, 'COM5'),
('Sopa Instantánea', 'Sopa instantánea sabor pollo', 1033, 0.80, 'COM5'),
('Aceite de Oliva', 'Botella de aceite de oliva extra virgen 500ml', 1177, 4.50, 'COM5');

-- Muebles (HOG1)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Mesa de Centro', 'Mesa de centro de madera', 1134, 89.99, 'HOG1'),
('Silla de Oficina', 'Silla ergonómica para oficina', 1555, 129.99, 'HOG1'),
('Librero', 'Librero de madera color caoba', 1788, 149.99, 'HOG1'),
('Cama Individual', 'Cama individual con base y colchón', 1340, 199.99, 'HOG1'),
('Armario', 'Armario de madera con puertas corredizas', 1201, 299.99, 'HOG1'),
('Escritorio', 'Escritorio para computadora', 1309, 119.99, 'HOG1'),
('Mesa de Comedor', 'Mesa de comedor para 6 personas', 1890, 249.99, 'HOG1'),
('Silla de Madera', 'Silla de madera para comedor', 1567, 49.99, 'HOG1'),
('Banco Alto', 'Banco alto para barra', 1044, 59.99, 'HOG1'),
('Sillón Reclinable', 'Sillón reclinable tapizado en cuero', 1376, 399.99, 'HOG1');

-- Vajilla (HOG2)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Platos de Porcelana', 'Juego de platos de porcelana (6 piezas)', 1991, 49.99, 'HOG2'),
('Vasos de Vidrio', 'Set de 6 vasos de vidrio templado', 1783, 19.99, 'HOG2'),
('Tazas de Café', 'Set de tazas de café con platillo', 1456, 24.99, 'HOG2'),
('Cucharas de Acero', 'Set de cucharas de acero inoxidable (12 piezas)', 1107, 14.99, 'HOG2'),
('Copas para Vino', 'Set de copas para vino tinto (4 piezas)', 1674, 29.99, 'HOG2'),
('Cuencos', 'Cuencos de cerámica para ensaladas (4 piezas)', 1345, 34.99, 'HOG2'),
('Jarra de Vidrio', 'Jarra de vidrio con tapa (1 litro)', 1212, 14.99, 'HOG2'),
('Cubiertos de Mesa', 'Set de cubiertos de acero inoxidable (24 piezas)', 1990, 39.99, 'HOG2'),
('Bandeja para Servir', 'Bandeja rectangular de madera', 1308, 19.99, 'HOG2'),
('Molde para Hornear', 'Molde de silicona para pasteles', 1255, 9.99, 'HOG2');

-- Decoración (HOG3)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Cuadros Decorativos', 'Cuadro abstracto moderno para sala', 1364, 39.99, 'HOG3'),
('Figuras Decorativas', 'Set de figuras de cerámica', 1999, 24.99, 'HOG3'),
('Lámpara Colgante', 'Lámpara colgante para comedor', 1209, 59.99, 'HOG3'),
('Candelabros', 'Candelabros metálicos de diseño vintage', 1456, 29.99, 'HOG3'),
('Espejo Decorativo', 'Espejo decorativo circular con marco dorado', 1044, 49.99, 'HOG3'),
('Jarrón de Vidrio', 'Jarrón decorativo para flores', 1700, 19.99, 'HOG3'),
('Macetas de Cerámica', 'Maceta con diseño minimalista', 1588, 14.99, 'HOG3'),
('Alfombrillas', 'Alfombrilla decorativa para entrada', 1222, 12.99, 'HOG3'),
('Reloj Vintage', 'Reloj de pared estilo vintage', 1111, 34.99, 'HOG3'),
('Estatuilla', 'Estatuilla de Buda de resina', 1344, 24.99, 'HOG3');

-- Electrodomésticos (HOG4)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Refrigerador', 'Refrigerador de dos puertas 400L', 1487, 599.99, 'HOG4'),
('Horno Microondas', 'Horno microondas de 20L', 1654, 99.99, 'HOG4'),
('Licuadora', 'Licuadora de alta potencia 1200W', 1320, 49.99, 'HOG4'),
('Tostadora', 'Tostadora para dos panes con diseño compacto', 1189, 29.99, 'HOG4'),
('Cafetera', 'Cafetera programable de 12 tazas', 1776, 89.99, 'HOG4'),
('Aspiradora', 'Aspiradora ciclónica sin bolsa', 1443, 149.99, 'HOG4'),
('Plancha', 'Plancha a vapor con función de autolimpieza', 1265, 39.99, 'HOG4'),
('Ventilador de Torre', 'Ventilador silencioso con control remoto', 1601, 69.99, 'HOG4'),
('Freidora de Aire', 'Freidora de aire 4L con pantalla digital', 1800, 99.99, 'HOG4'),
('Batidora', 'Batidora de mano con accesorios', 1211, 34.99, 'HOG4');

-- Aseo Personal (LIM1)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Champú Anticaspa', 'Champú anticaspa 500ml', 1333, 6.99, 'LIM1'),
('Gel de Ducha', 'Gel de ducha con aroma a coco 1L', 1995, 5.99, 'LIM1'),
('Pasta Dental', 'Pasta dental con flúor 150g', 1788, 2.49, 'LIM1'),
('Cepillo de Dientes', 'Cepillo de dientes suave', 1550, 1.99, 'LIM1'),
('Crema Corporal', 'Crema hidratante para piel seca 400ml', 1400, 7.99, 'LIM1'),
('Desodorante', 'Desodorante en barra aroma neutro', 1122, 4.99, 'LIM1'),
('Máquina de Afeitar', 'Máquina de afeitar desechable (3 piezas)', 1666, 3.99, 'LIM1'),
('Jabón de Manos', 'Jabón líquido para manos 500ml', 1444, 2.99, 'LIM1'),
('Toallas Húmedas', 'Paquete de toallas húmedas para rostro', 1330, 3.49, 'LIM1'),
('Protector Solar', 'Protector solar SPF 50+ 100ml', 1055, 14.99, 'LIM1');

-- Limpieza Hogar (LIM2)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Limpiador de Pisos', 'Limpiador líquido para pisos 1L', 1555, 4.49, 'LIM2'),
('Desinfectante de Superficies', 'Desinfectante para superficies 500ml', 1767, 3.99, 'LIM2'),
('Limpiador de Baño', 'Limpiador para baño con cloro 750ml', 1800, 5.99, 'LIM2'),
('Limpiador de Cocina', 'Limpiador desengrasante para cocina 500ml', 1499, 3.49, 'LIM2'),
('Esponja de Cocina', 'Esponja para lavar platos', 1320, 1.49, 'LIM2'),
('Guantes de Limpieza', 'Guantes de limpieza de látex', 1011, 2.99, 'LIM2'),
('Bicarbonato de Sodio', 'Bicarbonato de sodio para limpieza 500g', 1899, 1.99, 'LIM2'),
('Papel Higiénico', 'Papel higiénico de 12 rollos', 1444, 5.99, 'LIM2'),
('Limpiador de Vidrios', 'Limpiador de vidrios 750ml', 1676, 2.49, 'LIM2'),
('Ambientador', 'Ambientador en aerosol aroma fresco 300ml', 1303, 2.99, 'LIM2');

-- Utensilios (LIM3)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Escoba de Cocina', 'Escoba de cocina de cerdas duras', 1999, 6.99, 'LIM3'),
('Mopa', 'Mopa de microfibra para pisos', 1888, 8.99, 'LIM3'),
('Cubo para Fregar', 'Cubo de plástico con escurridor', 1104, 9.99, 'LIM3'),
('Cepillo para Baño', 'Cepillo de baño para limpieza', 1577, 2.49, 'LIM3'),
('Rastrillo', 'Rastrillo para jardín 3 dientes', 1234, 4.99, 'LIM3'),
('Palas para Basura', 'Palas plásticas para recoger basura', 1311, 3.49, 'LIM3'),
('Cinta de Embalar', 'Cinta adhesiva de embalaje 50mm', 1177, 1.99, 'LIM3'),
('Escurridor de Platos', 'Escurridor de platos de acero inoxidable', 1455, 12.99, 'LIM3'),
('Cepillo de Manos', 'Cepillo de manos para limpieza de manchas', 1988, 1.99, 'LIM3'),
('Guantes de Cocina', 'Guantes de cocina resistentes al calor', 1777, 4.49, 'LIM3');

-- Limpieza Auto (LIM4)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Limpiador de Neumáticos', 'Limpiador para neumáticos 500ml', 1476, 6.49, 'LIM4'),
('Aspiradora de Auto', 'Aspiradora portátil para auto', 1324, 39.99, 'LIM4'),
('Cera para Coche', 'Cera líquida para coche 250ml', 1590, 10.99, 'LIM4'),
('Shampoo Automotriz', 'Shampoo especial para auto 1L', 1344, 5.99, 'LIM4'),
('Limpiaparabrisas', 'Limpiaparabrisas 1L', 1455, 3.99, 'LIM4'),
('Pulidor de Coche', 'Pulidor de coche para brillo intenso', 1788, 15.99, 'LIM4'),
('Toalla de Microfibra', 'Toalla de microfibra para secado de auto', 1900, 4.99, 'LIM4'),
('Esponja para Coche', 'Esponja para lavar coche', 1333, 1.99, 'LIM4'),
('Funda para Asientos', 'Funda para asientos de auto universal', 1522, 19.99, 'LIM4'),
('Desinfectante para Auto', 'Desinfectante para interiores de auto 500ml', 1488, 7.99, 'LIM4');

-- Alimento (MAS1)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Croquetas para Perro', 'Croquetas para perro de tamaño mediano', 1634, 15.99, 'MAS1'),
('Comida Húmeda para Gato', 'Lata de comida húmeda para gatos (85g)', 1123, 1.99, 'MAS1'),
('Snacks para Perro', 'Snacks de pollo para perro', 1444, 3.49, 'MAS1'),
('Leche para Gato', 'Leche especial para gatos 500ml', 1700, 2.99, 'MAS1'),
('Alimento para Pajaritos', 'Alimento en semillas para pajaritos', 1266, 4.49, 'MAS1'),
('Galletas para Perro', 'Paquete de galletas para perro', 1588, 4.99, 'MAS1'),
('Alimento en Lata para Perro', 'Lata de alimento húmedo para perro (300g)', 1995, 2.99, 'MAS1'),
('Pescado en Conserva', 'Pescado en conserva para gato', 1550, 3.49, 'MAS1'),
('Croquetas para Cachorros', 'Croquetas para cachorros 1kg', 1877, 8.99, 'MAS1'),
('Comida Natural para Perro', 'Comida natural en bolsitas para perro', 1209, 9.99, 'MAS1');

-- Premios (MAS2)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Galletas para Gato', 'Galletas de atún para gatos', 1098, 4.49, 'MAS2'),
('Bastones de Carne', 'Bastones de carne para perros', 1311, 5.99, 'MAS2'),
('Huesos para Perro', 'Huesos comestibles para perros grandes', 1755, 7.49, 'MAS2'),
('Snacks de Pollo', 'Snacks de pollo para gatos', 1888, 3.49, 'MAS2'),
('Tetra Pak de Leche', 'Leche de almendras para perros (sin azúcar)', 1677, 3.99, 'MAS2'),
('Caramelos para Perro', 'Caramelos de frutas para perros', 1400, 2.99, 'MAS2'),
('Barras de Hueso', 'Barras de hueso natural para perros pequeños', 1204, 4.99, 'MAS2'),
('Chicles para Mascotas', 'Chicles para eliminar el mal aliento de los perros', 1901, 3.49, 'MAS2'),
('Salmón en Barra', 'Salmón deshidratado en barra para perros', 1344, 8.49, 'MAS2'),
('Snack de Pavo', 'Snack de pavo para perros pequeños', 1544, 2.49, 'MAS2');

-- Juguetes (MAS3)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Pelota de Juguete', 'Pelota de goma para perros', 1709, 5.99, 'MAS3'),
('Ratón de Juguete', 'Ratón de peluche para gatos', 1991, 3.49, 'MAS3'),
('Pluma de Juguete', 'Pluma con cuerda para juegos con gatos', 1554, 2.99, 'MAS3'),
('Rueda para Hamster', 'Rueda de ejercicio para hamsters', 1110, 6.49, 'MAS3'),
('Frisbee para Perro', 'Frisbee de plástico para perros', 1265, 4.99, 'MAS3'),
('Hueso de Juguete', 'Hueso de goma para morder perros', 1444, 5.49, 'MAS3'),
('Juguete Interactivo', 'Juguete interactivo para perros de tamaño pequeño', 1300, 8.99, 'MAS3'),
('Palo de Madera', 'Palo de madera para perros grandes', 1888, 7.49, 'MAS3'),
('Cuerda para Perro', 'Cuerda de algodón para juegos de tira y afloja', 1455, 3.99, 'MAS3'),
('Manta de Juego', 'Manta para perros de peluche', 1322, 9.49, 'MAS3');

-- Ropa (MAS4)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Chaqueta para Perro', 'Chaqueta abrigadora para perros medianos', 1789, 15.99, 'MAS4'),
('Abrigo para Gato', 'Abrigo de lana para gatos', 1401, 12.49, 'MAS4'),
('Pantalón para Perro', 'Pantalón para perros pequeños', 1323, 9.99, 'MAS4'),
('Bufanda para Mascotas', 'Bufanda de lana para perros y gatos', 1566, 4.99, 'MAS4'),
('Zapatos para Perro', 'Zapatos de protección para perros', 1990, 14.99, 'MAS4'),
('Gorra para Perro', 'Gorra de algodón para perros', 1777, 5.49, 'MAS4'),
('Pijama para Perro', 'Pijama de algodón para perros pequeños', 1444, 8.99, 'MAS4'),
('Chaqueta para Gato', 'Chaqueta de invierno para gatos', 1333, 16.99, 'MAS4'),
('Saco de Tela para Perro', 'Saco de tela para perros medianos', 1622, 18.99, 'MAS4'),
('Camiseta para Perro', 'Camiseta de algodón para perros pequeños', 1221, 7.49, 'MAS4');

-- Llantas (REF1)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Llanta 185/65R15', 'Llanta para coches de tamaño mediano, resistente a la fricción', 1888, 49.99, 'REF1'),
('Llanta 225/60R16', 'Llanta de alto rendimiento para SUV', 1100, 59.99, 'REF1'),
('Llanta 195/70R14', 'Llanta para vehículos compactos', 1599, 45.49, 'REF1'),
('Llanta 205/55R16', 'Llanta para autos deportivos y compactos', 1344, 55.99, 'REF1'),
('Llanta 255/70R18', 'Llanta para camionetas y SUV', 1555, 69.99, 'REF1'),
('Llanta 275/65R17', 'Llanta 4x4 para todoterreno', 1209, 79.49, 'REF1'),
('Llanta 215/60R17', 'Llanta para coches familiares', 1403, 52.49, 'REF1'),
('Llanta 205/45R16', 'Llanta de perfil bajo para autos deportivos', 1992, 64.99, 'REF1'),
('Llanta 265/75R16', 'Llanta todo terreno para camionetas', 1778, 74.99, 'REF1'),
('Llanta 235/55R17', 'Llanta de buena tracción para autos medianos', 1655, 59.99, 'REF1');

-- Piezas (REF2)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Filtro de Aire', 'Filtro de aire para vehículos de motor', 1322, 9.99, 'REF2'),
('Bujías', 'Bujías para motores de 4 cilindros', 1555, 5.49, 'REF2'),
('Aceite de Motor', 'Aceite sintético para motores de coches', 1400, 18.99, 'REF2'),
('Correa de Distribución', 'Correa de distribución para autos marca X', 1122, 25.99, 'REF2'),
('Pastillas de Freno', 'Pastillas de freno para coches pequeños', 1789, 12.49, 'REF2'),
('Amortiguadores', 'Amortiguadores delanteros para vehículos deportivos', 1666, 55.99, 'REF2'),
('Bomba de Agua', 'Bomba de agua para refrigeración de motor', 1323, 45.99, 'REF2'),
('Termostato de Motor', 'Termostato para el sistema de refrigeración', 1900, 10.99, 'REF2'),
('Radiador de Coche', 'Radiador de coche para enfriamiento de motor', 1234, 99.99, 'REF2'),
('Freno de Mano', 'Freno de mano para coches deportivos', 1543, 35.99, 'REF2');

-- Aceites y Lubricantes (REF3)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Aceite Motor 10W-40', 'Aceite sintético para motores de autos medianos', 1344, 19.99, 'REF3'),
('Lubricante para Cadenas', 'Lubricante para cadenas de moto', 1221, 4.99, 'REF3'),
('Aceite de Transmisión', 'Aceite para transmisión manual de vehículos', 1444, 23.49, 'REF3'),
('Aceite para Frenos', 'Aceite de frenos para vehículos', 1333, 11.49, 'REF3'),
('Lubricante para Motor', 'Lubricante para motores diésel de 4 tiempos', 1777, 28.99, 'REF3'),
('Aceite de Dirección Hidráulica', 'Aceite para sistemas hidráulicos de dirección', 1999, 15.99, 'REF3'),
('Aceite para Suspensión', 'Aceite para amortiguadores y suspensiones', 1455, 14.49, 'REF3'),
('Aceite de Transmisión Automática', 'Aceite para transmisiones automáticas', 1200, 29.99, 'REF3'),
('Lubricante para Engranajes', 'Lubricante para engranajes de maquinaria pesada', 1688, 22.49, 'REF3'),
('Aceite de Motor 5W-30', 'Aceite para motores de coches compactos', 1995, 21.49, 'REF3');

-- Accesorios (REF4)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Cargador de Coche', 'Cargador de coche con salida USB', 1233, 12.99, 'REF4'),
('Adaptador de Encendedor', 'Adaptador de encendedor para coches', 1654, 5.99, 'REF4'),
('Kit de Emergencia', 'Kit de emergencia para coches (con linterna y primeros auxilios)', 1444, 19.99, 'REF4'),
('Bomba de Aire', 'Bomba de aire portátil para inflar llantas', 1322, 15.49, 'REF4'),
('Cinta Reflectiva', 'Cinta reflectiva para vehículos de emergencia', 1555, 3.49, 'REF4'),
('Alarma para Vehículo', 'Alarma electrónica para vehículos', 1344, 45.99, 'REF4'),
('Antena de Coche', 'Antena de repuesto para coche', 1788, 8.49, 'REF4'),
('Espejo Retrovisor', 'Espejo retrovisor para coches', 1990, 18.99, 'REF4'),
('Porta Lentes de Sol', 'Porta lentes de sol para coche', 1400, 7.99, 'REF4'),
('Funda para Volante', 'Funda de cuero para volante de coche', 1221, 9.49, 'REF4');

-- Televisores (TEC1)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Smart TV 32"', 'Televisor inteligente de 32 pulgadas, 1080p', 1333, 179.99, 'TEC1'),
('Smart TV 43"', 'Smart TV 43 pulgadas, resolución 4K, HDR', 1555, 299.99, 'TEC1'),
('Televisor LED 50"', 'Televisor LED de 50 pulgadas, Full HD', 1122, 249.99, 'TEC1'),
('TV 60" QLED', 'Televisor QLED 60 pulgadas, 4K', 1888, 599.99, 'TEC1'),
('Smart TV 55"', 'Smart TV de 55 pulgadas, Ultra HD', 1777, 399.99, 'TEC1'),
('TV LED 24"', 'Televisor LED de 24 pulgadas, resolución HD', 1999, 139.99, 'TEC1'),
('Smart TV 65"', 'Smart TV de 65 pulgadas, 4K, compatible con Alexa', 1400, 799.99, 'TEC1'),
('Televisor 70"', 'Televisor 70 pulgadas, 4K UHD', 1209, 999.99, 'TEC1'),
('TV 32" LED', 'Televisor LED de 32 pulgadas con soporte para Netflix', 1666, 159.99, 'TEC1'),
('Televisor Curvo 55"', 'Televisor curvo de 55 pulgadas, 4K HDR', 1789, 599.99, 'TEC1');

-- Computo (TEC2)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Laptop Gaming', 'Laptop para juegos con procesador i7, 16GB RAM, GTX 1650', 1123, 999.99, 'TEC2'),
('Laptop Ultra-Ligera', 'Laptop ultraligera con pantalla de 13", 8GB RAM', 1550, 699.99, 'TEC2'),
('PC de Escritorio', 'PC de escritorio con procesador i5, 16GB RAM, 512GB SSD', 1403, 799.99, 'TEC2'),
('Laptop 2 en 1', 'Laptop convertible 2 en 1, 8GB RAM, 256GB SSD', 1666, 599.99, 'TEC2'),
('PC Gaming', 'PC de escritorio para gaming, con RTX 3070', 1789, 1499.99, 'TEC2'),
('Monitor 24" Full HD', 'Monitor de 24 pulgadas, resolución Full HD', 1990, 139.99, 'TEC2'),
('Mouse Gamer', 'Mouse gamer con 7 botones programables', 1222, 29.99, 'TEC2'),
('Teclado Mecánico RGB', 'Teclado mecánico con retroiluminación RGB', 1333, 49.99, 'TEC2'),
('Auriculares Bluetooth', 'Auriculares Bluetooth con cancelación de ruido', 1444, 89.99, 'TEC2'),
('Almacenamiento Externo', 'Disco duro externo de 1TB, USB 3.0', 1234, 59.99, 'TEC2');

-- Telefonía (TEC3)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Smartphone 6.5"', 'Smartphone con pantalla de 6.5", 128GB', 1444, 299.99, 'TEC3'),
('Smartphone 5.5"', 'Smartphone con pantalla de 5.5", cámara 12MP', 1333, 199.99, 'TEC3'),
('Smartphone de Gama Alta', 'Smartphone de gama alta con pantalla 6.7" y 256GB de almacenamiento', 1888, 799.99, 'TEC3'),
('Smartphone Plegable', 'Smartphone plegable con pantalla OLED', 1555, 1399.99, 'TEC3'),
('Smartphone 4G', 'Smartphone 4G, pantalla 6", cámara de 16MP', 1995, 249.99, 'TEC3'),
('Smartphone Económico', 'Smartphone con pantalla 6", 64GB de almacenamiento', 1222, 149.99, 'TEC3'),
('Cargador Solar', 'Cargador solar para smartphones', 1444, 34.99, 'TEC3'),
('Auriculares Bluetooth', 'Auriculares inalámbricos con micrófono incorporado', 1233, 59.99, 'TEC3'),
('Soporte de Teléfono', 'Soporte para smartphone ajustable y portátil', 1344, 15.49, 'TEC3'),
('Power Bank', 'Batería externa de 10000mAh', 1666, 25.99, 'TEC3');

-- Smart Watch (TEC4)
INSERT INTO PRODUCTOS (nombre, descripcion, stock, precio, idCategoria) VALUES
('Smartwatch Deportivo', 'Smartwatch con monitor de ritmo cardíaco y GPS', 1322, 99.99, 'TEC4'),
('Smartwatch de Lujo', 'Smartwatch de lujo con pantalla AMOLED y cuero', 1555, 199.99, 'TEC4'),
('Smartwatch para Niños', 'Smartwatch para niños con cámara y localizador GPS', 1777, 49.99, 'TEC4'),
('Smartwatch con Alexa', 'Smartwatch con asistente Alexa integrado', 1990, 129.99, 'TEC4'),
('Reloj Inteligente', 'Reloj inteligente con notificaciones y resistencia al agua', 1666, 59.99, 'TEC4'),
('Smartwatch Deportivo', 'Smartwatch con funciones de ejercicio y resistencia al agua', 1550, 79.99, 'TEC4'),
('Smartwatch con NFC', 'Smartwatch con tecnología NFC para pagos', 1888, 149.99, 'TEC4'),
('Smartwatch 4G', 'Smartwatch con conectividad 4G para llamadas y mensajes', 1444, 199.99, 'TEC4'),
('Smartwatch para Fitness', 'Smartwatch enfocado en el seguimiento de actividad física', 1209, 89.99, 'TEC4'),
('Smartwatch Ultra-Ligero', 'Smartwatch ultra-ligero con monitoreo de salud 24/7', 1344, 69.99, 'TEC4');


-- De aqui en adelante sigue todo lo relacionado con los triggers y demas cuestiones
-- El primero de ellos es el encargado de limitar el hecho de poder comprar mas producto de lo habido en el stock.
-- 1
delimiter //
 CREATE TRIGGER stock_limite
BEFORE INSERT ON DETALLES_ORDENES
FOR EACH ROW
BEGIN
    -- Variable para el stock actual del producto
    DECLARE cantidad INT;

    -- Obtén el stock actual del producto
    SELECT stock 
    INTO cantidad
    FROM PRODUCTOS
    WHERE IDproducto = NEW.IDproducto;

    -- Verifica si la cantidad pedida excede el stock disponible
    IF cantidad < NEW.cantidad THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'No hay suficiente stock disponible para realizar esta venta.';
    ELSE
        -- Actualiza el stock del producto
        UPDATE PRODUCTOS
        SET stock = stock - NEW.cantidad
        WHERE IDproducto = NEW.IDproducto;
    END IF;
END;
//
delimiter ;

-- Nuestros siguientes procesos son los encargados de la parte de INSERT, UPDATE y DROP de los clientes.
-- El que (insertar).
delimiter //
CREATE PROCEDURE nuevo_cliente(
	-- Atributos con los cuales se trabaja
    IN IDcliente char(4),
	IN nombre VARCHAR(50),
    IN tipo_cuenta enum('Mayorista', 'Menudeo')
)
BEGIN
	-- Creamos la insercion de los datos anteriores
	INSERT INTO clientes (IDcliente, nombre, tipo_cuenta)
    VALUES(IDcliente, nombre, tipo_cuenta);
END //

-- El que (borra).
CREATE PROCEDURE goodbye(
	-- varible del proceso
	IN v_IDcliente CHAR(4)
)
BEGIN
	-- En dado caso de que si este en cliente en la base.
    IF EXISTS (SELECT 1 FROM clientes WHERE IDcliente = v_IDcliente) THEN
		-- Lo borra
        DELETE FROM CLIENTES
		WHERE IDcliente = v_IDcliente;
	-- En caso contratio se cancela la expulsion de nuestro noble supermercado.
	ELSE
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'No esta dentro de nuestra base el cliente seleccionado.';
	END IF;
END //

-- Ahora el que actua cuado se quiere (actualizar).
CREATE PROCEDURE cliente_actualizado(
    IN v_IDcliente CHAR(4),
    IN v_nombre VARCHAR(50),
    IN v_tipo_cuenta ENUM('Mayorista', 'Menudeo')
)
BEGIN
    -- Verificamos que exista el cliente
    IF EXISTS (SELECT 1 FROM CLIENTES WHERE IDcliente = v_IDcliente) THEN
        -- Actualizar solo el registro que coincide con el IDcliente
        UPDATE CLIENTES
        SET nombre = v_nombre, tipo_cuenta = v_tipo_cuenta
        WHERE IDcliente = v_IDcliente;
    ELSE
        -- En caso de no estar, se lanza un error
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'No está dentro de nuestra base el cliente seleccionado.';
    END IF;
END //

-- 2
-- procedure de ventas aleatorias.

DELIMITER //
CREATE PROCEDURE ordenesAleatorias(
    IN n INT
)
BEGIN
    DECLARE i INT DEFAULT 1;
    DECLARE j INT;
    
    DECLARE id_cliente CHAR(4);
    DECLARE id_empleado VARCHAR(10);
    DECLARE id_producto SMALLINT;
    DECLARE id_v INT;
    
    DECLARE cantdet INT;
    DECLARE subtot_v DECIMAL(10, 2);
    DECLARE tot_v DECIMAL(10, 2);
    DECLARE fech DATE;
    DECLARE cantidad INT;
    DECLARE preciox DECIMAL(10, 2);
    DECLARE precio_base DECIMAL(10, 2);
    DECLARE iva DECIMAL(10, 2);
    
    DECLARE repetido INT;
    DECLARE producto_valido INT;

    WHILE i <= n DO
        SET id_cliente = (SELECT IDcliente FROM CLIENTES ORDER BY RAND() LIMIT 1);
        SET id_empleado = (SELECT idEmpleado FROM EMPLEADOS ORDER BY RAND() LIMIT 1);
        SET cantdet = FLOOR(RAND() * (10 - 1 + 1)) + 1;
        SET id_v = (
            SELECT CASE
                WHEN (SELECT COUNT(*) FROM ORDENES) = 0 THEN 1
                ELSE (SELECT MAX(IDorden) FROM ORDENES)
            END
        ) + 1;

        SET subtot_v = 0;
        SET tot_v = 0;

        SET foreign_key_checks = 0;

        SET j = 1;
        WHILE j <= cantdet DO
            SET id_producto = (SELECT IDproducto FROM PRODUCTOS ORDER BY RAND() LIMIT 1);
            SET repetido = (SELECT COUNT(*) FROM DETALLES_ORDENES WHERE IDorden = id_v AND IDproducto = id_producto);

            IF repetido = 0 THEN
                -- Validar si el producto existe
                SET producto_valido = (SELECT COUNT(*) FROM PRODUCTOS WHERE IDproducto = id_producto);
                
                IF producto_valido > 0 THEN
                    SET cantidad = FLOOR(RAND() * (10 - 1 + 1)) + 1;
                    SET preciox = (SELECT precio FROM PRODUCTOS WHERE IDproducto = id_producto);
                    SET iva = preciox * 0.16;

                    INSERT INTO DETALLES_ORDENES(IDorden, IDproducto, cantidad, precio, IVA, monto, subtotal) 
                    VALUES(id_v, id_producto, cantidad, preciox, iva, (preciox * cantidad), (preciox * cantidad));

                    SET precio_base = cantidad * preciox;
                    SET subtot_v = subtot_v + precio_base; 
                    SET tot_v = subtot_v + (subtot_v * 0.16);

                    SET j = j + 1;
                END IF;
            END IF;
        END WHILE;

        SET foreign_key_checks = 1;

        INSERT INTO ORDENES(idEmpleado, IDcliente, total, fecha) 
        VALUES(id_empleado, id_cliente, tot_v, (SELECT DATE_ADD(CONCAT(floor(2020 + (RAND() * 6)), '-01-01'), INTERVAL FLOOR(RAND() * 366) DAY)));

        SET i = i + 1;
    END WHILE;
END;
//
DELIMITER ;

-- 3
-- Madamos llamar el metodo para cargar la base, y esto de 450 en 450, para no trabar la compu
call ordenesAleatorias(450);
-- call ordenesAleatorias(450);
-- call ordenesAleatorias(450);
-- call ordenesAleatorias(450);
select * from RegistroDeVentasPorTrimestre;


-- 4.- REPORTE DE VENTAS POR MES (FOLIO, FECHA, CLIENTE, EMPLEADO, TOTAL, CANTIDAD DE VENTAS HECHAS)
CREATE VIEW reporteDeVentasAlAnio AS
	SELECT o.IDorden AS Folio, o.fecha, c.nombre AS cliente, e.NOMBRE AS empleado, o.total, COUNT(dv.IDdetalle) AS cantidad_ventas
	FROM ORDENES o JOIN CLIENTES c ON o.IDcliente = c.IDcliente
	JOIN EMPLEADOS e ON o.idEmpleado = e.IDempleado
	JOIN DETALLES_ORDENES dv ON o.IDorden = dv.IDorden
	GROUP BY o.IDorden, o.fecha, c.nombre, e.NOMBRE, o.total;

-- 5.- REPORTE DE VENTAS POR EMPLEADO (NOMBRE, TOTAL, CANTIDADVENTAS)
create view ReporteVentasEmpleado as
	select e.nombre, sum(o.total) as total, count(*) as ventas
    from empleados e join ordenes o
    on e.IDempleado = o.idEmpleado
    group by e.nombre;

-- 6 las ventas consuntadas trimestralmente

CREATE VIEW RegistroDeVentasPorTrimestre AS
SELECT p.nombre AS Producto,
    COALESCE(SUM(
        CASE 
            WHEN MONTH(o.fecha) BETWEEN 1 AND 3 THEN dv.cantidad
            ELSE 0 
        END), 0) AS Trim_1,
    COALESCE(SUM(
        CASE 
            WHEN MONTH(o.fecha) BETWEEN 4 AND 6 THEN dv.cantidad
            ELSE 0 
        END), 0) AS Trim_2,
    COALESCE(SUM(
        CASE 
            WHEN MONTH(o.fecha) BETWEEN 7 AND 9 THEN dv.cantidad
            ELSE 0 
        END), 0) AS Trim_3,
    COALESCE(SUM(
        CASE 
            WHEN MONTH(o.fecha) BETWEEN 10 AND 12 THEN dv.cantidad
            ELSE 0 
        END), 0) AS Trim_4
FROM 
    PRODUCTOS p
LEFT JOIN 
    DETALLES_ORDENES dv ON p.IDproducto = dv.IDproducto
LEFT JOIN 
    ORDENES o ON dv.IDorden = o.IDorden
GROUP BY 
    p.nombre;

-- Importante la division de cada uno de los trimestres por medio de cada 3 meses como se ve representado
-- En cada una de las condicionales. y the last one
-- SE USA EL COALSESCE EN CASO DE QUE UN PRODUCTO NO HAYA SIDO VENDIDO NINGUNA VEZ EN EL AÑO, PARA MOSTRAR TODOS SUS RESULTADOS EN 0 Y QUE APAREZCA SU RENGLON.
    -- SE USA UN LEFT JOIN PARA QUE SE TOMEN EN CUANTA LOS RENGLONES DE LOS PRODUCTOS QUE NO TIENEN CONEXION CON NINGUN RENGLON EN LA TABLA DETALLES_VENTA.
    -- TODO SE AGRUPA POR EL NOMBRE DEL PRODUCTO. bueno igual estos comentarios del chadma estan bien

-- 7. tabla donde se va guardar todo lo de los triggers
CREATE TABLE ORNEDES_INFO(
	id 				INT PRIMARY KEY auto_increment,
    accion 			ENUM('INSERT', 'UPDATE', 'DELETE') NOT NULL,
    usuario 		VARCHAR(255),
    fecha 			TIMESTAMP DEFAULT current_timestamp,
    datos_OLD 		TEXT,
    datos_NEW		TEXT
);

-- drop trigger actualiza_ordenes;

delimiter //
-- El que cuida el (insert)

CREATE TRIGGER nuevas_ordenes
AFTER INSERT ON ORDENES
FOR EACH ROW
BEGIN 
    DECLARE usuario_empleado VARCHAR(255);
    
    -- Obtener el nombre del empleado
    SELECT nombre INTO usuario_empleado FROM EMPLEADOS 
    WHERE IDempleado = NEW.IDempleado;

    -- Insertar la información en ORNEDES_INFO
    INSERT INTO ORNEDES_INFO(accion, usuario, fecha, datos_OLD, datos_NEW)
    VALUES('INSERT',usuario_empleado, CURRENT_TIMESTAMP,'',
        CONCAT("IDorden: ", NEW.IDorden, ", IDempleado: ", NEW.IDempleado, ", IDcliente: ", NEW.IDcliente, ", Fecha: ", NEW.fecha, ", Total: ", NEW.total));
END //

-- El que cuida lo (borrado)
CREATE TRIGGER cuello_ordenes
AFTER DELETE ON ORDENES
FOR EACH ROW
BEGIN 
INSERT INTO ORNEDES_INFO(accion, usuario, datos_OLD)
    VALUES('DELETE', (SELECT nombre FROM EMPLEADOS WHERE IDempleado = OLD.IDempleado), 
	concat("IDorden: ", old.IDorden,"IDempleado: ", old.IDempleado, ", IDcliente: ", old.IDcliente, ", Fecha: ", old.fecha,", Total: ", old.total));
END //

-- El que cuida lo (actualizado)
CREATE TRIGGER actualiza_ordenes
AFTER UPDATE ON ORDENES
FOR EACH ROW
BEGIN 
	INSERT INTO ORNEDES_INFO(accion, usuario, datos_OLD, datos_NEW)
    VALUES('UPDATE', (SELECT nombre FROM EMPLEADOS WHERE IDempleado = NEW.IDempleado), 
	concat("IDorden: ", OLD.IDorden, "IDempleado: ", OLD.IDempleado, ", IDcliente: ", OLD.IDcliente, ", Fecha: ", OLD.fecha,", Total: ", OLD.total),
		concat("IDorden: ", NEW.IDorden,"IDempleado: ", NEW.IDempleado, ", IDcliente: ", new.IDcliente, ", Fecha: ", new.fecha,", Total: ", NEW.total));
END //

-- 8 Triggers de la tabla productos.
CREATE TRIGGER nuevos_productos
	BEFORE INSERT ON PRODUCTOS
    FOR EACH ROW
    BEGIN
		-- La encargada de que tener precio positivo
		IF new.precio <= 0 THEN
			SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'El precio no puede ser negativo (Por amor de dios consentrese).';
		
        -- SEGUNDA VALIDACION
		ELSEIF length(trim(NEW.nombre)) = 0 THEN
			SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT = 'No se puede llamar '              ', piensale mi chavo.';
		END IF;
        
        -- ESTAREMOS TRABAJANDO CON UN BEFORE, PARA VALIDAR LA INSERCION PRIMERO, Y CON NEW PORQUE SE VALIDA LA FILA NUEVA ANTES DE INSERTARLA EN LA TABLA
    END //

-- 9.- Me da el numero de productos que se compran en cada venta

-- cuenta los no duplicados
CREATE FUNCTION cantidad_de_productos(id INT)
RETURNS INT
DETERMINISTIC
BEGIN
	DECLARE detalles INT;
    
    SET detalles = (SELECT count(*) FROM DETALLES_ORDENES
					WHERE IDorden = id);
	RETURN detalles;
END //

-- cuenta todos
CREATE FUNCTION cantidad_de_productos_full(id INT)
RETURNS INT
DETERMINISTIC
BEGIN
	DECLARE detalles INT;
    
    SET detalles = (SELECT sum(cantidad) FROM DETALLES_ORDENES
					WHERE IDorden = id);
	RETURN detalles;
END //
delimiter ;

-- select cantidad_de_productos_full(2);