using System;

class Program
{
    static void Main()
    {
        int cont = 0;

        for (int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                cont++;
            }
        }

        Console.WriteLine(cont + " valores pares");
    }
}
