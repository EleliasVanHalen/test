// See https://aka.ms/new-console-template for more informationConsole.WriteLine("Ingrese la longitud del tanque en metros:");
Console.WriteLine("Ingrese la longitud del tanque en metros:");
double longitud = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el ancho del tanque en metros:");
double ancho = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese la altura del tanque en metros:");
double altura = Convert.ToDouble(Console.ReadLine());

double volumen = longitud * ancho * altura;
Console.WriteLine("El volumen total de agua recolectada es: " + volumen + " metros cúbicos.");