create database CONTACTO
use CONTACTO


/*Los usuarios que contengan la palabra admin en tipo de usuario seran los administradores*/
create table Usuarios(
idUsuario int primary key not null identity(1,1),
nombre varchar(100) not null,
sucursal varchar(30) not null,
correo varchar(50) not null,
celular varchar(10) not null,
telefono varchar(10) not null,
tipoUsuario varchar(5) not null,
contraseña varchar(30) not null
)

create table Contactos(
idContacto int primary key not null identity(1,1),
nombre varchar(100) not null,
telefono varchar(10) not null,
correo varchar(50) not null,
empresa varchar(50) not null,
direccion varchar(50),
observaciones varchar(200),
valoracion varchar(20),
cotizacion varchar(20),
idVendedor int not null,
foreign key (idVendedor) references Usuarios(idUsuario) 
)

create table Clientes(
idCliente int primary key not null identity(1,1),
nombre varchar(100) not null,
telefono varchar(10) not null,
correo varchar(50),
direccion varchar(50),
rfc varchar(13) not null,
direccionFiscal varchar(50) not null,
condicionesDePago varchar(50),
observaciones varchar(50),
idVendedor int not null,
fechaCreacion date not null,
ultimaVisita date not null,
foreign key (idVendedor) references Usuarios(idUsuario)
)

