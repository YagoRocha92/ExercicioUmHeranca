
namespace ExercicioUmHeranca.Entities
{
    public class Mamifero : Animal
    {
        

        public string Pelagem { get; private set; }
        public Mamifero(string name, string especie, string genero, string pelagem) : base ( name, especie, genero)
        {
            Pelagem = pelagem;

        }


        public void Amamentar()
        {
            Console.WriteLine("está amamentando o seu filhote");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Emite um som especifico");
        }

        public override string ToString()
        {
            return "Nome: " + Name +
                   ", seu genero é: " + Genero +
                   ", sua especie é: " + Especie +
                   " e sua pelagem é: " + Pelagem;
        }
    }
}
