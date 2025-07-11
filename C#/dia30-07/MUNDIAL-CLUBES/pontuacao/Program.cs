string[] jogadores = new string[8];
int[] vitorias = new int[8];
int[] derrotas = new int[8];

int contador = 0;
int contador2 = 0;
int contador3 = 0;


while (contador <= 7)
{
    Console.WriteLine($"Insira o apelido do jogador [{contador + 1}]");
    jogadores[contador] = Console.ReadLine();
    contador = contador + 1; //contador++
    Console.Clear();

}


for (contador2 = 0; contador2 <= 7; contador2++)
{
    Console.WriteLine($"Insira o numero de vitorias do jogador[{contador2 + 1}]");
    vitorias[contador2] = int.Parse(Console.ReadLine()); // para converter entrada em int 
    Console.Clear();

}


do
{
    Console.WriteLine($"Insira o numero de derrotas do jogador [{contador3 + 1}]");
    derrotas[contador3] = int.Parse(Console.ReadLine());
    Console.Clear();
    contador3 += 1; // contador3 = contador3 + 1; contador3++ 

} while (contador3 <= 7);



