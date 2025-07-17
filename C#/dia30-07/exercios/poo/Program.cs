//Programação orientada a objetos

namespace poo;



class Program{

    static void Main(string[] args){
        

        Pessoa joao = new Pessoa(); // Instanciar novo objeto 
        Pessoa jose = new Pessoa();

        jose.nome = "jose";
        jose.idade = 60;
        jose.email = "jose123@gmail.com";

        joao.Falar();
        jose.Falar();


        Carro bumblebee = new Carro ();
        bumblebee.marca = "Chevrolet";
        bumblebee.modelo = "Camaro";
        bumblebee.ano = 2010;
        bumblebee.ligado = true;
        bumblebee.Ligar();
        bumblebee.Ligar();
        bumblebee.Desligar();
        bumblebee.Desligar();

         

        ContaBancaria Conta = new ContaBancaria();
        Conta.numero = 0001;
        Conta.titular = "adalberto";
        Conta.saldo =  10;
        Conta.depositar = 50;
        Conta.saque = 30;
        Conta.mostrasaldo = 10 + 50 - 30;
          
        Conta.Titular();
        Conta.Numero();
        Conta.Saldo();
        Conta.Depositar();
        Conta.Saque();
        Conta.MostrarSaldo();
     
        
    }
}

