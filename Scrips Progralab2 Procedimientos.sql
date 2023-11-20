use CineDB24689123;
go
CREATE PROCEDURE Sp_Buscar_Funcion_Pelicula
    @id_pelicula INT
AS
BEGIN   
    SELECT *
    FROM funciones
    WHERE codigo_pelicula = @id_pelicula;
END;
Go
--consulta datos del cliente
CREATE proc [dbo].[SP_Consultar_Clientes]
as
begin
	select id_cliente,nom_cliente,apellido_cliente,telefono,email,DNI
	from clientes
	where activo = 1
end;
GO
-- consulta datos del cliente pasandole un nombre como parametro
CREATE procedure [dbo].[sp_buscar_clientes_nombre]
as
begin
declare @nombre varchar (50)
select nom_cliente,apellido_cliente
from Clientes
where nom_cliente like ('%' +@nombre+ '%')
END;
GO
-- cpnsulta datos del cliente pasandole apellido por parametro
CREATE procedure [dbo].[sp_buscar_clientes_apellido]
as
begin
declare @apellido varchar (50)
select nom_cliente,apellido_cliente
from Clientes
where apellido_cliente like ('%' +@apellido+ '%')
END;
go

--consulta sobre funciones por fecha como parametro
CREATE PROCEDURE [dbo].[sp_consultar_funciones_fecha]
  as
  begin
  declare @fecha date
  select f.codigo_funcion,p.nombre_pelicula+' - '+cast(format(f.fecha,'dd/MM/yyyy') as varchar)+' - Sala '+cast(id_sala as varchar) 
  from funciones f, peliculas p
  where f.codigo_funcion=p.codigo_pelicula  and f.fecha>=@fecha
  end;
  go
-- consulta total de fechas
CREATE PROC [dbo].[sp_consultar_total_fechas]
AS
BEGIN
SELECT f.codigo_funcion,f.codigo_pelicula,f.fecha,f.hora,f.precio,id_sala,p.nombre_pelicula  as titulos
from Funciones f join Peliculas p on p.codigo_pelicula = f.codigo_pelicula
END;
go

--consulta de todas las peliculas disponibles
CREATE PROCEDURE [dbo].[sp_consultar_pelicula]
as
begin
select * from Peliculas
end;
go
---
CREATE PROCEDURE [dbo].[sp_consultar_peliculas_nombre]
  as
  begin
  select codigo_pelicula, nombre_pelicula
  from peliculas
  end;
  go
--consulta de cliente
CREATE PROCEDURE [dbo].[SP_GRABAR_CLIENTE] 
as
declare @activo bit = 1,@nombre varchar(100),
@apellido varchar(100),
@telefono bigint,
@dni bigint,
@email varchar(100)
begin
insert into clientes (email,telefono,nom_cliente,apellido_cliente, DNI, activo)
values (@email,@telefono,@nombre,@apellido,@dni,@activo)
end;
go
---dar de baja a un cliente

CREATE PROCEDURE [dbo].[SP_Eliminar_Clientes]
@id int
as
begin
update clientes set activo=0 where id_cliente=@id
end;
GO
--
CREATE proc [dbo].[SP_Insertar_Cliente] --usado en metodo GrabarCliente()
@nombre varchar(100),
@apellido varchar(100),
@telefono bigint,
@dni bigint,
@email varchar(100)
as
declare @activo bit = 1
begin
insert into clientes (nom_cliente,apellido_cliente,DNI,email,telefono,activo)
values (@nombre,@apellido,@dni,@email,@telefono,@activo)
end;


GO

CREATE PROCEDURE [dbo].[SP_Actualizar_Cliente]
    @idCliente INT,
    @nombre VARCHAR(100),
    @apellido VARCHAR(100),
    @telefono BIGINT,
    @dni BIGINT,
    @email VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    
    IF EXISTS (SELECT 1 FROM clientes WHERE id_cliente = @idCliente)
    BEGIN
        UPDATE clientes
        SET nom_cliente = @nombre,
            apellido_cliente = @apellido,
            DNI = @dni,
            email = @email,
            telefono = @telefono,
            activo = 1 
        WHERE id_cliente = @idCliente;

        PRINT 'Cliente actualizado correctamente.';
    END
    ELSE
    BEGIN
        PRINT 'El cliente con el ID proporcionado no existe.';
    END
END;
GO
CREATE procedure [dbo].[SP_Consultar_Formas_Pago]
as
begin
	select id_forma, descripcion
	from formas_pago
	
end;
GO

CREATE PROCEDURE [dbo].[Sp_Buscar_Butacas_Funcion]
    @id_funcion INT
AS
BEGIN
    
    SELECT id_butaca,numero
    FROM funciones f join salas s on f.id_sala = s.id_sala join butacas b on b.id_sala = s.id_sala
    WHERE codigo_funcion = @id_funcion;
END;
go

create PROCEDURE [dbo].[SP_Grabar_TicketFactura]
	@id_factura int output,
	@fecha datetime,
	@id_cliente int,
	@id_forma int,
	@totalfinal decimal
