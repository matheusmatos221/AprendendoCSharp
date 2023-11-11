using System;
class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos!");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(66+ 1);
        Console.WriteLine(letra);

        letra = (char)(76+ 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Minha frase exemplo";
        Console.WriteLine(primeiraFrase);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos);


        Console.WriteLine("Tecle qualquer tecla para fechar");
        Console.ReadLine();

    }
}



