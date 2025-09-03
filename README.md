# API Clientes .NET Core

## Setup del proyecto

Debe estar instalado .NET 8 SDK

```sh
cd ClienteAPI

dotnet restore
dotnet ef database update

dotnet run
```

## Desarrollo del proyecto

Puesto que no había trabajado antes en .NET fue complicado desarrollar esta API,
pero con conocimientos previos de C# poco a poco entendí los procesos.

Utilicé una base de datos SQLite por su portabilidad y para asegurar que funcione
la API en cualquier entorno.

Usé ThunderClient, una extensión de VSCode para testear la funcionalidad de la API.
