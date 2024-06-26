
---
# Sicer Andres Brito Gutierrez 🧑‍💻
# Nueva Estructura de nuestros proyectos NetCore <img src="https://api.nuget.org/v3-flatcontainer/microsoft.entityframeworkcore/8.0.0-preview.6.23329.4/icon" alt="img" style="width: 38px;">
Se realizaron cambios en la estructura en los proyectos NetCore para que sean mas acordes a la estructura que tiene [Solvo](https://solvoglobal.com/).

---
# Documentacion 📄
Mi objetivo con este proyecto es centrarme en el aprendizaje y el desarrollo constante de mis habilidades. Además de eso, también tengo otras metas en mente para asegurarme de que mi contribución sea lo más efectiva posible.

 - ## Estructura del Proyecto
    - 📂 En Dominio
        se crean las tablas que representan la BD.
    - 📂 En Persistencia
        se crea la instancia de conexion a la BD.
    - 📂 En Aplicacion
        se crea la inyeccion de dependecia para la comunicacion con el WebApi.
    - 📂 En WebApi
        se crean clases encargadas de recibir peticiones de los clientes.

---
<img src="./Img/Relaciones.PNG" alt="Relaciones" style="width: 3000px;">

---

# Terminal 🔓
```Terminal

Estructura Base 🚧

    1. dotnet tool install --global dotnet-ef
        --> instala la herramienta "dotnet-ef" globalmente para trabajar con Entity Framework Core.

    2. dotnet tool list -g
        --> Lista las herramientas globales instaladas en .NET.
        --> En caso de no estar desactualizado se puede actualizar mediante este comando (dotnet tool update --global dotnet-ef)

    3. dotnet new sln
        --> Crea una nueva solución de .NET.
            (Una solución (.sln) se refiere a un archivo que actúa como un contenedor para organizar y administrar proyectos relacionados en un entorno de desarrollo de .NET)

    4. dotnet new classlib -o Dominio
        --> Crea un nuevo proyecto de biblioteca de clases utilizando .NET Core y lo guarda en la carpeta "Dominio". Las bibliotecas de clases son conjuntos de código reutilizable que pueden ser referenciados y utilizados en otros proyectos .NET Core. En este caso, el nombre "Dominio" sugiere que esta biblioteca podría contener clases y lógica relacionada con el dominio central de la aplicación, como modelos y reglas de negocio

    5. dotnet new classlib -o Persistencia
        --> Crea un nuevo proyecto de biblioteca de clases utilizando .NET Core y lo guarda en la carpeta "Persistencia". Las bibliotecas de clases son conjuntos de código reutilizable que pueden ser referenciados y utilizados en otros proyectos .NET Core. En este caso, el nombre "Persistencia" sugiere que esta biblioteca podría contener clases y lógica relacionada con el acceso y la manipulación de datos, como el uso de bases de datos y almacenamiento persistente.

    6. dotnet new classlib -o Aplicacion
        --> Crea un nuevo proyecto de biblioteca de clases utilizando .NET Core y lo guarda en la carpeta "Aplicacion". Las bibliotecas de clases son conjuntos de código reutilizable que pueden ser referenciados y utilizados en otros proyectos .NET Core. En este caso, el nombre "Aplicacion" sugiere que esta biblioteca podría contener clases y lógica relacionada con la capa de aplicación, como la implementación de casos de uso y la interacción con la interfaz de usuario.

    7. dotnet new webapi -o DinoApi
        --> Crea un nuevo proyecto de API web utilizando .NET Core y lo guarda en la carpeta "DinoApi". Este comando establece las bases para crear una API utilizando el framework .NET Core, que puede ser utilizada para exponer servicios a través de HTTP.

    8. dotnet sln add Dominio/
        --> Agrega el proyecto ubicado en la carpeta "Dominio" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "Dominio" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución.

    9. dotnet sln add Persistencia/
        --> Agrega el proyecto ubicado en la carpeta "Persistencia" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "Persistencia" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución.

    10. dotnet sln add Aplicacion/
        --> Agrega el proyecto ubicado en la carpeta "Aplicacion" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "Aplicacion" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución.

    11. dotnet sln add DinoApi/
        --> Agrega el proyecto ubicado en la carpeta "DinoApi" al archivo de solución actual de .NET Core. Esto permite incluir el proyecto "DinoApi" dentro de la solución y facilita la gestión de múltiples proyectos en un mismo contexto de desarrollo. Es útil cuando se tiene una solución que consta de varios proyectos y se quiere mantener todo organizado en una estructura de solución.




Referencias 🔗

    1. cd Aplicacion/
        - dotnet add reference ../Dominio/
            --> Agrega una referencia al proyecto "Dominio" desde el proyecto "Aplicacion". Al hacer esto, el proyecto "Aplicacion" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Dominio". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de aplicación depende de lógica y modelos definidos en el proyecto de dominio.
        - dotnet add reference ../Persistencia/
            --> Agrega una referencia al proyecto "Persistencia" desde el proyecto "Aplicacion". Al hacer esto, el proyecto "Aplicacion" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Persistencia". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de aplicación necesita interactuar con la capa de persistencia, por ejemplo, para realizar operaciones de acceso a base de datos.
    
    2. cd DinoApi/
        - dotnet add reference ../Aplicacion/
            --> Agrega una referencia al proyecto "Aplicacion" desde el proyecto "DinoApi". Al hacer esto, el proyecto "DinoApi" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Aplicacion". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de la API necesita interactuar con la capa de aplicación para exponer funcionalidades a través de la interfaz de la API.

    3. cd Persistencia/
        - dotnet add reference ../Dominio/
            --> Agrega una referencia al proyecto "Dominio" desde el proyecto "Persistencia". Al hacer esto, el proyecto "Persistencia" podrá acceder y utilizar las clases y funcionalidades proporcionadas por el proyecto "Dominio". Esto es útil cuando se tiene una estructura de capas en la que el proyecto de persistencia necesita acceder a los modelos y reglas de negocio definidos en el proyecto de dominio.


```
---
<img src="https://1.bp.blogspot.com/-epbYlUPl2-c/Xh6loHanlbI/AAAAAAAACpI/Ift8Ukv9AbQVIHl2aKTLMjr-LA25WN8lwCLcBGAsYHQ/s1600/ASP.NET%2BCore.jpg" alt="https://1.bp.blogspot.com/-epbYlUPl2-c/Xh6loHanlbI/AAAAAAAACpI/Ift8Ukv9AbQVIHl2aKTLMjr-LA25WN8lwCLcBGAsYHQ/s1600/ASP.NET%2BCore.jpg" style="width: 3000px;">

---


# Gestion de Datos 🧑‍💻

 - ## Instalacion de Paquetes 🔧
     - Dominio 📂
        - dotnet add package Microsoft.EntityFrameworkCore --version 7.0.9
        - dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 11.1.0
        - dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1
        - dotnet add package FluentValidation.AspNetCore --version 11.3.0
        - dotnet add package itext7.pdfhtml --version 5.0.0


     - Persistencia 📂
        - dotnet add package Microsoft.EntityFrameworkCore --version 7.0.9
        - dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
        - dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.9
        - dotnet add package Dapper --version 2.0.143

     - DinoApi 📂
        - dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.9
        - dotnet add package Newtonsoft.Json --version 13.0.3
        - dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 7.0.9
        - dotnet add package Swashbuckle.AspNetCore --version 6.5.0



 - ## Migrations ✈️
    - dotnet ef migrations add InitialCreate --project ./Persistencia/ --startup-project ./DinoApi/ --output-dir ./Data/Migrations
    - dotnet ef database update --project ./Persistencia/ --startup-project ./DinoApi/

---
