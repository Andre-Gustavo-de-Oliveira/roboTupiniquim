using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a posição inicial (ex: 1 2 N):");
        string[] entrada = Console.ReadLine().Split(' ');

        int x = Convert.ToInt32(entrada[0]);
        int y = Convert.ToInt32(entrada[1]);
        char direcao = Convert.ToChar(entrada[2].ToUpper());

        Console.WriteLine("Digite a sequência de comandos:");
        string comando = Console.ReadLine().ToUpper();

        char[] instrucoes = comando.ToCharArray();

        foreach (char instrucao in instrucoes)
        {
            if (instrucao == 'E')
                direcao = VirarEsquerda(direcao);

            else if (instrucao == 'D')
                direcao = VirarDireita(direcao);

            else if (instrucao == 'M')
                Mover(ref x, ref y, direcao);
        }

        Console.WriteLine($"Posição alcançada: {x} {y} {direcao}");
    }

    static char VirarEsquerda(char direcao)
    {
        switch (direcao)
        {
            case 'N': return 'O';
            case 'O': return 'S';
            case 'S': return 'L';
            case 'L': return 'N';
            default: return direcao;
        }
    }

    static char VirarDireita(char direcao)
    {
        switch (direcao)
        {
            case 'N': return 'L';
            case 'L': return 'S';
            case 'S': return 'O';
            case 'O': return 'N';
            default: return direcao;
        }
    }

    static void Mover(ref int x, ref int y, char direcao)
    {
        switch (direcao)
        {
            case 'N': y++; break;
            case 'S': y--; break;
            case 'L': x++; break;
            case 'O': x--; break;
        }
    }
}