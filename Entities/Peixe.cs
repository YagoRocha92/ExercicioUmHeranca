namespace ExercicioUmHeranca.Entities
{
    public class Peixe : Animal
    {
        public string Habitat { get; set; }


        public Peixe(string name, string especie, string genero, string habitat) : base(name, especie, genero)
        {
            Habitat = habitat;

        }

        public void Nadar()
        {
            Console.WriteLine("O peixe está nadando");
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Emite um som especifico do mar");
        }
        public override string ToString()
        {
            return "Nome: " + Name + 
                ", seu genero é: " + Genero + 
                ", sua especie é: " + Especie +
                " e seu Habitat é: " + Habitat;
        }
    }
}
