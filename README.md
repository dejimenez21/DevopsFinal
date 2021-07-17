# Calculator API

Este proyecto se trata de un API de calculadora aritmetica basica. A su vez es el trabajo final de la asignatura de Devops.

## Funcionalidades
* Suma de 2 numeros
* Resta de 2 numeros
* Multiplicacion de 2 numeros
* Division de 2 numeros

## Requerimientos
- Docker
- .net5.0 sdk

## Paso a paso

### Compilar
```
dotnet restore
dotnet build --no-restore
```

### Pruebas unitarias y de integracion + coverage
```
dotnet test --no-build /p:CollectCoverage=true /p:Exclude="[DevopsPractice.Tests.Behavior]*" /p:Threshold=90
```

### Ejecutar API
```
dotnet run
```

## Estrategia de ramas

Para este proyecto se utilizo una estrategia de ramas simple donde existe una rama **master** en la que se encuentra todo el codigo listo para ser desplegado, y se crean ramas **feature/*** para cualquier cambio o mejora de la aplicacion.

![branch strategy](branch-strategy.png)

## Repositorios de ejercicios

> https://github.com/dejimenez21/To-Do-Lister