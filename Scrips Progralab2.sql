Create database CineDB24689123;
go
Use CineDB24689123;
go

-- Tabla cines
CREATE TABLE cines (
    codigo_cine INT PRIMARY KEY,
    nombre_cine VARCHAR(255),
    localidad VARCHAR(255)
);

-- Tabla categorias
CREATE TABLE categorias (
    codigo_categoria INT PRIMARY KEY,
    descripcion VARCHAR(255)
);

-- Tabla clasificaciones
CREATE TABLE clasificaciones (
    codigo_clasificacion INT PRIMARY KEY,
    descripcion VARCHAR(255)
);

-- Tabla formatos
CREATE TABLE formatos (
    id_formato INT PRIMARY KEY,
    descripcion VARCHAR(255)
);

-- Tabla formas_pago
CREATE TABLE formas_pago (
    id_forma INT PRIMARY KEY,
    descripcion VARCHAR(255)
);

-- Tabla clientes
CREATE TABLE clientes (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nom_cliente VARCHAR(255),
    apellido_cliente VARCHAR(255),
    telefono VARCHAR(20),
    email VARCHAR(255)
);

-- Tabla facturas
CREATE TABLE TicketFactura (
    id_factura INT Identity (1,1)PRIMARY KEY,
    fecha DATE,
    id_cliente INT,
    CONSTRAINT FK_Facturas_Clientes FOREIGN KEY (id_cliente) REFERENCES clientes(id_cliente)
);
-- Tabla estados

CREATE TABLE estados (
    id_estado INT PRIMARY KEY,
    descripcion VARCHAR(255)
);

-- Tabla detalles_pagos
CREATE TABLE detalles_pagos (
    id_detalle_pago INT IDENTITY(1,1) PRIMARY KEY,
    id_factura INT,
    id_forma INT,
    FOREIGN KEY (id_factura) REFERENCES TicketFactura(id_factura),
    FOREIGN KEY (id_forma) REFERENCES formas_pago(id_forma)
);
-- Tabla salas
CREATE TABLE salas (
    id_sala INT PRIMARY KEY,
    cantidad_butaca INT,
    codigo_cine INT,
    Constraint FK_Salas_cod_cine FOREIGN KEY (codigo_cine) REFERENCES cines(codigo_cine)
);

-- Tabla peliculas
CREATE TABLE peliculas (
    codigo_pelicula INT PRIMARY KEY,
    nombre_pelicula VARCHAR(255),
    codigo_cine INT,
    codigo_fecha INT,
    fecha_inicio DATE,
    fecha_final DATE,
    director VARCHAR(255),
    codigo_categoria INT,
    codigo_clasificacion INT,
    codigo_formato INT,
    FOREIGN KEY (codigo_cine) REFERENCES cines(codigo_cine),
    FOREIGN KEY (codigo_categoria) REFERENCES categorias(codigo_categoria),
    FOREIGN KEY (codigo_clasificacion) REFERENCES clasificaciones(codigo_clasificacion),
    FOREIGN KEY (codigo_formato) REFERENCES formatos(id_formato)
);

-- Tabla butacas
CREATE TABLE butacas (
    id_butaca INT PRIMARY KEY,
    codigo_funcion INT,
    id_estado INT,
    descripcion VARCHAR(255),
    id_sala INT,
    --FOREIGN KEY (codigo_funcion) REFERENCES funciones(codigo_funcion),
    --FOREIGN KEY (id_estado) REFERENCES estados(id_estado),
    --FOREIGN KEY (id_sala) REFERENCES salas(id_sala)
);
-- Tabla funciones
CREATE TABLE funciones (
    codigo_funcion INT IDENTITY(1,1) PRIMARY KEY,
    descripcion VARCHAR(255),
    codigo_pelicula INT,
    fecha DATE,
    hora TIME,
    precio DECIMAL(10, 2),
    id_sala INT,
	activo bit
	);

-- Tabla fechas
CREATE TABLE fechas (
    codigo_fecha INT PRIMARY KEY,
    descripcion VARCHAR(255),
    codigo_funcion INT,
    FOREIGN KEY (codigo_funcion) REFERENCES funciones(codigo_funcion)
);

-- Tabla reservas
CREATE TABLE reservas (
    id_reserva INT PRIMARY KEY,
    numero_reserva INT,
    id_butaca INT,
    FOREIGN KEY (id_butaca) REFERENCES butacas(id_butaca)
);

-- Tabla descuento
CREATE TABLE descuento (
    id_descuento INT PRIMARY KEY,
    id_tipo INT,
    valor DECIMAL(10, 2),
    --FOREIGN KEY (id_tipo) REFERENCES tipo_descuento(id_tipo)
);

-- Tabla tipo_descuento
CREATE TABLE tipo_descuento (
    id_tipo INT PRIMARY KEY,
    descripcion VARCHAR(255)
);
-- Tabla ticket
CREATE TABLE ticket (
    id_ticket INT PRIMARY KEY,
    id_sala INT,
    codigo_pelicula INT,
    codigo_funcion INT,
    FOREIGN KEY (id_sala) REFERENCES salas(id_sala),
    FOREIGN KEY (codigo_pelicula) REFERENCES peliculas(codigo_pelicula),
    FOREIGN KEY (codigo_funcion) REFERENCES funciones(codigo_funcion)
);

-- Tabla butacas_reservadas
CREATE TABLE butacas_reservadas (
    id_butaca_reservada INT PRIMARY KEY,
    id_reserva INT,
    id_butaca INT
	);

