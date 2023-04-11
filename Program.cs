using System;
class Program
{
    static void Main(string[]args)
    {
    Console.WriteLine("Digite o número para calcular a tabuada: ");
    Console.Write("Essa é a tabuada do ");
    int numero = Convert.ToInt16(Console.ReadLine());
    int tabuada = 0;

    while(tabuada <= 10)
    {
        int resultado = tabuada * numero;
        Console.WriteLine(tabuada+" x "+numero+" = "+resultado);
        tabuada++;
    }
    
    Console.WriteLine("Pressione qualquer tecla para encerrar");
    Console.ReadKey();
    }
    
}
