
namespace ExercicioUmHeranca.Entities
{
    public class Cachorro : Animal
    {
        public string Pelagem { get; set; }

        public Cachorro(string name, string especie, string genero, string habitat, double peso, string cor, string pelagem) : base(name, especie, genero, habitat, peso, cor)
        {
            Pelagem = pelagem;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au Au Au");
        }

        public override string ToString()
        {
           return "Meu nome é: " + Name + ", sou da especie " + Especie + " sou um " + Genero + " meu habitat é "
                + Habitat + " tenho " + Peso + " Kg e minha cor é " + Cor + " e minha pelagem é " + Pelagem;
        }

    }
}
