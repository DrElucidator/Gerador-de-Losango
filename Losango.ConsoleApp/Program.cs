using System;

class program
{
    static void Main(string[] arg)
    {
        int Input;
        do
        {
            System.Console.WriteLine("Digite um número ímpar para gerar um losango do tamanho correspondente:");
            Input = Convert.ToInt32(Console.ReadLine());

            if (Input % 2 == 0)
            {
                System.Console.WriteLine("Digite um número válido");
                continue;
            }
        } while (Input % 2 == 0);
        int UpperLine = (Input - 1) / 2;
        int SizeX = 1;
        int SizeY = UpperLine;
        for (int i = 0; i <= UpperLine; i++)
        {
            Console.Write(new string(' ', SizeY * 2));
            for (int x = 0; x < SizeX; x++)
            {
                Console.Write("X");
                if (x < SizeX - 1) Console.Write(" ");
            }
            Console.WriteLine();
            SizeX += 2;
            SizeY -= 1;
        }
        SizeX = Input - 2;
        SizeY = 1;
        for (int i = 0; i < UpperLine; i++)
        {
            Console.Write(new string(' ', SizeY * 2));
            for (int x = 0; x < SizeX; x++)
            {
                Console.Write("X");
                if (x < SizeX - 1) Console.Write(" ");
            }
            Console.WriteLine();

            SizeX -= 2;
            SizeY += 1;
        }
    }
}