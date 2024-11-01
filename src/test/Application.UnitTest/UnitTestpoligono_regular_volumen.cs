
// Proporciona clases y funciones básicas de C#
using System;
// Importa el paquete Xunit 
using Xunit;
// Importa el espacio Application en donde se encuentra las clases de poligono_regular
using Application;

// Define el espacio para la prueba
namespace Application.UnitTest;

// Crea la clase UnitTestPoligono_regular_volumen donde se establecen los metodos de la prueba
public class UnitTestPoligono_regular_volumen
{
     // Define los atributos con los que se ejecutaran las pruebas   
    [Theory]
    [InlineData(16, 4, 64)] // (16*4) = 64
    [InlineData(25, 6, 150)]// (25*6) = 150

    //Establece que el TestVolumen usara Area, h y volumen
    public void TestVolumen(double Area, double h, double Volumen)
    {
        // Arrange – Set up
      
        // Act – Perform Calcula el volumen utilizando el método Volumen de Poligono_regular_volumen
        double resultado = Poligono_regular_volumen.Volumen(Area, h);

        // Assert – Verify Verifica que el resultado sea igual al calculo del volumen
        Assert.Equal(resultado, Volumen);
    }
}