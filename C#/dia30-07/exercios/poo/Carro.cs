namespace poo;

class Carro{

    public string marca;
    public string modelo;
    public int ano;
    public bool ligado;


    public void Ligar()
    {
        if(!ligado)
        {
            ligado = true;
            Console.WriteLine("o carro foi ligado");
        }
        else
        {
        Console.WriteLine("o carro ja esta ligado");
        }


    }


public void Desligar(){

    if(ligado){
  ligado= false;
  Console.WriteLine("o carro foi desligado");


    }else {
Console.WriteLine("o carro ja eta ligado");

    }
}


public void info () {
    Console.WriteLine($"a carca do carro  e{marca}");
    Console.WriteLine($"o modelo do carro e {modelo}");
    Console.WriteLine($" o ano do carro e {ano}");


 if(ligado){
  ligado= false;
  Console.WriteLine("o carro foi desligado");


    }else {
Console.WriteLine("o carro ja eta ligado");

    } 


}
}

