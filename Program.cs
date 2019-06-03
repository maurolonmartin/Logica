using System;


namespace CuentaLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int contlet=0, contvoc = 0;
            Console.WriteLine("Por favor digite la palabra:");
            palabra = Console.ReadLine();
            palabra = palabra.ToLower();
            for (int j = 0; j< palabra.Length; j++)
                {
                contlet++;
                if ((palabra[j] == 'a') || (palabra[j] == 'e') || (palabra[j] == 'i') || 
                    (palabra[j] == 'o') || (palabra[j] == 'u'))
                    {
                        contvoc++;
                    }
                if ((palabra[j] == '1') || (palabra[j] == '2') || (palabra[j] == '3') || (palabra[j] == '4')
                   || (palabra[j] == '5') || (palabra[j] == '6') || (palabra[j] == '7') || (palabra[j] == '8')
                    || (palabra[j] == '9') || (palabra[j] == '0') || (palabra[j] == ' '))
                {
                    contlet--;
                }
                }
            Console.WriteLine("La cantidad de letras es de: "+ contlet + " y la cantidad de vocales es de: " +contvoc);
        }
    }
}
