
// Proporciona clases y funciones básicas de C#
using System;
// Importa el paquete Xunit 
using Xunit;
// Importa el espacio Application en donde se encuentra las clases de poligono_regular
using Application;

// Define el espacio para la prueba
namespace Application.UnitTest
{
    // Crea la clase UnitTestPoligono_regular donde se establecen los metodos de la prueba
    public class UnitTestPoligono_regular
    {
        // Define los atributos con los que se ejecutaran las pruebas
        [Theory]
        [InlineData(4, 4, 16)] // 4*4 = 16
        [InlineData(5, 6, 30)] // 5*6 = 30

        //Establece que el TestPerimetro usara b, n y perimetro
        public void TestPerimetro(double b, int n, double perimetro)
        {
            // Arrange – Set up

            // Act – Perform Calcula el perimetro utilizando el método perimetro de Poligono_regular.Perimetro
            double resultado = Poligono_regular.Perimetro(b,n); 
         
            // Assert – Verify Verifica que el resultado sea igual al calculo del perimetro
            Assert.Equal(resultado, perimetro);
        }

        // Define los atributos con los que se ejecutaran las pruebas
        [Theory]
        [InlineData(4, 4, 5, 40)] // (4*4*5)/2 = 40
        [InlineData(6, 6, 6, 108)]// (6*6*6)/2 =100

        //Establece que el TestArea usara b, n y area
        public void TestArea(double b, int n, double h, double area)
        {
            // Arrange – Set up

            // Act – Perform Calcula el resultado utilizando el método area de Poligono_regular
            double resultado = Poligono_regular.Area(b,n,h); 
           
            // Assert – Verify Verifica que el resultado sea igual al calculo del area
            Assert.Equal(resultado, area);
        }
    }
}