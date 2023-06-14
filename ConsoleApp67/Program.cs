using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1, b = 2;
        int c = 3;

        if ((a + b + c > 10) && (a > b))
        {
            Console.WriteLine("Raspunsul este mai mare decat 10");
            Console.WriteLine("Si primul numar este mai mare decat al doilea");
        }
        else
        {
            Console.WriteLine("Raspunsul nu este mai mare decat 10");
            Console.WriteLine("Sau primul numar nu este mai mare decat al doilea");
        }

        Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

        // Functionalitati aditionale

        int produs = CalculeazaProdus(a, b, c);
        Console.WriteLine("Produsul lui a, b si c: " + produs);

        int medie = CalculeazaMedie(a, b, c);
        Console.WriteLine("Media lui a, b si c: " + medie);

        bool existaNegativ = VerificaExistentaNegativ(a, b, c);
        Console.WriteLine("Exista vreun numar negativ? " + existaNegativ);

        bool toatePare = VerificaToatePare(a, b, c);
        Console.WriteLine("Sunt toate numerele pare? " + toatePare);

        int maxim = GasesteMaxim(a, b, c);
        Console.WriteLine("Maximul dintre a, b si c: " + maxim);

        int minim = GasesteMinim(a, b, c);
        Console.WriteLine("Minimul dintre a, b si c: " + minim);

        int sumaNumerelor = CalculeazaSumaNumerelor(1, produs);
        Console.WriteLine("Suma numerelor de la 1 la " + sumaNumerelor + ": " + SumaNumerelor(1, sumaNumerelor));

        int fibonaciNumarulN = CalculeazaNumarulFibonacci(10);
        Console.WriteLine("Numarul Fibonacci de pe pozitia 10: " + fibonaciNumarulN);

        string invers = InverseazaString("Hello, world!");
        Console.WriteLine("Inversul stringului 'Hello, world!': " + invers);

        int factorial = CalculeazaFactorial(5);
        Console.WriteLine("Factorialul lui 5: " + factorial);

        Console.ReadKey();
    }

    private static int CalculeazaProdus(params int[] numere)
    {
        int produs = 1;
        foreach (int num in numere)
        {
            produs *= num;
        }
        return produs;
    }

    private static int CalculeazaMedie(params int[] numere)
    {
        int suma = 0;
        foreach (int num in numere)
        {
            suma += num;
        }
        return suma / numere.Length;
    }

    private static bool VerificaExistentaNegativ(params int[] numere)
    {
        foreach (int num in numere)
        {
            if (num < 0)
            {
                return true;
            }
        }
        return false;
    }

    private static bool VerificaToatePare(params int[] numere)
    {
        foreach (int num in numere)
        {
            if (num % 2 != 0)
            {
                return false;
            }
        }
        return true;
    }

    private static int GasesteMaxim(params int[] numere)
    {
        int maxim = int.MinValue;
        foreach (int num in numere)
        {
            if (num > maxim)
            {
                maxim = num;
            }
        }
        return maxim;
    }

    private static int GasesteMinim(params int[] numere)
    {
        int minim = int.MaxValue;
        foreach (int num in numere)
        {
            if (num < minim)
            {
                minim = num;
            }
        }
        return minim;
    }

    private static int CalculeazaSumaNumerelor(int start, int end)
    {
        int suma = 0;
        for (int i = start; i <= end; i++)
        {
            suma += i;
        }
        return suma;
    }

    private static int SumaNumerelor(int start, int end)
    {
        return (end - start + 1) * (start + end) / 2;
    }

    private static int CalculeazaNumarulFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
    }

    private static string InverseazaString(string text)
    {
        char[] array = text.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    private static int CalculeazaFactorial(int n)
    {
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}
