//Creamos la Aplicacion
namespace Application;
//Creamos la clase Poligono_regular_volumen
public class Poligono_regular_volumen
{
 //Definimos que Volumen sera un Double que tendra como parametros el double area y el double h 
    public static double Volumen(double Area, double h)
    {
        //Calcula el valor del area multiplicando el area(Area) por la altura(h) 
        double volumen = Area * h;
        return volumen;
    }
}