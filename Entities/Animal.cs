
namespace ExercicioUmHeranca.Entities
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public string Especie { get; private set; }
        public string Genero { get; private set; }

        public Animal()
        {
        }

        public Animal(string name, string especie, string genero)
        {
            Name = name;
            Especie = especie;
            Genero = genero;
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
        public virtual void EmitirSom()
        {
            // Implementação do metodo definido nas subclasses
        }
    }
}
