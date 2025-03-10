Sistema de Gestión de Cines UTN
Descripción del Proyecto
Sistema completo de gestión para cines desarrollado en Windows Forms con C# y una arquitectura en capas. Permite la administración de clientes, funciones, tickets y reportes para salas de cine.
Características
Módulos Principales

Gestión de Clientes: Alta, baja, modificación y consulta de clientes.
Venta de Tickets: Proceso completo de venta de entradas con selección de películas, funciones y butacas.
Administración de Funciones: Programación de funciones con asignación de salas y horarios.
Reportes: Generación de informes sobre ventas y ocupación de salas.

Tecnologías Utilizadas

Frontend: Windows Forms (C#)
Backend: C# .NET
Base de Datos: SQL Server
Arquitectura: Patrón Repository, N-Capas

Estructura del Proyecto
Capas

Entidades: Clases de dominio (Clientes, Películas, Funciones, Butacas, etc.)
AccesoDatos: Capa de persistencia con patrón Repository
Fachada: Implementación de la lógica de negocio
Presentación: Formularios de Windows Forms

Principales Clases
Entidades

Clientes: Información personal de los clientes del cine
Películas: Catálogo de películas disponibles
Funciones: Programación de funciones con horario y sala
Butacas: Asientos disponibles por sala
TicketFactura: Tickets generados para las ventas

Servicios

Aplicacion: Implementación de la fachada principal
UsuarioService: Gestión de autenticación y usuarios

Funcionalidades Principales
Gestión de Clientes

Registro de nuevos clientes
Búsqueda por DNI
Actualización de datos personales
Eliminación lógica de registros

Venta de Tickets

Selección de cliente por DNI
Catálogo de películas disponibles
Selección de función y horario
Asignación de butacas
Múltiples formas de pago
Generación de ticket con número único

Administración de Funciones

Programación de nuevas funciones
Asignación de salas y horarios
Gestión de precios
Cancelación de funciones

Capturas de Pantalla
Pantalla Principal
![image](https://github.com/user-attachments/assets/78d13b57-ca94-4d5a-ac4f-14fae9206bca)


Menú principal de la aplicación con acceso a los diferentes módulos
Selección de Cliente
![image](https://github.com/user-attachments/assets/f125fd4b-3350-489a-b830-9a1a852a867d)

Formulario para la búsqueda y selección de clientes por DNI
Generación de Ticket
![image](https://github.com/user-attachments/assets/f695ff25-d39e-400a-b7db-f23c3d510af4)

Selección de película para la generación de un nuevo ticket
Detalle de Ticket
![image](https://github.com/user-attachments/assets/043da727-3e6d-4cc0-88e2-91d708611ffc)

Nueva Funcion
![image](https://github.com/user-attachments/assets/fd773708-04ee-4b8f-81e6-36d1e355d400)

El sistema utiliza SQL Server con procedimientos almacenados para todas las operaciones CRUD:

SP_Consultar_Clientes
SP_Insertar_Cliente
SP_Actualizar_Cliente
SP_Eliminar_Clientes
SP_Grabar_TicketFactura
SP_Gabar_Detalle_Ticket
SP_Consultar_Formas_Pago
SP_Consultar_Funciones
SP_Insertar_Funcion
SP_Baja_Funcion
Entre otros

Seguridad
El sistema cuenta con autenticación de usuarios implementada a través de:

Control de acceso por credenciales
Diferentes niveles de permisos
Gestión de sesiones

Interfaz de Usuario
La aplicación cuenta con una interfaz intuitiva y fácil de usar, desarrollada con Windows Forms y siguiendo un diseño consistente con colores corporativos (verde turquesa y azul oscuro).
Formularios Principales
Página Principal (CINES UTN)
Proporciona acceso a todos los módulos del sistema a través de un menú lateral con las opciones:

CLIENTES: Gestión completa de clientes
TICKET: Venta de entradas
REPORTES: Generación de informes
FUNCIONES: Administración de funciones y salas

Selección de Cliente
Permite buscar clientes por DNI y mostrar su información (nombre y apellido). Incluye un botón "GENERAR" para registrar nuevos clientes no encontrados en el sistema.
Alta de Ticket
Muestra un proceso guiado para la generación de tickets con:

Información del cliente seleccionado
Selector de película con lista desplegable
Selector de función con horario y fecha
Selector de butaca disponible
Forma de pago (Efectivo, Tarjeta, etc.)
Resumen de la selección en una tabla con opción para quitar elementos
Cálculo automático del total

Administración de Funciones
Permite programar nuevas funciones para las películas, asignar salas y establecer precios.
El diseño visual del sistema utiliza elementos como:

Iconos intuitivos
Paleta de colores corporativa
Tablas para mostrar información de manera organizada
Campos de selección desplegables
Botones claramente identificados para las acciones principales
