using System;
class Program
{
    static void Main(string[] args)
    {
        //Entrada de Dados e Declaração de variavéis
    int Idade;
    Console.WriteLine("Informe sua idade: ");
    Idade = int.Parse(Console.ReadLine());
        //Saída de Dados
        if (Idade <= 17)
        {
    Console.WriteLine("Você é menor de idade!");
        }
        else if  (Idade >= 18 && Idade <= 64)
        {
    Console.WriteLine("Você é maior de idade, porém não é idoso!");
        }
        else if (Idade >= 65)
        {
    Console.WriteLine("Você é idoso!");
        }
    }
}
     