use mydb;
INSERT INTO empleado ( nombre, cc) values ('Jairo', 1234667989),('Andres', 1234687989),('Maria', 1334667989),('Mario', 13349967989),('Pedro', 1355667989);
INSERT INTO tiposeguro ( TipoSegurocol,precio) values ('Seguro de vida', 9000000),('Seguro educativo', 800000),('Seguro obligatorio de accidentes de transito', 60000);
INSERT INTO clientes ( nombre, cc) values ('Carla', 1234667989),('Andrea', 1234689989),('Marcela', 1334337989),('Peter', 1334887989),('Catalina', 13533989),('Karina', 1355333989);
insert into ventas (clientes_idclientes,TipoSeguro_idTipoSeguro,Empleado_idEmpleado,fechaInicioSeguro,fechaFinalSeguro,venta) values ( 14,2,3,"23-12-23","24-12-24",1),( 13,2,3,"24-11-23","24-11-24",1);
select * from ventas;
insert into ventas (clientes_idclientes,TipoSeguro_idTipoSeguro,Empleado_idEmpleado,fechaInicioSeguro,fechaFinalSeguro,venta) values ( 14,3,5,"20-10-23","20-10-24",1),( 15,2,5,"24-09-23","24-09-24",1),( 17,1,2,"24-09-23","24-09-24",1);
insert into ventas (clientes_idclientes,Empleado_idEmpleado,venta) values ( 14,3,0),( 15,2,0),( 17,1,0);
