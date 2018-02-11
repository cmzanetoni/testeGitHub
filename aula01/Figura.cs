namespace curso {
    abstract class Figura {
        public string cor { get; set; }
        public abstract double area();
        public abstract double perimetro();

        public Figura(string cor) {
            this.cor = cor;
        }
    }
}
