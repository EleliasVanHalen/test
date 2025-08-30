// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la longitud del terreno");
string entrada = Console.ReadLine();
int longitud = Convert.ToInt32(entrada);

int ancho = 5;
int area = longitud * ancho;

int area_manzana = area / 1428;
Console.WriteLine($"El area del terreno en varas(cuadradas) es: {area}");
Console.WriteLine($"El area del terreno en manzanas es: {area_manzana}");