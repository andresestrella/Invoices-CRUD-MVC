# Invoices-CRUD-MVC
.NET 7, Entity Framework ORM

Como en la asignacién se me entrego el esquema de la base de datos y el Script SQL para recrearla,
 tome un enfoque denominado "Database First" y con las herramientas que existen dentro del Entity Framework puedo generar las clases de las entidades de mi aplicación, basadas en el esquema de la base de datos, como también la clase de Contexto para realizar operatcions sobre la base de datos.  
(el comando principal que utilice es el siguiente: `dotnet ef dbcontext scaffold`)  
Finalmente, cree los controladores y vistas necesarias para gestionar los clientes, tipos de clientes y facturas. 

# Como correr proyecto
1. Clonar repositorio y ubicarse en el root del proyecto
2. editar  "DbConnection" string dentro del archivo `appsettings.json` acorde a la instancia de tu base de datos.
3. correr app `dotnet run` 

# Video Demo
*TODO*
