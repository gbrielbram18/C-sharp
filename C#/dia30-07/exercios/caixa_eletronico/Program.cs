double saldo =0 ;
int opcao;

do{
    
    ExibirMenu();

    //opção == int.Parse (Console.Readline());
    if (int.TryParse(Console.Readline(),out opcao))
    {
        
        Console.WriteLine($"Opção selecionada {opcao}");
        Console.ReadKey();

        switch (opcao)
        {
            //exibir saldo
            case 1:
            Console,WriteLine("Exibir saldo");
            console.ReadKey();
            break;
            // deposito
            case 2:
            Console.WriteLine("Depositar");
            console.ReadKey();
            break;
            //Sacar
            case:3:
            Console.WriteLine("Sacar");
            console.ReadKey();
            break;
            //extrato
            case 4:
            Console.WriteLine("Extrato");
            console.ReadKey();
            break;
            // sair
            case 5:
            Console.WriteLine("Sair");
            console.ReadKey();
            break;

            default:
                Console.WriteLine("alternativa Invalida.");
            break;
        }

    }
    else
    {
        Console.WriteLine($"a {opcao} Não e uma opção valida, tente novamente.");
        Console.ReadKey();
    }
    
} while (opcao !=5);


void ExibirMenu(){


Console.WriteLine("Selecione uma das opções abaixo: ");
Console.WriteLine(" 1 - Saldo ");
Console.WriteLine(" 2 - Depositar");
Console.WriteLine(" 3 - Sacar");
Console.WriteLine(" 4 - Extrato");
Console.WriteLine(" 5 - Sair");

}



void ExibirSaldo( ){

Console.WriteLine($"Saldo atual > R$ {saldo} ")

}

void ExibirDeposito()
{
    double deposito;
    if (double.TryParse(Console.Readline(),out deposito));




}


void Sacar()
{


}

void Extrato(){

} 
