// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la velocidad promedio en km/h: ");

string entrada = Console.ReadLine();
int velocidad = Convert.ToInt32(entrada);
int distancia = 40;
int tiempo = distancia / velocidad;

Console.WriteLine("El tiempo total del viaje es: " + tiempo + " horas");
