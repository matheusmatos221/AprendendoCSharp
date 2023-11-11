using System;


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7");


        int idadeMatheus = 16;
        int quantidadePessoas = 2;

        if (idadeMatheus >= 16)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            if (quantidadePessoas >= 2)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
        }



        Console.WriteLine("Tecle qualquer coisa para finalizar!");
        Console.ReadLine();
    }
}
}