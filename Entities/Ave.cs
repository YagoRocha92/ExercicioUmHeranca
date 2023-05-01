namespace ExercicioUmHeranca.Entities
{
    public class Ave : Animal
    {
        public string Bico { get; private set; }
        public Ave(string name, string especie, string genero, string bico) : base(name, especie, genero)
        {
            Bico = bico;
        }

        public void Voar()
        {
            Console.WriteLine("Está Voando");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Emite um som especifico de ave");
        }

        public override string ToString()
        {
            return "Nome: " + Name +
                   ", seu genero é: " + Genero +
                   ", sua especie é: " + Especie +
                   " e seu Bico é: " + Bico;
        }

    }
}
