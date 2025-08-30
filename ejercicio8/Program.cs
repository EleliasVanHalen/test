// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la calificación del estudiante:");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        if (calificacion >= 70)
        {
            Console.WriteLine("El estudiante aprobó.");
        }
        else if (calificacion >= 50)
        {
            Console.WriteLine("El estudiante está en recuperación.");
        }
        else
        {
            Console.WriteLine("El estudiante reprobó.");
        }
