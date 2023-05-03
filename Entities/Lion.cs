
namespace ExercicioUmHeranca.Entities
{
    internal class Lion : Animal
    {
        public double Presas { get; private set; }

        public Lion(string name, string especie, string genero, string habitat, double peso, string cor, double presa) : base(name, especie, genero, habitat, peso, cor)
        {
            Presas = presa;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Urrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr");
        }

        public override string ToString()
        {
            return "Meu nome é: " + Name + ", sou da especie " + Especie + " sou um " + Genero + " meu habitat é "
                 + Habitat + " tenho " + Peso + " Kg, minha cor é " + Cor + " e minha presa é " + Presas + " Cm";
        }
    }
}
