# Calculator API

## Funcionalidades
* Suma de 2 numeros
* Resta de 2 numeros
* Multiplicacion de 2 numeros
* Division de 2 numeros

## Requirements
- Docker
- Net5

# Tests

## Run integration and unit tests
```
dotnet restore
dotnet build --no-restore
dotnet test --no-build /p:CollectCoverage=true /p:Exclude="[DevopsPractice.Tests.Behavior]*" /p:Threshold=80
```