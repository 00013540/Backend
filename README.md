# This application was developed for Web Application module, as coursework portfolio project @ WIUT by student ID: 00013540

## Student matching with web-app theme:

00013540 / 20 = 677 => Remainder is 0. Therefore, the first theme which is "Task Tracker" web application was selected for CW.

## Prerequisites list:

1. Visual Studio (IDE)
2. PostgreSQL server
3. .NET 8

## Installed package names along with their versions:

1. AutoMapper.Extensions.Microsoft.DependencyInjection - Version 12.0.0
2. Microsoft.EntityFrameworkCore - Version 8.0.3
3. Microsoft.EntityFrameworkCore.Design - Version 8.0.3
4. Microsoft.EntityFrameworkCore.Tools - Version 8.0.3
5. Npgsql.EntityFrameworkCore.PostgreSQL - Version 8.0.2
6. Swashbuckle.AspNetCore - Version 6.4.0
7. Microsoft.AspNetCore.Cors Version 2.2.0

## Description of done work:

- The application was created with asp.net web api using .net8
- Data models and AppDbContext were developed to create a database using PostgreSQL
- Repository was created with corresponding interface to implement CRUD
- All services and repositories were registered in Program.cs file
- Connection string was added in appsettings.json file
- Using efcore's commands, database was created using code first approach

## Commands for migration of database:

add-migration -InitialMigration
update-database

## To run the application the following commands should be executed in order:

From tools, Package Manager Console should be opened: tools/NuGet Package Manager/Package Manager Console

After that the following commands should be executed:

1. add-migration -InitialMigration
2. update-database
3. Press "Run" button with IIS Express