CREATE TABLE Usuario (
    id_usuario INT IDENTITY(1,1) PRIMARY KEY,
    nombre_de_usuario VARCHAR(50),
    contrasena VARCHAR(50),
    email VARCHAR(50)
);
-- Tabla detalles_facturas
CREATE TABLE detalle_Ticketfactura (
    id_detalle_factura INT IDENTITY(1,1) PRIMARY KEY,
    id_factura INT,
    id_butaca INT,
    precio DECIMAL(10, 2),
    id_descuento INT,
	id_funcion int
	constraint FK_detalles_ticketfactura_funcion foreign key (id_funcion)
	references Funciones (codigo_funcion)
	);



 ALTER TABLE funciones
DROP COLUMN descripcion;

--Agregar relacion entre Descuento y tipo de descuento
alter table Descuento
add constraint Fk_Descuento_tipo
FOREIGN KEY (id_tipo) 
REFERENCES tipo_descuento(id_tipo);

--Agregar relacion entre butacas y estado
ALTER TABLE butacas
ADD CONSTRAINT FK_Butacas_Estado
FOREIGN KEY (id_estado) 
REFERENCES estados(id_estado);
-- Agregar relación entre butacas y salas
ALTER TABLE butacas
ADD CONSTRAINT FK_Butacas_Salas
FOREIGN KEY (id_sala)
REFERENCES salas (id_sala);
-- Agregar relación entre butacas y funciones
ALTER TABLE butacas
ADD CONSTRAINT FK_Butacas_Funciones
FOREIGN KEY (codigo_funcion)
REFERENCES funciones (codigo_funcion);
-- Agregar relación entre fechas y funciones
ALTER TABLE fechas
ADD CONSTRAINT FK_Fechas_Funciones
FOREIGN KEY (codigo_funcion)
REFERENCES funciones (codigo_funcion);
-- Agregar relación entre detalles_facturas y facturas
ALTER TABLE detalle_Ticketfactura
ADD CONSTRAINT FK_DetallesFacturas_Facturas
FOREIGN KEY (id_factura)
REFERENCES TicketFactura (id_factura);
-- Agregar relación entre detalles_facturas y butacas
ALTER TABLE detalle_Ticketfactura
ADD CONSTRAINT FK_DetallesFacturas_Butacas
FOREIGN KEY (id_butaca)
REFERENCES butacas (id_butaca);
-- Agregar relación entre detalles_facturas y descuento
ALTER TABLE detalle_Ticketfactura
ADD CONSTRAINT FK_DetallesFacturas_Descuento
FOREIGN KEY (id_descuento)
REFERENCES descuento (id_descuento);
-- Agregar relación entre butacas_reservadas y reservas
ALTER TABLE butacas_reservadas
ADD CONSTRAINT FK_ButacasReservadas_Reservas
FOREIGN KEY (id_reserva)
REFERENCES reservas (id_reserva);
-- Agregar relación entre butacas_reservadas y butacas
ALTER TABLE butacas_reservadas
ADD CONSTRAINT FK_ButacasReservadas_Butacas
FOREIGN KEY (id_butaca)
REFERENCES butacas (id_butaca);
-- Agregar relación entre ticket y salas
ALTER TABLE ticket
ADD CONSTRAINT FK_Ticket_Salas
FOREIGN KEY (id_sala)
REFERENCES salas (id_sala);
-- Agregar relación entre ticket y funciones
ALTER TABLE ticket
ADD CONSTRAINT FK_Ticket_Funciones
FOREIGN KEY (codigo_funcion)
REFERENCES funciones (codigo_funcion);
-- Agregar relación entre ticket y peliculas
ALTER TABLE ticket
ADD CONSTRAINT FK_Ticket_Peliculas
FOREIGN KEY (codigo_pelicula)
REFERENCES peliculas (codigo_pelicula);
-- Agregar relación entre funciones y peliculas
ALTER TABLE funciones
ADD CONSTRAINT FK_Funciones_Peliculas
FOREIGN KEY (codigo_pelicula)
REFERENCES peliculas (codigo_pelicula);
-- Agregar relación entre funciones y salas
ALTER TABLE funciones
ADD CONSTRAINT FK_Funciones_Salas
FOREIGN KEY (id_sala)
REFERENCES salas (id_sala);


--nuevos atributos a la tabla clientes
ALTER TABLE clientes
ADD activo bit;

ALTER TABLE clientes
ADD DNI BIGINT;


--Otras modificaciones
DROP TABLE Ticket;
GO
DROP TABLE detalles_pagos;
GO
ALTER TABLE Ticketfactura
ADD id_forma INT NULL,
Constraint FK_TicketFacturas_formaPago FOREIGN KEY (id_forma) REFERENCES formas_pago(id_forma);
GO
ALTER TABLE peliculas
DROP COLUMN fecha_final;
GO

ALTER TABLE peliculas
DROP COLUMN fecha_inicio;
GO

ALTER TABLE peliculas
ADD duracion TIME;
GO
ALTER TABLE peliculas
DROP COLUMN codigo_fecha;
GO
DROP TABLE fechas;
GO
ALTER TABLE butacas
DROP COLUMN descripcion;

go
-------------------------------------------------------------------------------

--------------SP-----


---------------------INSERTS---------------------

