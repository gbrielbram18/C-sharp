double saldo =0 ;
int opcao;

do{
    ExibirMenu();

    //opção == int.Parse (Console.Readline());
    if (int.TryParse(Console.Readline(),out opcao))
    {
        
        Console.WriteLine($"Opção selecionada {opcao}");
    }
    else
    {
        Console.WriteLine($"a {opcao} Não e uma opção valida, tente novamente.");
        Console.ReadKey();
    }
    
} while (opcao !=5);

ExibirMenu(){
Console.WriteLine("Selecione uma das opções abaixo: ");
Console.WriteLine(" 1 - Saldo ");
Console.WriteLine(" 2 -   ");
Console.WriteLine(" 3 - ");
Console.WriteLine(" 4  ");
Console.WriteLine(" 5 ");
Console.WriteLine(" 6  ");
Console.WriteLine(" 7  ");
Console.WriteLine(" 8  ");
Console.WriteLine(" 9 ");



}