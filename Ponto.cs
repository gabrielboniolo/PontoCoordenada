namespace Principal {
    class Ponto {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Ponto() {

        }
        public Ponto(int x, int y) {
            X = x;
            Y = y;
        }

        public bool DistanciaIgual(Ponto outroPonto) {
            return X == outroPonto.X && Y == outroPonto.Y;
        }

        public double DistanciaEntreDoisPontos(Ponto outroPonto) {
            int deltaX = X - outroPonto.X;
            int deltaY = Y - outroPonto.Y;
            return Math.Sqrt(Math.Pow(deltaX,2) + Math.Pow(deltaY,2));
        }
    }
}