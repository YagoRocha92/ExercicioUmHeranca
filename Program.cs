using ExercicioUmHeranca.Entities;

namespace ExercicioUmHeranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cachorro = new Cachorro("Bob", "PitBull", "Macho", "domestico", 34.5, "Preto com detalhes marrons","Pelos curtos e lisos");

            Console.WriteLine("Cachorro");
            Console.WriteLine(cachorro); // Imprime os dados do gato
            cachorro.EmitirSom();  // Exibe o som característico do cachorro
            Console.WriteLine();

            var cat = new Cat("Laka", "Siames", "femea", "domestico", 5.5, "Branco", "Dócil");

            Console.WriteLine("Gato");
            Console.WriteLine(cat); // Imprime os dados do gato
            cat.EmitirSom();  // Exibe o som característico do gato
            Console.WriteLine();

            var lion = new Lion("Rei Leão", "Panthera leo krugeri", "macho", "sul da Africa", 102, "Amarelo", 14.0);

            Console.WriteLine("Lion");
            Console.WriteLine(lion); // Imprime os dados do Lion
            lion.EmitirSom();  // Exibe o som característico do Lion


            /*
                        var papagaio = new Ave("Loro", "Amazona Rara", "Femea", "Curvo e forte");
                        Console.WriteLine("Papagaio");
                        Console.WriteLine(papagaio);
                        papagaio.EmitirSom();  // Exibe o som característico do papagaio
                        papagaio.Voar();  // O papagaio pode voar

                        var tubarao = new Peixe("Tubarão Branco", "Fundo Oceanic Cleak", "Macho", "Mar aberto");
                        Console.WriteLine();
                        Console.WriteLine(tubarao);
                        tubarao.EmitirSom();  // Exibe o som característico do tubarão
                        tubarao.Nadar();  // O tubarão pode nadar
            */
        }
    }
}