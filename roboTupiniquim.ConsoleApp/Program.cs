using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a posição inicial (ex: 1 2 N):");
        string[] entrada = Console.ReadLine().Split(' ');

        int x = int.Parse(entrada[0]);
        int y = int.Parse(entrada[1]);
        char direcao = entrada[2].ToUpper()[0];

        Console.WriteLine("Digite a sequência de comandos:");
        string comando = Console.ReadLine().ToUpper();

        foreach (char instrucao in comando)
        {
            if (instrucao == 'E')
            {
                if (direcao == 'N') direcao = 'O';
                else if (direcao == 'O') direcao = 'S';
                else if (direcao == 'S') direcao = 'L';
                else if (direcao == 'L') direcao = 'N';
            }
            else if (instrucao == 'D')
            {
                if (direcao == 'N') direcao = 'L';
                else if (direcao == 'L') direcao = 'S';
                else if (direcao == 'S') direcao = 'O';
                else if (direcao == 'O') direcao = 'N';
            }
            else if (instrucao == 'M')
            {
                if (direcao == 'N') y++;
                else if (direcao == 'S') y--;
                else if (direcao == 'L') x++;
                else if (direcao == 'O') x--;
            }
        }

        Console.WriteLine($"Posição alcançada: {x} {y} {direcao}");
    }
}