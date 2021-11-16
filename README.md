
# Prueba Técnica GoalSystems

Este proyecto está dividido en 3 partes:
## Frontend: 
- Se pedía una Aplicación MVC de C# que consumiese la API creada, que me parecía buen ejercicio, pero algo sencillo, en el sentido de que Visual Studio te genera ya un proyecto de tipo Web Api en el que puedes crear los modelos, y controladores con Scaffolding, de manera que genera las funciones necesarias para la llamada a la API.
- Finalmente he optado por hacer un Front en Vue.js, dado que por lo que estuvimos hablando en la entrevista anterior, el futuro de la empresa está orientado a migrar el frontend a Vue.js, me parecia una buena ocasión para mostrar como conectar ambas partes y usar Axios para las conexiones a la API creando yo mismo todos los métodos de conexión.
## Backend:
- He creado un proyecto Web_api de ASP SIN ORM, intentando simular el estilo de trabajo que puedo imaginar que utilizais actualmente, con una conexión a la BBDD mas clásico, he mapeado las tablas del modelo de datos y generado las funciones get/post/put/delete pertinentes, asi como las subyacentes get{id}/post{id} etc.
## Base de Datos:
- Se pedía una base de datos en memoria, que sé que no es más que importar el paquete de Nuguet InMemory para simular una base de datos durante el tiempo de ejecución de la aplicación.
- He creado un Docker Container con una BBDD en SqlServer, en la raíz del repositorio se adjunta un sencillo documento con los DML y DDL para la base de datos.
- Me parecia interesante simular una conexion real con una base de datos manipulable.

## Comenzando 🚀

_Es importante recordar que sin una base de datos en un docker y cambiando la cadena de conexión en el **appsettings.json** no se va a poder ver en pleno funcionamiento el frontend, así como los valores devueltos por el Backend._

Una vez clonado el repositorio, accedemos a la carpeta que contiene el proyecto de Visual Studio para poner la API en funcionamiento.
Como inicio arrancará con el endpoint: **http://localhost:32110/api/Empleado**

![image](https://user-images.githubusercontent.com/94412083/142030732-53e4deab-088e-4860-8456-3afea430df2b.png)

**En caso de tener datos y una base de datos con conexión se mostraría como se observa en la foto anterior la respuesta incial con los datos de los Empleados de la base de datos**

