// See https://aka.ms/new-console-template for more information


//atividade 2.1

/*

1. Faça um programa que leia dois **números inteiros** e verifique qual deles é **maior**. Imprima uma mensagem informando qual deles é o maior e qual é o menor.
    1. Acrescente mais números na solicitação para o usuário.
*/


/*
Console.WriteLine( "Insira o primeiro número: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine( "Insira o segundo número: ");
int y = int.Parse(Console.ReadLine());

if ( x > y ) {
    // Bloco de código que será executado caso a condição seja verdadeira {}
    Console.WriteLine( "O primeiro número é maior que o segundo.");
} else if ( x == y ) {
    // Bloco de código que será executado caso a segunda condição seja verdadeira {}
    Console.WriteLine( "O primeiro e o segundo número são iguais.");
} else {
    // Bloco de código que será executado caso nenhuma das condições anteriores seja verdadeira {}
    Console.WriteLine( "O segundo número é maior que o primeiro." );
}


*/

//exercicio 2.2

/*

Crie um código que delcare 3 variáveis: nota1, nota2 e nota3; 
Atribua um valor de 0 a 10 a cada uma. 
Calcule a média aritmética do aluno e exiba se o aluno foi aprovado utilizando 
uma estrutura condicional. (Sabendo que a média necessária a ser alcançada é 6)


*/



/*

int nota1 = 6;
int nota2 = 7;
int nota3 = 3;
int media = (nota1 + nota2 + nota3) / 3; // Envolver em parênteses por conta da precedência de operadores

Console.WriteLine( "A média de notas do aluno foi: ");
Console.WriteLine( media );

if ( media >= 6 ) {
    Console.WriteLine("Aluno aprovado!");
} else {
    Console.WriteLine("Aluno reprovado!");
}


*/



//exercicio 2.3


/*
Crie um código que declara 2 variáveis frutaA e frutaB; Atribua um valor de string a cada uma 
delas com o nome de uma fruta e exiba uma mensagem caso
 as frutas sejam iguais e outra caso 
as frutas sejam diferentes.

*/

/*

string frutaA = "Pitaya";
string frutaB = "Pequi";

if ( frutaA == frutaB ) {
    Console.WriteLine( "Sim, as frutas são iguais" );
} else {
    Console.WriteLine( "Não, não são a mesma fruta" );
}

*/






// exercicio 2.4

/*
Escreva um algoritmo que tenha as variáveis A, B, C e imprima na tela se a soma de A + B é menor
que C.

*/


/*
int A = 9;
int B = 20;
int C = 30;

int soma = A + B;

if ( soma < C ) {
    Console.WriteLine("A soma de " + A + " + " + B + " é menor que " + C);
    Console.WriteLine("Soma: " + soma);
} else {
    Console.WriteLine("A soma de " + A + " + " + B + " não é menor que " + C);
}

*/


//exercicio 2.5



/*
Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se
somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se
atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

*/




int A = int.Parse(Console.ReadLine()); // int.Parse() para interpretar a entrada como um inteiro
int B = int.Parse(Console.ReadLine());
int C; // Declaração sem atribuição de valor

if ( A == B ) {
    C = A + B;
} else {
    C = A * B;
}

Console.WriteLine( C );