AS
BEGIN
	INSERT INTO TicketFactura (fecha,id_cliente,id_forma,totalfinal)
    VALUES (@fecha,@id_cliente,@id_forma,@totalfinal);
	set @id_factura = SCOPE_IDENTITY();
END;
Go

CREATE PROCEDURE [dbo].[SP_Gabar_Detalle_Ticket] 
	@id_factura int,
	@id_butaca int,
	@precio decimal,
	@id_descuento int,
    @id_funcion int
as
BEGIN	
    INSERT INTO detalle_Ticketfactura(id_factura,id_butaca,precio,id_descuento,id_funcion)
    VALUES (@id_factura,@id_butaca,@precio,@id_descuento,@id_funcion);

END;
GO

CREATE PROCEDURE [dbo].[SP_Proximo_Ticket]
@proximoID int output
as
begin
set @proximoID = (select max(id_factura)+1 from TicketFactura);
end;
go

CREATE procedure [dbo].[SP_Consultar_Salas]
as
begin
	select *
	from salas
	
end;
Go

CREATE PROCEDURE [dbo].[SP_Baja_Funcion]	
@id INT
AS
BEGIN
    update Funciones set activo=0 where codigo_funcion=@id
END;
GO

CREATE PROC [dbo].[SP_Insertar_Funcion] 
@codigo_pelicula INT,
@fecha DATE,
@hora VARCHAR(10), -- Cambiado a VARCHAR según tu definición
@precio DECIMAL,
@id_sala INT
AS
declare @activo bit = 1
BEGIN
    DECLARE @hora_convertida TIME;

    -- Realizar la conversión de varchar a time
    SET @hora_convertida = CONVERT(TIME, @hora);

    INSERT INTO funciones(codigo_pelicula, fecha, hora, precio, id_sala,activo)
    VALUES (@codigo_pelicula, @fecha, @hora_convertida, @precio, @id_sala,@activo);
END;
go

CREATE procedure [dbo].[SP_Consultar_Funciones]
as
begin
	select codigo_funcion,codigo_pelicula,fecha,hora,precio,id_sala
	from funciones
	where activo = 1 and  fecha >= CONVERT(date, GETDATE())
    ORDER BY Fecha ASC;

	
end;
GO

----------------Otros Procedimientos---------------------------

CREATE PROCEDURE ObtenerDatosUsuario
    (@usuario NVARCHAR(50))
AS
BEGIN

    SELECT nombre_de_usuario, contrasena
    FROM usuario
    WHERE nombre_de_usuario = @usuario;
END;
go

CREATE PROCEDURE InsertarUsuario
    @usuario NVARCHAR(255),
    @contraseña NVARCHAR(255),
    @mail NVARCHAR(255)
AS
BEGIN
    INSERT INTO Usuario (Nombre_De_Usuario, Contrasena, email)
    VALUES (@usuario, @contraseña, @mail);
END;


Create procedure SP_Seleccionar_Cliente
@DNI bigint
as 
begin
select dtf.id_detalle_factura,dtf.precio,tf.fecha,p.nombre_pelicula,f.fecha as 'fecha2' ,f.hora
from detalle_Ticketfactura dtf join TicketFactura tf on tf.id_factura = dtf.id_factura
							join funciones f on f.codigo_funcion = dtf.id_funcion
							join peliculas p on p.codigo_pelicula = f.codigo_pelicula
							join clientes c on c.id_cliente = tf.id_cliente
where c.DNI = @DNI
end;
go

create proc SP_Seleccionar_Fechas_Funciones
@fechaDesde date,
@fechaHasta date
as
begin
SELECT f.codigo_funcion, p.nombre_pelicula AS NombrePelicula, f.fecha AS FechaFuncion, f.hora AS HoraFuncion, s.id_sala,
s.cantidad_butaca, c.nombre_cine
FROM funciones f JOIN peliculas p ON f.codigo_pelicula = p.codigo_pelicula
				JOIN salas s ON f.id_sala = s.id_sala
				JOIN cines c ON s.codigo_cine = c.codigo_cine
WHERE f.fecha BETWEEN @fechaDesde AND @fechaHasta
order by f.fecha asc
end;
go

create proc SP_Cliente_MasGastado_Funcion
@id_funcion int
as
begin
SELECT c.id_cliente , c.nom_cliente , c.apellido_cliente, c.DNI , SUM(df.precio) GastoTotal, df.id_funcion
FROM clientes c
JOIN TicketFactura tf ON c.id_cliente = tf.id_cliente
JOIN detalle_Ticketfactura df ON tf.id_factura = df.id_factura
WHERE df.id_funcion = @id_funcion
GROUP BY c.id_cliente, c.nom_cliente, c.apellido_cliente, c.DNI,df.id_funcion
ORDER BY GastoTotal DESC;
end;

create procedure SP_Consultar_Funciones_ALL
as
begin
select codigo_funcion
from funciones
where activo = 1
end;
