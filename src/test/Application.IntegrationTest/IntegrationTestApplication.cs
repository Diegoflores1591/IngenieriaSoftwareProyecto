
// Proporciona clases y funciones básicas de C#
using System;
// Importa el paquete Xunit 
using Xunit;
// Importa el espacio Application en donde se encuentra las clases de poligono_regular
using Application;

// Define el espacio para la prueba
namespace Application.IntegrationTest;

// Crea la clase IntegrationTestApplication donde se establecen los metodos de la prueba
public class IntegrationTestApplication
{
 // Define los atributos con los que se ejecutaran las pruebas   
 [Theory]
    [InlineData(4, 4, 5)] //(4*4*5)/2 = Area
    [InlineData(5, 6, 3)]  //(5*6*3)/2 = Area

    //Estabece que el TestVolumen usara b, n y h
    public void TestVolumen(double b, int n, double h) 
    {
        // Arrange – Set up: Calcula el resultadoArea utilizando el método Area de Poligono_regular
        double resultadoArea = Poligono_regular.Area(b, n, h);

        // Act – Perform: Calcula el resultadoVolumen utilizando el método Volumen de Poligono_regular_volumen
        double resultadoVolumen = Poligono_regular_volumen.Volumen(resultadoArea,h);
        
        // Compara que el double resultadoArea multiplicado por h, es igual al resultadoVolumen
        // resultadoArea = (b*n*h)
        // resultadoVolumen = (resultadoArea*h)
        Assert.Equal(resultadoArea*h, resultadoVolumen);
    }
}