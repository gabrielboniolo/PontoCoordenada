using System.Globalization;

namespace Principal {
    class Program {
        static void Main(string[] args) {
            Ponto pontoA = new Ponto(15, -10);
            Ponto pontoB = new Ponto(21, 4);
            Ponto pontoC = pontoB;

            Console.WriteLine(pontoA.DistanciaIgual(pontoB));
            Console.WriteLine(pontoB.DistanciaEntreDoisPontos(pontoA).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(pontoC.DistanciaIgual(pontoB));
        }
    }
}
