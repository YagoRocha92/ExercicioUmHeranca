namespace ExercicioUmHeranca.Entities
{
    internal class Cat : Animal
    {

        public string Personalidade { get; set; }

        public Cat(string name, string especie, string genero, string habitat, double peso, string cor, string personalidade) : base(name, especie, genero, habitat, peso, cor)
        {
            Personalidade = personalidade;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Miau Miau Miau");
        }

        public override string ToString()
        {
            return "Meu nome é: " + Name + ", sou da especie " + Especie + " sou um " + Genero + " meu habitat é "
                 + Habitat + " tenho " + Peso + " Kg e minha cor é " + Cor + " sou " + Personalidade;
        }

    }
}

