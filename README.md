
---
# Nueva Estructura de nuestros proyectos NetCore <img src="https://api.nuget.org/v3-flatcontainer/microsoft.entityframeworkcore/8.0.0-preview.6.23329.4/icon" alt="img" style="width: 38px;">
**Se realizaron cambios en la estructura en los proyectos NetCore para que sean mas acordes a la estructura que tiene Solvo.**

---
# Instalaciones

    Dominio 📂
        - dotnet add package Microsoft.EntityFrameworkCore --version 7.0.9
        - dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 11.1.0
        - dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1
        - dotnet add package FluentValidation.AspNetCore --version 11.3.0
        - dotnet add package itext7.pdfhtml --version 5.0.0


    Persistencia 📂
        - dotnet add package Microsoft.EntityFrameworkCore --version 7.0.9
        - dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0
        - dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.9
        - dotnet add package Dapper --version 2.0.143

    DinoApi 📂
        - dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.9
        - dotnet add package Newtonsoft.Json --version 13.0.3
        - dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 7.0.9
        - dotnet add package Swashbuckle.AspNetCore --version 6.5.0


---
# Migrations
    - dotnet ef migrations add InitialCreate --project ./Persistencia/ --startup-project ./DinoApi/ --output-dir ./Data/Migrations
    - dotnet ef database update --project ./Persistencia/ --startup-project ./DinoApi/
