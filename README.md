
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

# Iniciando la API 🛠️

Una vez clonado el repositorio, accedemos a la carpeta que contiene el proyecto de Visual Studio para poner la API en funcionamiento.
Como inicio arrancará con el endpoint: **http://localhost:32110/api/Empleado**

![image](https://user-images.githubusercontent.com/94412083/142030732-53e4deab-088e-4860-8456-3afea430df2b.png)

**En caso de tener datos y una base de datos con conexión se mostraría como se observa en la foto anterior la respuesta incial con los datos de los Empleados de la base de datos**

# Iniciando el Cliente 🛠️

Una vez Arrancado,nos situamos  dentro del proyecto de Fontend en Vue.js y desde consola ejecutaremos **npm intall** para descargar todos los paquetes de node necesarios.
Seguidamente podremos arrancar el proyecto usando: **npm run serve**
Tras cargar todos los módulos de node será accesible desde: **http://localhost:8080/**

_Siendo un front sencillo, se ha hecho responsive con la librería de Bootstrap, sé que usais Material, pero por razones de tiempo, obvias, he optado por usar lo que ya conocía_

**Al arrancar el proyecto vemos:**
![image](https://user-images.githubusercontent.com/94412083/142031994-32ce1212-946f-40e5-8506-51223414bd14.png)


-Todos los apartados permiten la creación de elemento, no se ha implementado Actualización, pero sí Eliminación de Incidencias y Tareas

**Breve ejemplo  de la vista que muestra las empresas y formulario de creación**
 ![image](https://user-images.githubusercontent.com/94412083/142032266-f37544b2-fa74-496f-b4ab-ef1f78aa46b2.png)
 ![image](https://user-images.githubusercontent.com/94412083/142032294-ccf1b201-1a3e-4336-83fa-44725c8a8377.png)


**Vistas de Empleados**
![image](https://user-images.githubusercontent.com/94412083/142032400-ee0360f5-8a52-4d36-b4d1-aa890808751d.png)
![image](https://user-images.githubusercontent.com/94412083/142032442-e80674fa-f003-460a-b28f-866309350836.png)


**Vistas de Incidencias ( acceso a detalle de cada incidencia /tarea, la navegación es similar en ambos tipos)**
 ![image](https://user-images.githubusercontent.com/94412083/142032612-86d27604-8dae-4800-8ad5-b7e14c6b9ee7.png)
 ![image](https://user-images.githubusercontent.com/94412083/142032942-369e34ac-7472-439a-92b4-fc120137644c.png)
 ![image](https://user-images.githubusercontent.com/94412083/142033358-69b95623-229d-429b-b1ce-d1c152c0f127.png)

**Se han creado alertas con redirecciones avisando de cada inserción o eliminación de elementos**

# Respuestas de la Prueba Técnica ✒️

## 1.2	NOTIFICAR QUE SE HA CREADO UNA INCIDENCIA A UN EMPLEADO
- En este caso se ha creado vagamente una alerta en el Frontend avisando al usuario y redireccionando, pero con tiempo, lo correcto seria usar **un bus de eventos** de manera que dispare un evento que pueda ser capturado desde cualquier parte de la aplicación para ser tratado.

## 1.3	BASE DE DATOS

![image](https://user-images.githubusercontent.com/94412083/142037266-7c22867f-6a04-45b8-8d4d-2c75cc198136.png)

- He usado el diseñador de Diagramas de SQL:


![image](https://user-images.githubusercontent.com/94412083/142038307-95fb5154-6d5d-414e-a8fa-366567e3acbc.png)


- No he tenido tiempo de implementar una función que obtenga un Excel de los datos deseados, pero con el material de referencia de Microsoft se podria conseguir facilmente:

**https://docs.microsoft.com/es-es/previous-versions/office/troubleshoot/office-developer/automate-excel-using-visual-c-fill-data**

## 1.4	 SEGURIDAD
- Me hubiera gustado tener tiempo de implementar también varios tipos de seguridad, en primer lugar, habria usado la libreria de asp.Net **Identity** para habilitar el acceso mediante roles.
- El siguiente paso habria sido Implementar la seguridad para los endpoints mediante JWT (Java Web Token) generando un toque que fiese verificado en el backend habilitando el envio y recepción de datos.




