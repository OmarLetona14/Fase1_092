create database PIZZA_HIT_201701012;-- Antes de ejecutar el archivo se debe reemplazar el nombre, en este caso PIZZA_HIT_CARNET
use PIZZA_HIT_201701012; -- Antes de ejecutar el archivo se debe reemplazar el nombre, en este caso PIZZA_HIT_CARNET 
-- Tambien se debe borrar estos comentarios 
create table Sucursal(
	idSucursal int primary key auto_increment not null, 
    codigo varchar(50) not null,
    direccion varchar(100) not null
);

create table Personal(
	idPersonal int primary key auto_increment not null,
	nombrePersonal varchar(50) not null,
    correo varchar(50) not null,
    contrasenia varchar (50) not null,
    tipo varchar(50) not null,
    idSucursal int,
    foreign key (idSucursal) references Sucursal(idSucursal) on delete cascade
);

create table Venta(
	idVenta int primary key auto_increment not null,
    cantidadPizza int not null,
    cantidadBebida int not null, 
    total double not null, 
    nombreCliente varchar(50) not null,
    telefonoCliente varchar(20) not null,
    idPersonal int not null,
    foreign key (idPersonal) references Personal(idPersonal) on delete cascade
);

create table Producto(
	idProducto int primary key auto_increment not null, 
    nombreProducto varchar(50) not null, 
    tipo varchar(50) not null, 
    precio double not null
);
-- Insertando sucursales
insert into Sucursal values (null, '8585','Guatemala, Cuidad Capital, Zona 7');
-- Insertando empleados
insert into Personal values (null, 'admin', 'admin@correo.com', 'admin', 'Administrador', null); -- Administrador
-- Empleados
insert into Personal values(null,'juanito', 'juanito@correo.com', '123', 'Empleado', 1);
insert into Personal values(null,'carlitos', 'carlitos@correo.com', '123', 'Empleado', 1);
insert into Personal values(null,'pedrito', 'pedrito@correo.com', '123', 'Empleado', 1);
insert into Personal values(null,'chusito', 'chusito@correo.com', '123', 'Empleado', 1);
-- Insertando productos
insert into Producto values(null, 'Pizza con peperoni', 'Pizza', 25.00);
insert into Producto values(null, 'Pizza con langonsta', 'Pizza', 50.00);
insert into Producto values(null, 'Pizza con Pastrami', 'Pizza', 75.00);
insert into Producto values(null, 'Pizza con jamon', 'Pizza', 89.00);
insert into Producto values(null, 'Pizza con anchoas', 'Pizza', 36.00);
insert into Producto values(null, 'Pizza con carne asada', 'Pizza', 100.00);
insert into Producto values(null, 'Pizza con camarones', 'Pizza', 63.50);
insert into Producto values(null, 'Pizza con salchicha', 'Pizza', 52.65);
insert into Producto values(null, 'Cerveza', 'Bebida',10);
insert into Producto values(null, 'Whiskey', 'Bebida', 25);
insert into Producto values(null, 'Coca cola', 'Bebida', 5);

-- Reporte 1
select v.idVenta, v.cantidadPizza, v.cantidadBebida, v.total, v.nombreCliente, v.telefonoCliente, p.nombrePersonal,
s.codigo, s.direccion
from venta as v
inner join personal as p on p.idPersonal = v.idPersonal
inner join sucursal as s on s.idSucursal = p.idSucursal
order by v.total desc;

-- Reporte 2
select s.codigo, sum(v.total) as total_ventas from venta as v
inner join personal as p on p.idPersonal = v.idPersonal
inner join sucursal as s on s.idSucursal = p.idSucursal
group by s.codigo;

-- Reporte 3
select p.nombrePersonal, sum(v.total) from venta as v
inner join personal as p on p.idPersonal = v.idPersonal
inner join sucursal as s on s.idSucursal = p.idSucursal
where p.idSucursal = 3
group by p.nombrePersonal;

-- Reporte 4
select s.codigo, sum(v.cantidadPizza) as total_vendido from venta as v 
inner join personal as p on p.idPersonal = v.idPersonal
inner join sucursal as s on s.idSucursal = p.idSucursal
group by s.codigo
order by total_vendido desc limit 3;

-- Reporte 5
select s.codigo, sum(v.cantidadBebida) as total_vendido from venta as v 
inner join personal as p on p.idPersonal = v.idPersonal
inner join sucursal as s on s.idSucursal = p.idSucursal
group by s.codigo
order by total_vendido desc limit 3;

