# Proyecto de Ingeniería de Software - Equipo 7

Somos el **Equipo 7** y nuestro proyecto consiste en el cálculo del perímetro, área y volumen de un polígono regular de *n* lados.

## Cálculo del Perímetro y del Área
La implementación para calcular el perímetro y el área se encuentra en el archivo:
- [`src/Application/Poligono_Regular.cs`](https://github.com/Diegoflores1591/IngenieriaSoftwareProyecto/blob/main/src/Application/poligono_regular.cs)

## Cálculo del Volumen
La implementación para calcular el volumen se encuentra en el archivo:
- [`src/Application/Poligono_Regular_Volumen.cs`](https://github.com/Diegoflores1591/IngenieriaSoftwareProyecto/blob/main/src/Application/poligono_regular_volumen.cs)

## Mostrar en Consola
Para visualizar los resultados en la consola, hemos desarrollado el siguiente archivo:
- [`src/ConsoleApp/Program.cs`](https://github.com/Diegoflores1591/IngenieriaSoftwareProyecto/blob/main/src/ConsoleApp/Program.cs)

## Mostrar en Web
Para mostrar los resultados en una interfaz web, se utiliza el archivo:
- [`src/WebApp/Pages/Index.cshtml`](https://github.com/Diegoflores1591/IngenieriaSoftwareProyecto/blob/main/src/WebApp/pages/Index.cshtml)

## Pruebas xUnit

### Pruebas del Cálculo del Perímetro y del Área
Las pruebas unitarias para los cálculos del perímetro y el área se encuentran en:
- [`src/test/Application.UnitTest/UnitTestPoligono_regular.cs`](https://github.com/Diegoflores1591/IngenieriaSoftwareProyecto/blob/main/src/test/Application.UnitTest/UnitTestPoligono_regular.cs)

### Pruebas del Cálculo del Volumen
Las pruebas unitarias para el cálculo del volumen están en:
- [`src/test/Application.UnitTest/UnitTestpoligono_regular_volumen.cs`](https://github.com/Diegoflores1591/IngenieriaSoftwareProyecto/blob/main/src/test/Application.UnitTest/UnitTestpoligono_regular_volumen.cs)

### Pruebas de Integración
Las pruebas de integración que validan el funcionamiento conjunto del sistema se encuentran en:
- [`src/test/Application.IntegrationTest/IntegrationTestApplication.cs`](https://github.com/Diegoflores1591/IngenieriaSoftwareProyecto/blob/main/src/test/Application.IntegrationTest/IntegrationTestApplication.cs)

## Estructura del Proyecto

```plaintext
src
├── Application
│   ├── Poligono_Regular.cs             # Cálculo del perímetro y área
│   ├── Poligono_Regular_Volumen.cs     # Cálculo del volumen
├── ConsoleApp
│   └── Program.cs                      # Mostrar en consola
├── WebApp
│   └── Pages
│       └── Index.cshtml                # Mostrar en web
└── test
    ├── Application.UnitTest
    │   ├── UnitTestPoligono_regular.cs         # Pruebas perímetro y área
    │   └── UnitTestpoligono_regular_volumen.cs # Pruebas volumen
    └── Application.IntegrationTest
        └── IntegrationTestApplication.cs       # Pruebas de integración
