use mydb;
INSERT INTO empleado ( Nombre, cc,Edad,celular) values ('Jairo', 1234667989,25,3112153030),('Andres', 1234687989,26,3112501331),('Maria', 1334667989,27,3124756998),('Mario', 13349967989,42,3124789969),('Pedro', 1355667989,35,3457895656);
INSERT INTO tiposeguro ( TipoSegurocol,precio) values ('Seguro de vida', 9000000),('Seguro educativo', 800000),('Seguro obligatorio de accidentes de transito', 60000);
INSERT INTO clientes ( nombre, cc,edad,correo,celular) values ('Carla', 1234667989,55,"n@gmail.com",3154789999),('Andrea', 1234689989,23,"m@gmail.com",3154789888),('Marcela', 1334337989,30,"p@gmail.com",3154789777),('Peter', 1334887989,25,"q@gmail.com",3154789789),('Catalina', 13533989,60,"o@gmail.com",31547897845),('Karina', 1355333989,35,"k@gmail.com",3125475826);
insert into ventas (clientes_idclientes,TipoSeguro_idTipoSeguro,Empleado_idEmpleado,fechaInicioSeguro,fechaFinalSeguro,venta) values ( 1,2,3,"23-12-23","24-12-24",1),( 3,2,3,"24-11-23","24-11-24",1);
select * from ventas;
insert into ventas (clientes_idclientes,TipoSeguro_idTipoSeguro,Empleado_idEmpleado,fechaInicioSeguro,fechaFinalSeguro,venta) values ( 2,3,5,"20-10-23","20-10-24",1),( 5,2,5,"24-09-23","24-09-24",1),( 3,1,2,"24-09-23","24-09-24",1);
insert into ventas (clientes_idclientes,Empleado_idEmpleado,venta) values ( 1,3,0),( 5,2,0),( 3,1,0);
