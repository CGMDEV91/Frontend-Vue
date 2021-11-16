

create table Empresa(
Id int identity(1,1),
Nombre nvarchar(50)
primary key (Id)
)
Insert into Empresa values ('GoalSystems')
Insert into Empresa values ('PruebaEmpresa2')

create table Empleado(
Id int identity(1,1),
Nombre nvarchar(50),
EmpresaId int,
constraint Fk_EmpresaId foreign key (EmpresaId) references Empresa(Id)
);
Insert into Empleado  values ('Carlos González rr',1)
Insert into Empleado  values ('Pedro Delgado',2)

create table Tareas(
Id int identity(1,1),
Descripcion nvarchar(250),
Completada bit not null default 0,
Fecha date,
EmpleadoId int,
constraint Fk_EmpleadoId_Tarea foreign key (EmpleadoId) references Empleado(Id)
);

insert into Tareas values ('Limpieza de estación de servicio',0,getdate(),2);
insert into Tareas values ('Actualizar listado de rutas',0,getdate(),null);

create table Incidencias(
Id int identity(1,1),
Tipo nvarchar(250),
Descripcion nvarchar(250),
Completada bit not null default 0,
Fecha date,
EmpleadoId int,
constraint Fk_EmpleadoId_Incidencias foreign key (EmpleadoId) references Empleado(Id)
);

insert into Incidencias values ('Autobús','Avería de Motor',0,getdate(),1);
insert into Incidencias values ('Pilotos','Turno de guardia 2',0,getdate(),2);
insert into Incidencias values ('"Autobús"','Avería de Motor',0,'12-03-2021',1);

select *
from Empresa;

select *
from Empleado;

select * 
from Tareas;

select * 
from Incidencias;

select * 
from Tareas;
