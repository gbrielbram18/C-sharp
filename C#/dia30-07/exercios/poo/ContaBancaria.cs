namespace poo;

class ContaBancaria{
    

    public int numero;
    public string titular;
    public int saldo;
    public int depositar;
    public int saque;
    public int mostrasaldo;
    


    public void Titular(){

        if(titular=="aldalberto" ){
           
            Console.WriteLine("seja bem vindo adalberto");


        }else{
            Console.WriteLine("vc nao e o adalberto");
        }
    }

    public void Numero(){
          if(numero == 0001){
             
            Console.WriteLine("bem vindo a agencia do bando central");
          }else{
            Console.WriteLine("esta agencia nao existe ");
          }
    }


    public void Saldo() {
             Console.WriteLine($"o saldo em sua conta é: R$ {saldo}");
        
    }



public void Depositar(){
    Console.WriteLine($"seu deposito e de: R$ {depositar}");

}
public void Saque(){
    Console.WriteLine($"seu saque e de: R$ {depositar + saldo - saque}");

}
public void MostrarSaldo(){
Console.WriteLine($"o seu saldo atual é: R$ {mostrasaldo}");

}



}

