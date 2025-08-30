// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un año:");
        int año = Convert.ToInt32(Console.ReadLine());

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
        {
            Console.WriteLine("El año " + año + " es bisiesto.");
        }
        else
        {
            Console.WriteLine("El año " + año + " no es bisiesto.");
        }