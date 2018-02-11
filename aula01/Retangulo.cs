namespace curso {
    class Retangulo : Figura {
        public double altura { get; set; }
        public double largura { get; set; }

        public Retangulo(double a, double b, string cor) : base(cor) {
            this.altura = a;
            this.largura = b;
        }

        public override double area() {
            return altura * largura;
        }

        public override double perimetro() {
            return 2 * (altura + largura);
        }
    }
}