SET IDENTITY_INSERT [dbo].[clientes] ON;
GO
INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (1, 'Fernando', 'Lopez', '3511234567', 'fernando.lopez@gmail.com', '098765432', 1);
	INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (2, 'Martina', 'Gutierrez', '3512345678', 'martina.gutierrez@gmail.com', '987654321', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (3, 'Diego', 'Martinez', '3513456789', 'diego.martinez@gmail.com', '876543210', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (4, 'Laura', 'Gonzalez', '3514567890', 'laura.gonzalez@gmail.com', '765432109', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (5, 'Javier', 'Sanchez', '3515678901', 'javier.sanchez@gmail.com', '654321098', 1); 
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (6, 'Ana', 'Rodriguez', '3516789012', 'ana.rodriguez@gmail.com', '543210987', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (7, 'Carlos', 'Hernandez', '3517890123', 'carlos.hernandez@gmail.com', '432109876', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (8, 'Sofia', 'Perez', '3518901234', 'sofia.perez@gmail.com', '321098765', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (9, 'Luis', 'Gomez', '3519012345', 'luis.gomez@gmail.com', '210987654', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (10, 'Valentina', 'Diaz', '3510123456', 'valentina.diaz@gmail.com', '109876543', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (11, 'Mariano', 'Fernandez', '3511234567', 'mariano.fernandez@gmail.com', '098765432', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (12, 'Camila', 'Lopez', '3512345678', 'camila.lopez@gmail.com', '987654321', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (13, 'Agustin', 'Gutierrez', '3513456789', 'agustin.gutierrez@gmail.com', '876543210', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (14, 'Lucia', 'Martinez', '3514567890', 'lucia.martinez@gmail.com', '765432109', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (15, 'Lucas', 'Gonzalez', '3515678901', 'lucas.gonzalez@gmail.com', '654321098', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (16, 'Mateo', 'Sanchez', '3516789012', 'mateo.sanchez@gmail.com', '543210987', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (17, 'Santiago', 'Hernandez', '3517890123', 'santiago.hernandez@gmail.com', '432109876', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (18, 'Emilia', 'Perez', '3518901234', 'emilia.perez@gmail.com', '321098765', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (19, 'Emma', 'Gomez', '3519012345', 'emma.gomez@gmail.com', '210987654', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (20, 'Olivia', 'Diaz', '3510123456', 'olivia.diaz@gmail.com', '109876543', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (21, 'Thiago', 'Fernandez', '3511234567', 'thiago.fernandez@gmail.com', '098765432', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (22, 'Bautista', 'Lopez', '3512345678', 'bautista.lopez@gmail.com', '987654321', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (23, 'Mia', 'Gutierrez', '3513456789', 'mia.gutierrez@gmail.com', '876543210', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (24, 'Benjamin', 'Martinez', '3514567890', 'benjamin.martinez@gmail.com', '765432109', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (25, 'Oliver', 'Gonzalez', '3515678901', 'oliver.gonzalez@gmail.com', '654321098', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (26, 'Emma', 'Sanchez', '3516789012', 'emma.sanchez@gmail.com', '543210987', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (27, 'Amelia', 'Rodriguez', '3517890123', 'amelia.rodriguez@gmail.com', '432109876', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (28, 'Max', 'Hernandez', '3518901234', 'max.hernandez@gmail.com', '321098765', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (29, 'Sophia', 'Perez', '3519012345', 'sophia.perez@gmail.com', '210987654', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (30, 'Lucas', 'Gomez', '3510123456', 'lucas.gomez@gmail.com', '109876543', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (31, 'Isabella', 'Diaz', '3511234567', 'isabella.diaz@gmail.com', '098765432', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (32, 'Mia', 'Fernandez', '3512345678', 'mia.fernandez@gmail.com', '987654321', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (33, 'Alexander', 'Lopez', '3513456789', 'alexander.lopez@gmail.com', '876543210', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (34, 'James', 'Gutierrez', '3514567890', 'james.gutierrez@gmail.com', '765432109', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (35, 'Charlotte', 'Martinez', '3515678901', 'charlotte.martinez@gmail.com', '654321098', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (36, 'Daniel', 'Sanchez', '3516789012', 'daniel.sanchez@gmail.com', '543210987', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (37, 'Liam', 'Rodriguez', '3517890123', 'liam.rodriguez@gmail.com', '432109876', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (38, 'Olivia', 'Hernandez', '3518901234', 'olivia.hernandez@gmail.com', '321098765', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (39, 'Elijah', 'Perez', '3519012345', 'elijah.perez@gmail.com', '210987654', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (40, 'Michael', 'Gomez', '3510123456', 'michael.gomez@gmail.com', '109876543', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (41, 'Alexander', 'Diaz', '3511234567', 'alexander.diaz@gmail.com', '098765432', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (42, 'Evelyn', 'Fernandez', '3512345678', 'evelyn.fernandez@gmail.com', '987654321', 1);
   INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES  (43, 'Harper', 'Lopez', '3513456789', 'harper.lopez@gmail.com', '876543210', 1);
   INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES  (44, 'Aria', 'Gutierrez', '3514567890', 'aria.gutierrez@gmail.com', '765432109', 1);
   INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES  (45, 'Elena', 'Martinez', '3515678901', 'elena.martinez@gmail.com', '654321098', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (46, 'Ella', 'Sanchez', '3516789012', 'ella.sanchez@gmail.com', '543210987', 1);
    INSERT INTO clientes (id_cliente, nom_cliente, apellido_cliente, telefono, email, DNI, activo)
VALUES (47, 'Avery', 'Rodriguez', '3517890123', 'avery.rodriguez@gmail.com','41019295',1 );
go
	SET IDENTITY_INSERT [dbo].[Clientes] OFF;
	GO

UPDATE clientes
SET telefono = NULL;
GO

  ALTER TABLE clientes
ALTER COLUMN telefono bigINT;
GO

UPDATE clientes
SET telefono = CASE 
    WHEN id_cliente = 1 THEN 3511234567
    WHEN id_cliente = 2 THEN 3512345678
    WHEN id_cliente = 3 THEN 3513456789
    WHEN id_cliente = 4 THEN 3514567890
    WHEN id_cliente = 5 THEN 3515678901
    WHEN id_cliente = 6 THEN 3516789012
    WHEN id_cliente = 7 THEN 3517890123
    WHEN id_cliente = 8 THEN 3518901234
    WHEN id_cliente = 9 THEN 3519012345
    WHEN id_cliente = 10 THEN 3510123456
    WHEN id_cliente = 11 THEN 3511234567
    WHEN id_cliente = 12 THEN 3512345678
    WHEN id_cliente = 13 THEN 3513456789
    WHEN id_cliente = 14 THEN 3514567890
    WHEN id_cliente = 15 THEN 3515678901
    WHEN id_cliente = 16 THEN 3516789012
    WHEN id_cliente = 17 THEN 3517890123
    WHEN id_cliente = 18 THEN 3518901234
    WHEN id_cliente = 19 THEN 3519012345
    WHEN id_cliente = 20 THEN 3510123456
    WHEN id_cliente = 21 THEN 3511234567
    WHEN id_cliente = 22 THEN 3512345678
    WHEN id_cliente = 23 THEN 3513456789
    WHEN id_cliente = 24 THEN 3514567890
    WHEN id_cliente = 25 THEN 3515678901
    WHEN id_cliente = 26 THEN 3516789012
    WHEN id_cliente = 27 THEN 3517890123
    WHEN id_cliente = 28 THEN 3518901234
    WHEN id_cliente = 29 THEN 3519012345
    WHEN id_cliente = 30 THEN 3510123456
    WHEN id_cliente = 31 THEN 3511234567
    WHEN id_cliente = 32 THEN 3512345678
    WHEN id_cliente = 33 THEN 3513456789
    WHEN id_cliente = 34 THEN 3514567890
    WHEN id_cliente = 35 THEN 3515678901
    WHEN id_cliente = 36 THEN 3516789012
    WHEN id_cliente = 37 THEN 3517890123
    WHEN id_cliente = 38 THEN 3518901234
    WHEN id_cliente = 39 THEN 3519012345
    WHEN id_cliente = 40 THEN 3510123456
    WHEN id_cliente = 41 THEN 3511234567
    WHEN id_cliente = 42 THEN 3512345678
    WHEN id_cliente = 43 THEN 3513456789
    WHEN id_cliente = 44 THEN 3514567890
    WHEN id_cliente = 45 THEN 3515678901
    WHEN id_cliente = 46 THEN 3516789012
    WHEN id_cliente = 47 THEN 3517890123
    ELSE 0 
END;
GO


  INSERT INTO formas_pago (id_forma, descripcion) 
  VALUES (1, 'Efectivo');
INSERT INTO formas_pago (id_forma, descripcion) 
  VALUES (2, 'Débito');
INSERT INTO formas_pago (id_forma, descripcion) 
  VALUES (3, 'Crédito');
GO

INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (1, 'Acción');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (2, 'Comedia');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (3, 'Drama');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (4, 'Ciencia ficción');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (5, 'Terror');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (6, 'Romance');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (7, 'Aventura');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (8, 'Animación');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (9, 'Fantasía');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (10, 'Suspenso');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (11, 'Documental');
INSERT INTO categorias (codigo_categoria, descripcion)
VALUES (12, 'Infantil');
GO

  INSERT INTO formatos (id_formato, descripcion)
VALUES(1, '2D');
INSERT INTO formatos (id_formato, descripcion)
VALUES(2, '3D');
INSERT INTO formatos (id_formato, descripcion)
VALUES(3, 'IMAX');
INSERT INTO formatos (id_formato, descripcion)
VALUES(4, 'IMAX 3D');
INSERT INTO formatos (id_formato, descripcion)
VALUES(5, 'Dolby Atmos');
INSERT INTO formatos (id_formato, descripcion)
VALUES(6, 'ScreenX');
GO

INSERT INTO clasificaciones (codigo_clasificacion, descripcion)
VALUES
(1, 'Guía parental 13');
INSERT INTO clasificaciones (codigo_clasificacion, descripcion)
VALUES(2, 'Restringida');
INSERT INTO clasificaciones (codigo_clasificacion, descripcion)
VALUES(3, 'Audiencia general');
INSERT INTO clasificaciones (codigo_clasificacion, descripcion)
VALUES(4, 'Prohibida para menores de 17 años');
INSERT INTO clasificaciones (codigo_clasificacion, descripcion)
VALUES(5, 'Guía parental');
INSERT INTO clasificaciones (codigo_clasificacion, descripcion)
VALUES(6, 'Sin clasificación');
GO

INSERT INTO cines (codigo_cine, nombre_cine, localidad)
VALUES
(1, 'SUNSTAR', 'Cordoba');
GO


INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES
(1, 'La Sombra del Silencio', 1, 1, 1, '02:15:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(2, 'Destino Desconocido', 1, 2, 2, '01:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(3, 'Aventuras en el Abismo', 1, 3, 3, '02:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(4, 'Carrera Contra el Tiempo', 1, 4, 4, '02:00:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(5, 'El Último Suspiro', 1, 5, 5, '02:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(6, 'Amor en la Tormenta', 1, 6, 6, '01:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(7, 'Misterios del Pasado', 1, 7, 1, '02:15:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(8, 'Sombras en la Oscuridad', 1, 8, 2, '01:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(9, 'Vuelo a lo Desconocido', 1, 9, 3, '02:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(10, 'Ritmo de la Noche', 1, 10, 4, '02:00:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(11, 'Secretos del Laberinto', 1, 11, 5, '02:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(12, 'La Última Sonrisa', 1, 12, 6, '01:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(13, 'Luces en la Ciudad', 1, 1, 1, '02:15:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(14, 'Cazadores de Sueños', 1, 2, 2, '01:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(15, 'La Isla de los Recuerdos', 1, 3, 3, '02:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(16, 'Reflejos del Pasado', 1, 4, 4, '02:00:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(17, 'Sendero del Crepúsculo', 1, 5, 5, '02:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(18, 'El Último Baile', 1, 6, 6, '01:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(19, 'Misterios del Más Allá', 1, 7, 1, '02:15:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(20, 'Entre Sombras y Susurros', 1, 8, 2, '01:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(21, 'La Ciudad de las Estrellas', 1, 9, 3, '02:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(22, 'Enigma del Abismo', 1, 10, 4, '02:00:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(23, 'Canción del Anochecer', 1, 11, 5, '02:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(24, 'El Último Desafío', 1, 12, 6, '01:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(25, 'El Juego de las Sombras', 1, 1, 1, '02:15:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(26, 'Travesía en el Espacio', 1, 2, 2, '01:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(27, 'El Despertar del Tiempo', 1, 3, 3, '02:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(28, 'Pasillo de los Recuerdos', 1, 4, 4, '02:00:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(29, 'Cazadores de Estrellas', 1, 5, 5, '02:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(30, 'El Sueño Eterno', 1, 6, 6, '01:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(31, 'Cenizas del Pasado', 1, 7, 1, '02:15:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(32, 'Aventuras en el Laberinto', 1, 8, 2, '01:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(33, 'El Último Eco', 1, 9, 3, '02:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(34, 'Desafío en el Abismo', 1, 10, 4, '02:00:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(35, 'La Última Danza', 1, 11, 5, '02:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(36, 'Sinfonía del Anochecer', 1, 12, 6, '01:30:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(37, 'Sombras del Pasado', 1, 1, 1, '02:15:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(38, 'El Último Susurro', 1, 2, 2, '01:45:00');
INSERT INTO peliculas (codigo_pelicula, nombre_pelicula, codigo_cine, codigo_Categoria, codigo_clasificacion, duracion)
VALUES(39, 'Aventuras en el Crepúsculo', 1, 3, 3, '02:30:00');
GO

  UPDATE peliculas
SET director = 
    CASE codigo_pelicula
        WHEN 1 THEN 'Steven Spielberg'
        WHEN 2 THEN 'Christopher Nolan'
        WHEN 3 THEN 'Quentin Tarantino'
        WHEN 4 THEN 'Guillermo del Toro'
        WHEN 5 THEN 'Martin Scorsese'
        WHEN 6 THEN 'Tim Burton'
        WHEN 7 THEN 'David Fincher'
        WHEN 8 THEN 'James Cameron'
        WHEN 9 THEN 'Alfred Hitchcock'
        WHEN 10 THEN 'Stanley Kubrick'
        WHEN 11 THEN 'Francis Ford Coppola'
        WHEN 12 THEN 'Coen Brothers'
        WHEN 13 THEN 'Peter Jackson'
        WHEN 14 THEN 'Ridley Scott'
        WHEN 15 THEN 'Akira Kurosawa'
        WHEN 16 THEN 'Spike Lee'
        WHEN 17 THEN 'Wes Anderson'
        WHEN 18 THEN 'Orson Welles'
        WHEN 19 THEN 'Roman Polanski'
        WHEN 20 THEN 'David Lynch'
        WHEN 21 THEN 'Martin Scorsese'
        WHEN 22 THEN 'Quentin Tarantino'
        WHEN 23 THEN 'Guillermo del Toro'
        WHEN 24 THEN 'Tim Burton'
        WHEN 25 THEN 'David Fincher'
        WHEN 26 THEN 'James Cameron'
        WHEN 27 THEN 'Alfred Hitchcock'
        WHEN 28 THEN 'Stanley Kubrick'
        WHEN 29 THEN 'Francis Ford Coppola'
        WHEN 30 THEN 'Coen Brothers'
        WHEN 31 THEN 'Peter Jackson'
        WHEN 32 THEN 'Ridley Scott'
        WHEN 33 THEN 'Akira Kurosawa'
        WHEN 34 THEN 'Spike Lee'
        WHEN 35 THEN 'Wes Anderson'
        WHEN 36 THEN 'Orson Welles'
        WHEN 37 THEN 'Roman Polanski'
        WHEN 38 THEN 'David Lynch'
        WHEN 39 THEN 'Martin Scorsese'
        WHEN 40 THEN 'Quentin Tarantino'
        
    END;
	GO


INSERT INTO salas (id_sala, cantidad_butaca, codigo_cine)
VALUES(1, 75, 1);
INSERT INTO salas (id_sala, cantidad_butaca, codigo_cine)
VALUES(2, 75, 1);
INSERT INTO salas (id_sala, cantidad_butaca, codigo_cine)
VALUES(3, 75, 1);
INSERT INTO salas (id_sala, cantidad_butaca, codigo_cine)
VALUES(4, 75, 1);
INSERT INTO salas (id_sala, cantidad_butaca, codigo_cine)
VALUES(5, 50, 1);
INSERT INTO salas (id_sala, cantidad_butaca, codigo_cine)
VALUES(6, 50, 1);
INSERT INTO salas (id_sala, cantidad_butaca, codigo_cine)
VALUES(7, 50, 1);
INSERT INTO salas (id_sala, cantidad_butaca, codigo_cine)
VALUES(8, 50, 1);
GO
UPDATE salas SET cantidad_butaca = 15 WHERE id_sala BETWEEN 1 AND 4;
UPDATE salas SET cantidad_butaca = 20 WHERE id_sala BETWEEN 5 AND 8; 


SET IDENTITY_INSERT [dbo].[funciones] ON;
go

INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(1, 1, '2023-11-09', '08:30:00', 1200.50, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(2, 12, '2023-11-10', '10:15:00', 1350.00, 8);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(3, 25, '2023-11-11', '12:45:00', 1100.75, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(4, 4, '2023-11-12', '14:30:00', 1300.25, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(5, 18, '2023-11-13', '16:15:00', 1150.90, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(6, 30, '2023-11-14', '18:30:00', 1200.50, 7);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(7, 9, '2023-11-15', '20:15:00', 1350.00, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(8, 22, '2023-11-16', '22:45:00', 1100.75, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(9, 2, '2023-11-17', '08:30:00', 1200.50, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(10, 14, '2023-11-18', '10:15:00', 1350.00, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(11, 26, '2023-11-19', '12:30:00', 1250.75, 8);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(12, 8, '2023-11-20', '14:45:00', 1125.50, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(13, 20, '2023-11-21', '16:30:00', 1400.25, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(14, 1, '2023-11-22', '18:15:00', 1280.90, 7);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(15, 11, '2023-11-23', '20:30:00', 1050.00, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(16, 31, '2023-11-24', '22:00:00', 1325.75, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(17, 7, '2023-11-25', '08:45:00', 1180.50, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(18, 19, '2023-11-26', '10:30:00', 1375.25, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(19, 34, '2023-11-27', '12:15:00', 1140.90, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(21, 14, '2023-11-29', '16:45:00', 1300.50, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(22, 28, '2023-11-30', '18:30:00', 1160.25, 7);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(23, 6, '2023-12-01', '20:45:00', 1350.90, 8);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(24, 22, '2023-12-02', '22:30:00', 1125.00, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(25, 10, '2023-12-03', '08:00:00', 1200.75, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(26, 35, '2023-12-04', '10:15:00', 1280.25, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(27, 16, '2023-12-05', '12:30:00', 1050.50, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(28, 3, '2023-12-06', '14:45:00', 1375.75, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(29, 25, '2023-12-07', '16:30:00', 1140.90, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(30, 9, '2023-12-08', '18:15:00', 1220.25, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(20, 5, '2023-11-28', '14:30:00', 1220.25, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(31, 11, '2023-12-09', '20:30:00', 1320.50, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(32, 27, '2023-12-10', '22:15:00', 1185.25, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(33, 19, '2023-12-11', '08:45:00', 1370.90, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(34, 4, '2023-12-12', '10:30:00', 1140.25, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(35, 12, '2023-12-13', '12:45:00', 1220.50, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(36, 31, '2023-12-14', '14:30:00', 1300.75, 7);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(37, 7, '2023-12-15', '16:45:00', 1150.00, 8);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(38, 21, '2023-12-16', '18:30:00', 1285.25, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(39, 8, '2023-12-17', '20:45:00', 1050.90, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(40, 33, '2023-12-18', '22:30:00', 1225.50, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(41, 23, '2023-12-19', '08:00:00', 1200.75, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(42, 15, '2023-12-20', '10:15:00', 1280.25, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(43, 29, '2023-12-21', '12:30:00', 1050.50, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(44, 3, '2023-12-22', '14:45:00', 1375.75, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(45, 18, '2023-12-23', '16:30:00', 1140.90, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(46, 10, '2023-12-24', '18:15:00', 1220.25, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(47, 26, '2023-12-25', '20:30:00', 1300.50, 7);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(48, 7, '2023-12-26', '22:15:00', 1185.25, 8);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(49, 20, '2023-12-27', '08:45:00', 1370.90, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(50, 5, '2023-12-28', '10:30:00', 1140.25, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(51, 33, '2023-12-29', '12:45:00', 1220.50, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(52, 9, '2023-12-30', '14:30:00', 1300.75, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(53, 17, '2023-12-31', '16:45:00', 1150.00, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(54, 25, '2024-01-01', '18:30:00', 1285.25, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(55, 6, '2024-01-02', '20:45:00', 1050.90, 7);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(56, 21, '2024-01-03', '22:30:00', 1225.50, 8);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(57, 13, '2024-01-04', '08:00:00', 1200.75, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(58, 28, '2024-01-05', '10:15:00', 1280.25, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(59, 11, '2024-01-06', '12:30:00', 1050.50, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(60, 4, '2024-01-07', '14:45:00', 1375.75, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(61, 19, '2024-01-08', '16:00:00', 1250.75, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(62, 3, '2024-01-09', '18:15:00', 1125.50, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(63, 30, '2024-01-10', '20:30:00', 1300.25, 7);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(64, 14, '2024-01-11', '22:45:00', 1180.00, 8);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(65, 1, '2024-01-12', '08:30:00', 1325.25, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(66, 26, '2024-01-13', '10:45:00', 1145.75, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(67, 8, '2024-01-14', '12:30:00', 1380.90, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(68, 22, '2024-01-15', '14:15:00', 1230.25, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(69, 10, '2024-01-16', '16:30:00', 1350.50, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(70, 35, '2024-01-17', '18:45:00', 1200.75, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(71, 18, '2024-01-18', '20:00:00', 1280.50, 7);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(72, 5, '2024-01-19', '22:15:00', 1155.25, 8);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(73, 32, '2024-01-20', '08:30:00', 1340.90, 1);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(74, 13, '2024-01-21', '10:45:00', 1130.25, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(75, 27, '2024-01-22', '12:30:00', 1210.50, 3);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(76, 7, '2024-01-23', '14:45:00', 1290.75, 4);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(77, 21, '2024-01-24', '16:00:00', 1165.00, 5);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(78, 12, '2024-01-25', '18:15:00', 1335.25, 6);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(79, 29, '2024-01-26', '20:30:00', 1100.90, 2);
INSERT INTO funciones (codigo_funcion, codigo_pelicula, fecha, hora, precio, id_sala)
VALUES(80, 4, '2024-01-27', '22:45:00', 1250.50, 5);
GO
	SET IDENTITY_INSERT [dbo].[funciones] OFF;
GO

  UPDATE funciones SET precio = 1200 WHERE codigo_pelicula = 1; 
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 2;
UPDATE funciones SET precio = 1100 WHERE codigo_pelicula = 3;
UPDATE funciones SET precio = 1250 WHERE codigo_pelicula = 4;
UPDATE funciones SET precio = 1280.90 WHERE codigo_pelicula = 5;
UPDATE funciones SET precio = 1320 WHERE codigo_pelicula = 6;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 7;
UPDATE funciones SET precio = 1200 WHERE codigo_pelicula = 8;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 9;
UPDATE funciones SET precio = 1100 WHERE codigo_pelicula = 10;
UPDATE funciones SET precio = 1250 WHERE codigo_pelicula = 11;
UPDATE funciones SET precio = 1280.90 WHERE codigo_pelicula = 12; 
UPDATE funciones SET precio = 1320 WHERE codigo_pelicula = 13;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 14;
UPDATE funciones SET precio = 1200 WHERE codigo_pelicula = 15;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula =16;
UPDATE funciones SET precio = 1100 WHERE codigo_pelicula = 17;
UPDATE funciones SET precio = 1250 WHERE codigo_pelicula = 18;
UPDATE funciones SET precio = 1280.90 WHERE codigo_pelicula = 19;
UPDATE funciones SET precio = 1320 WHERE codigo_pelicula = 20;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 21;
UPDATE funciones SET precio = 1200 WHERE codigo_pelicula = 22;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 23;
UPDATE funciones SET precio = 1100 WHERE codigo_pelicula = 24;
UPDATE funciones SET precio = 1250 WHERE codigo_pelicula = 25;
UPDATE funciones SET precio = 1280.90 WHERE codigo_pelicula = 26;
UPDATE funciones SET precio = 1320 WHERE codigo_pelicula = 27;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 28;
UPDATE funciones SET precio = 1200 WHERE codigo_pelicula = 29;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 30;
UPDATE funciones SET precio = 1100 WHERE codigo_pelicula = 31;
UPDATE funciones SET precio = 1250 WHERE codigo_pelicula = 32;
UPDATE funciones SET precio = 1280.90 WHERE codigo_pelicula = 33;
UPDATE funciones SET precio = 1320 WHERE codigo_pelicula = 34;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 35;
UPDATE funciones SET precio = 1200 WHERE codigo_pelicula = 36;
UPDATE funciones SET precio = 1300 WHERE codigo_pelicula = 37;
UPDATE funciones SET precio = 1100 WHERE codigo_pelicula = 38;
UPDATE funciones SET precio = 1250 WHERE codigo_pelicula = 39;


GO
INSERT INTO butacas (id_butaca, id_sala)
VALUES
(1, 1), (2, 1), (3, 1), (4, 1), (5, 1), (6, 1), (7, 1), (8, 1), (9, 1), (10, 1), (11, 1), (12, 1), (13, 1), (14, 1), (15, 1);
GO
INSERT INTO butacas (id_butaca, id_sala)
VALUES
(16, 2), (17, 2), (18, 2), (19, 2), (20, 2), (21, 2), (22, 2), (23, 2), (24, 2), (25, 2), (26, 2), (27, 2), (28, 2), (29, 2), (30, 2);
GO
INSERT INTO butacas (id_butaca, id_sala)
VALUES
(31, 3), (32, 3), (33, 3), (34, 3), (35, 3), (36, 3), (37, 3), (38, 3), (39, 3), (40, 3), (41, 3), (42, 3), (43, 3), (44, 3), (45, 3);
GO
INSERT INTO butacas (id_butaca, id_sala)
VALUES
(46, 4), (47, 4), (48, 4), (49, 4), (50, 4), (51, 4), (52, 4), (53, 4), (54, 4), (55, 4), (56, 4), (57, 4), (58, 4), (59, 4), (60, 4);
GO
-- Insertar butacas para salas del 5 al 8 con 20 butacas cada una
INSERT INTO butacas (id_butaca, id_sala)
VALUES
(61, 5), (62, 5), (63, 5), (64, 5), (65, 5), (66, 5), (67, 5), (68, 5), (69, 5), (70, 5), (71, 5), (72, 5), (73, 5), (74, 5), (75, 5), (76, 5), (77, 5), (78, 5), (79, 5), (80, 5);
GO
INSERT INTO butacas (id_butaca, id_sala)
VALUES
(81, 6), (82, 6), (83, 6), (84, 6), (85, 6), (86, 6), (87, 6), (88, 6), (89, 6), (90, 6), (91, 6), (92, 6), (93, 6), (94, 6), (95, 6), (96, 6), (97, 6), (98, 6), (99, 6), (100, 6);
GO
INSERT INTO butacas (id_butaca, id_sala)
VALUES
(101, 7), (102, 7), (103, 7), (104, 7), (105, 7), (106, 7), (107, 7), (108, 7), (109, 7), (110, 7), (111, 7), (112, 7), (113, 7), (114, 7), (115, 7), (116, 7), (117, 7), (118, 7), (119, 7), (120, 7);
GO
INSERT INTO butacas (id_butaca, id_sala)
VALUES
(121, 8), (122, 8), (123, 8), (124, 8), (125, 8), (126, 8), (127, 8), (128, 8), (129, 8), (130, 8), (131, 8), (132, 8), (133, 8), (134, 8), (135, 8), (136, 8), (137,8)

GO


 INSERT INTO tipo_descuento (id_tipo, descripcion)
VALUES(1, 'Descuento por Pago con debito');
 INSERT INTO tipo_descuento (id_tipo, descripcion)
VALUES(2, 'Sin Descuento');
GO

-- Insertar un descuento
INSERT INTO descuento (id_descuento, id_tipo, valor)
VALUES (1, 1, 10);
GO

	SET IDENTITY_INSERT [dbo].[Ticketfactura] ON;

INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES (1, '2023-01-01', 12, 2);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(2, '2023-02-15', 34, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(3, '2023-03-07', 20, 3);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(4, '2023-04-23', 5, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(5, '2023-05-11', 41, 3);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(6, '2023-06-29', 15, 2);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(7, '2023-07-18', 29, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(8, '2023-08-04', 7, 3);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(9, '2023-09-22', 25, 2);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(10, '2023-10-09', 2, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(11, '2023-11-27', 37, 3);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(12, '2023-12-14', 11, 2);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(13, '2024-01-02', 26, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(14, '2024-02-18', 42, 3);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(15, '2024-03-05', 17, 2);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(16, '2024-04-21', 32, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(17, '2024-05-08', 8, 3);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(18, '2024-06-26', 23, 2);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(19, '2024-07-13', 39, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(20, '2024-08-30', 14, 3);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(21, '2024-09-16', 28, 2);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(22, '2024-10-04', 4, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(23, '2024-11-21', 36, 3);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(24, '2024-12-08', 10, 2);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(25, '2025-01-01', 24, 1);
INSERT INTO Ticketfactura (id_factura, fecha, id_cliente, id_forma)
VALUES(26, '2025-02-14', 40, 3);
GO
	SET IDENTITY_INSERT [dbo].[Ticketfactura] OFF;
GO
	SET IDENTITY_INSERT [dbo].[detalle_Ticketfactura] ON;

INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(1, 1, 1, 100, 1, 1);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(2, 1, 2, 100, 1, 1);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(3, 3, 3, 100, null, 3);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(4, 4, 4, 150, null, 4);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(5, 5, 10, 100, null, 5);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(6, 5, 11, 100, null, 6);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(7, 5, 12, 100, null, 7);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(8, 5, 8, 150, null, 8);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(9, 9, 9, 100, null, 9);
INSERT INTO detalle_Ticketfactura (id_detalle_factura, id_factura, id_butaca, precio, id_descuento, id_funcion)
VALUES(10, 10, 10, 120, 1, 10);
GO
	SET IDENTITY_INSERT [dbo].[detalle_Ticketfactura] OFF;


ALTER TABLE Butacas
DROP CONSTRAINT FK_Butacas_Funciones;
GO

ALTER TABLE Butacas
DROP COLUMN codigo_funcion;
ALTER TABLE Butacas
ADD numero INT;
GO

UPDATE butacas
SET numero = 1
WHERE id_butaca = 1;
GO

UPDATE Butacas
SET numero = id_butaca
WHERE id_butaca BETWEEN 1 AND 15;
GO

UPDATE Butacas
SET numero = id_butaca - 15
WHERE id_butaca BETWEEN 16 AND 30;
GO

UPDATE Butacas
SET numero = id_butaca - 30
WHERE id_butaca BETWEEN 31 AND 45;
GO

UPDATE Butacas
SET numero = id_butaca - 45
WHERE id_butaca BETWEEN 46 AND 60;
GO

UPDATE Butacas
SET numero = id_butaca - 60
WHERE id_butaca BETWEEN 61 AND 80;
GO

UPDATE Butacas
SET numero = id_butaca - 80
WHERE id_butaca BETWEEN 81 AND 100;
GO

UPDATE Butacas
SET numero = id_butaca - 100
WHERE id_butaca BETWEEN 101 AND 120;
GO

UPDATE Butacas
SET numero = id_butaca - 120
WHERE id_butaca BETWEEN 121 AND 137;
go


UPDATE Funciones
SET activo = 1;
go

alter table TicketFactura
add totalfinal decimal;
