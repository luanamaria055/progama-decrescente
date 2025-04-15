using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números no intervalo [10, 20] em ordem decrescente:");

        int numero = 20; // Começamos pelo maior número do intervalo

        while (numero >= 10) // Enquanto o número for maior ou igual a 10
        {
            Console.WriteLine(numero); // Imprime o número atual
            numero--; // Decrementa para o número anterior
        }

        Console.WriteLine("Fim do intervalo.");
        Console.ReadLine(); // Para manter a janela aberta no Visual Studio
    }
}
