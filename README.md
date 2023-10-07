# Microservices Bookshop

## Descripción
Este proyecto es un microservicio desarrollado en .NET Core 5 que utiliza Docker para contenerizar las aplicaciones y bases de datos necesarias. El servicio se comunica con bases de datos MongoDB y SQL Server, y utiliza Angular para la interfaz de usuario.

## Requisitos Previos
Asegúrate de tener las siguientes herramientas instaladas antes de comenzar:
- [.NET Core 5](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Docker](https://www.docker.com/get-started)
- [Node.js](https://nodejs.org/) y [Angular CLI](https://cli.angular.io/)
- (Opcional) [Visual Studio Code](https://code.visualstudio.com/) u otro IDE de tu elección.

## Configuración del Entorno
1. Clona este repositorio en tu máquina local.
2. Abre el proyecto en tu IDE preferido (si estás utilizando Visual Studio Code, puedes abrir la carpeta del proyecto directamente).
3. Asegúrate de que Docker esté en funcionamiento.

## Ejecución del Microservicio
Siga estos pasos para ejecutar el microservicio:

1. Navega a la carpeta del proyecto en tu terminal.
2. Ejecuta el siguiente comando para construir las imágenes de Docker:

   ```bash
   docker-compose build

## Inicie los contendores Docker con el siguiente comando:
1. docker-compose up

