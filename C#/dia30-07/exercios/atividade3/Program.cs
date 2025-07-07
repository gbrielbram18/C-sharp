//exercicio 3.1


/*
Escreva um programa que imprima os números de 1 a 10, um em cada linha.
*/


//resolução com **do-while

/*
int contador = 1;

do
{
    Console.WriteLine(contador);
    contador++; // contador = contador + 1;
} while (contador < 11);
*/

// resolução com while
/*
contador = 1;

while (contador <= 10)
{
    Console.WriteLine(contador);
    contador++; // contador == contador +1
}while (contador < 11) ;
*/

// resolução com for

/*
for (int cont = 1; cont <= 10; cont++)
{
    //bloco de codigo a ser executado enquanto a condição for verdadeira 
    Console.WriteLine(cont);
}
*/


//excercicio 3.2


/*
Solicite ao usuário um número inteiro
positivo N e calcule a soma de todos os números de 1 até N.

*/

/*
Console.WriteLine("digite um numero positivo ");
int x = int.Parse(Console.ReadLine());


Console.WriteLine("digite mais um numero: ");
int y = int.Parse(Console.ReadLine());


int resultado = x + y;

Console.WriteLine($"o resultado do  caulculo {x} + {y} e: ", resultado);
Console.WriteLine(resultado);


Console.WriteLine("soma do numero em loop: ");
int contador = 1;

while (contador < resultado)
{
    Console.WriteLine(contador);
    contador++; // contador = contador + 1
}

*/

// exercicio 3.3


/*

Solicite ao usuário um número inteiro e mostre a tabuada desse número, do 1 ao 10.

*/


Console.WriteLine (" digite um numero para sua tabuada");
int x = int.Parse(Console.ReadLine());

int cont = 0;

int resultado = x * cont  ;

do
{
    Console.WriteLine($"o calculo de multipilicação entre{x} X {cont} e: " + resultado);
    cont++; // contador = contador + 1;
    resultado= cont * x;    



} while (cont <= 11);


