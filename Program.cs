using ExercicioUmHeranca.Entities;

namespace ExercicioUmHeranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cachorro = new Mamifero("Bob", "Macho", "Sem Raça Definida", "Pelos curtos e lisos");

            Console.WriteLine();
            Console.WriteLine(cachorro);
            cachorro.EmitirSom();  // Exibe o som característico do cachorro
            cachorro.Amamentar();  // O cachorro não pode amamentar, mas isso é apenas um exemplo de método específico para mamíferos

            var papagaio = new Ave("Loro", "Amazona Rara", "Femea", "Curvo e forte");
            Console.WriteLine();
            Console.WriteLine(papagaio);
            papagaio.EmitirSom();  // Exibe o som característico do papagaio
            papagaio.Voar();  // O papagaio pode voar

            var tubarao = new Peixe("Tubarão Branco", "Fundo Oceanic Cleak", "Macho", "Mar aberto");
            Console.WriteLine();
            Console.WriteLine(tubarao);
            tubarao.EmitirSom();  // Exibe o som característico do tubarão
            tubarao.Nadar();  // O tubarão pode nadar

        }
    }
}