//delcarando variaveis
int jogadorA ;
int jogadorB ;

//numero  de 0 a 2 : 0 = pedra, 1= papel, 2 = tesoura
Console.WriteLine("  ");
Console.WriteLine("BEM VINDO AO PEDRA, PAREL OU TESSOURA");
Console.WriteLine("  ");
Console.WriteLine("escolha um numero de 0 a 2 ");
Console.WriteLine("_____________________________");
Console.WriteLine(" 0 = 🪨");
Console.WriteLine(" 1 = 📝");
Console.WriteLine(" 2 = ✂️");


do
{
    Console.WriteLine("digite sua jogada Jogador A: ");
    jogadorA = int.Parse(Console.ReadLine());
    Console.WriteLine("jogada do jogador A: " + jogadorA);

} while (jogadorA < 0 || jogadorA > 2);

Console.Clear();

do
{
    Console.WriteLine("digite sua jogada Jogador B: ");
    jogadorB = int.Parse(Console.ReadLine());
    Console.WriteLine("jogada do jogador B: " + jogadorB);
} while (jogadorB < 0 || jogadorB > 2);

Console.Clear();

if ((jogadorA == 0 && jogadorB == 2) || (jogadorA == 1 && jogadorB == 0) || (jogadorA == 2 && jogadorB == 1))
{
    Console.WriteLine("o jogador A e o *vencedor*!!");
}
else if (jogadorA != jogadorB)
{
    // se a jogada do jogador for diferente   da do jogador b, podemos cravar que nao ja empate
    Console.WriteLine("o jogador B e o *vencedor* !!");
}
else
{
    Console.WriteLine("o jogo empatou!!");
}
