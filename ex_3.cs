using System;
using System.Linq;

class Medias {

  public static void CalcMedia (int QtdNotas) {
    float media;
    float[] notas = new float[QtdNotas];

    for (int i = 0; i< notas.Length; i++) {
      float a;
      Console.WriteLine("Digite a " + (i+1) +"ª nota");
      a = float.Parse(Console.ReadLine());
      notas[i] = a;
    };

    media = notas.Sum()/notas.Length;

    Console.WriteLine("A média é: "+ media);

  }

  public static void Main (string[] args) {
    Console.WriteLine("Qual a quantidade de notas a ser calculada?");
    int QtdNotas = int.Parse(Console.ReadLine());
    CalcMedia(QtdNotas);
  }
}