
//Asignamos valores a las variables

//Le da al int n el valor de 5
int n = 5;
//Le da al double h el valor de 10
double h = 10;
//Le da al double b el valor de 10
double b = 10;

//Importamos las variables definidas en la Aplicacion (Aplication)

//Importamos la variable perimetro de la Aplicacion Perimetro_regular con sus parametros b y n
double perimetro = Application.Poligono_regular.Perimetro (b ,n);
//Importamos la variable area de la Aplicacion Perimetro_regular con sus parametros b, n y h
double area = Application.Poligono_regular.Area (b,n,h);
//Importamos la variable volumen de la Aplicacion Perimetro_regular_volumen con sus parametros area y h
double volumen = Application.Poligono_regular_volumen.Volumen(area, h);

//Pedimos a la consola que imprima 

//Pedimos que imprima el texto añadiendo las variables previamente definidas e importadas con {}
Console.WriteLine($"El perímetro de un Poligono Regular de {n} lados y base de {b}cm es de {perimetro}cm");
Console.WriteLine($"El área de un Poligono Regular {n} lados, base de {b}cm y altura de {h}cm es de {area}cm2");
Console.WriteLine($"El volumen un Poligono Regular con un área de  {area}cm2 y {h}cm de altura es {volumen}cm3");

//IMPORTANTE
//El calculo del perimetro, el area y el volumen se realiza en las aplicaciones, este modulo solo imprime los resultados