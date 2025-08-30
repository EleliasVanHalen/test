// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el volumen promedio de leche por vaca (en litros):");
double litrosPorVaca = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el número total de vacas ordeñadas:");
int numeroDeVacas = Convert.ToInt32(Console.ReadLine());

double totalLitros = litrosPorVaca * numeroDeVacas;
double totalBaldes = totalLitros / 20;
Console.WriteLine("La cantidad total de baldes de leche producida es: " + totalBaldes);