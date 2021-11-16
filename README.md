
# Prueba Técnica GoalSystems

Este proyecto está dividido en 3 partes:
## Frontend: 
- Se pedía una Aplicación MVC de C# que consumiese la API creada, que me parecía buen ejercicio, pero algo sencillo, en el sentido de que Visual Studio te genera ya un proyecto de tipo Web Api en el que puedes crear los modelos, y controladores con Scaffolding, de manera que genera las funciones necesarias para la llamada a la API.
- Finalmente he optado por hacer un Front en Vue.js, dado que por lo que estuvimos hablando en la entrevista anterior, el futuro de la empresa está orientado a migrar el frontend a Vue.js, me parecia una buena ocasión para mostrar como conectar ambas partes.
## Backend:
- He creado un proyecto Web_api de ASP SIN ORM, intentando simular el estilo de trabajo que puedo imaginar que utilizais actualmente, con una conexión a la BBDD mas clásico, he mapeado las tablas del modelo de datos y generado las funciones get/post/put/delete pertinentes, asi como las subyacentes get{id}/post{id} etc.
## Base de Datos:
- Se pedía una base de datos en memoria, que sé que no es más que importar el paquete de Nuguet InMemory para simular una base de datos durante el tiempo de ejecución de la aplicación.
- He creado un Docker Container con una BBDD en SqlServer, en la raíz del repositorio se adjunta un sencillo documento con los DML y DDL para la base de datos.
- Me parecia interesante simular una conexion real con una base de datos manipulable.

## Comenzando 🚀

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._

Mira **Deployment** para conocer como desplegar el proyecto.
