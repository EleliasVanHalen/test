// See https://aka.ms/new-console-template for more information Console.WriteLine("Ingrese la velocidad promedio en km/h: ");
Console.WriteLine("Ingrese la velocidad promedio en km/h: ");

string entradaVelocidad = Console.ReadLine();
int velocidad = Convert.ToInt32(entradaVelocidad);

Console.WriteLine("Ingrese el tiempo recorrido en horas: ");
string entradaTiempo = Console.ReadLine();
int tiempo = Convert.ToInt32(entradaTiempo);


int distancia = velocidad * tiempo;

Console.WriteLine("La distancia total recorrida es: " + distancia + " km");