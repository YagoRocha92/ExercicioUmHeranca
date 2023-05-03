
namespace ExercicioUmHeranca.Entities
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public string Especie { get; private set; }
        public string Genero { get; private set; }
        public string Habitat { get; private set; }
        public double Peso { get; private set; }
        public string Cor { get; private set; }


        public Animal()
        {
        }

        protected Animal(string name, string especie, string genero, string habitat, double peso, string cor)
        {
            Name = name;
            Especie = especie;
            Genero = genero;
            Habitat = habitat;
            Peso = peso;
            Cor = cor;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetEspecie(string especie)
        {
            Especie = especie;
        }
        public void SetGenero(string genero)
        {
            Genero = genero;
        }

        public void SetHabitat(string habitat)
        {
            Habitat = habitat;
        }
        public void SetPeso (double peso)
        {
            Peso = peso;
        }

        public void SetCor(string cor)
        {
            Cor = cor;
        }
        public virtual void EmitirSom()
        {
            // Implementação do metodo definido nas subclasses
        }
    }
}
