# 🍕 Sistema de Punto de Venta - Pizzería

Este proyecto es un sistema de control y gestión de tickets para una pizzería, desarrollado con **Windows Forms en .NET Framework** y conectado a una base de datos **SQL Server**. Funciona como un punto de venta completo, permitiendo el registro de usuarios, selección de productos (pizzas y bebidas), manejo de inventario, generación de tickets y control de ventas.

## 🧩 Características principales

- ✅ Pantalla de carga inicial (SplashScreen)
- 🔐 Formulario de inicio de sesión con validación de usuarios
- 👤 Registro de nuevos usuarios con email, usuario y contraseña
- 📋 Menú de pizzas y bebidas con precios
- 🛒 Carrito de compras para seleccionar productos
- 🧾 Generación de tickets con desglose de compras
- 📉 Descuento automático del inventario
- 🗃️ Conexión a base de datos SQL Server

## 💾 Estructura del Proyecto
/PuntoDeVentaPizzeria
│
├── Forms/
│ ├── SplashScreen.cs
│ ├── LoginForm.cs
│ ├── RegistroForm.cs
│ └── MainForm.cs
│
├── Helpers/
│ └── DatabaseHelper.cs
│
├── App.config
├── Program.cs
└── README.md

## 🗄️ Estructura de la base de datos

```sql
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE,
    Usuario NVARCHAR(50) UNIQUE,
    Contrasena NVARCHAR(100),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Categoria NVARCHAR(50), -- 'Pizza' o 'Bebida'
    Precio DECIMAL(10, 2),
    Stock INT
);

CREATE TABLE Tickets (
    Id INT PRIMARY KEY IDENTITY,
    Fecha DATETIME DEFAULT GETDATE(),
    Total DECIMAL(10, 2)
);

CREATE TABLE DetalleTicket (
    Id INT PRIMARY KEY IDENTITY,
    TicketId INT FOREIGN KEY REFERENCES Tickets(Id),
    ProductoId INT FOREIGN KEY REFERENCES Productos(Id),
    Cantidad INT,
    PrecioUnitario DECIMAL(10, 2),
    Subtotal DECIMAL(10, 2)
);

🔧 Requisitos
Visual Studio 2019 o superior

.NET Framework 4.7.2 o superior

SQL Server (Express o completo)

Acceso a System.Data.SqlClient

🛠️ Configuración
Clona este repositorio.

Crea la base de datos PizzeriaDB en SQL Server y ejecuta las tablas de arriba.

Configura la cadena de conexión en App.config:
<connectionStrings>
  <add name="MiConexion"
       connectionString="Data Source=localhost;Initial Catalog=PizzeriaDB;Integrated Security=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
<connectionStrings>
  <add name="MiConexion"
       connectionString="Data Source=localhost;Initial Catalog=PizzeriaDB;Integrated Security=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
Ejecuta el proyecto desde Program.cs.

📌 Pendiente por implementar
Impresión o guardado en PDF del ticket

Encriptación de contraseñas (hashing)

Módulo de reportes y estadísticas de ventas

Interfaz más atractiva (opcional con Guna UI, Bunifu, etc.)
