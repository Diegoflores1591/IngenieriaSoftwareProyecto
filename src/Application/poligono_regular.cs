//Creamos la Aplicacion
namespace Application;

//Creamos la clase Poligono_regular
public class Poligono_regular
{
    //Definimos que Perimetro sera un Double que tendra como parametros el double b y el int n 
    // b = Base, n = Numero de lados, h = Altura
    public static double Perimetro (double b, int n)
    {
        // Calcula el perímetro multiplicando la base(b) por el número de lados(n)
        double perimetro = b * n;
        return perimetro;
    }
    //Definimos que Area sera un Double que tendra como parametros el double b, el int n y el double h
     // b = Base, n = Numero de lados, h = Altura
    public static double Area (double b, int n, double h)
    {
       // Calcula el área multiplicando la base(b), el número de lados(n) y la altura(h), y dividiendo el resultado entre 2
       double area = b* n *h/2;
        return area;
    }

     

}