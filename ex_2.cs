using System;

class Calculadora {

  public static int calculadora (int a,int b) { 
    int soma;
    soma = a + b;
    return soma;
  }

  public static void Main (string[] args) {
    int a,b,soma;

    Console.WriteLine("Digite o primeiro número inteiro");
    a = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número inteiro");
    b = int.Parse(Console.ReadLine());

    soma = calculadora(a,b);

    Console.WriteLine("O resultado é:" + soma);
  }
}