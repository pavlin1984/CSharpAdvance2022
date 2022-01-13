using System;
using System.Collections.Generic;
using System.Linq;
namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            string line = Console.ReadLine();
           
            while (line != "Tournament")
            {
                string[] elements = line.Split();
                // "{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string trainerName = elements[0];
                string pokemoneName = elements[1];
                string pokemonElement = elements[2];
                int pokemoneHealth = int.Parse(elements[3]);



                if (!trainers.Any(x => x.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }
                var currentTrainer = trainers.Find(t => t.Name == trainerName);
                currentTrainer.Pokemons.Add(new Pokemon(pokemoneName, pokemonElement, pokemoneHealth));
                line = Console.ReadLine();
            }
            string comand = Console.ReadLine();
            while (comand!="End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p=>p.Element==comand))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        //for (int i = 0; i < trainer.Pokemons.Count; i++)
                        //{
                        //    trainer.Pokemons[i].Health -= 10;
                        //    if (trainer.Pokemons[i].Health<=0)
                        //    {
                        //        trainer.Pokemons.RemoveAt(i);
                        //        i--;
                        //    }
                            
                        //}
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }



                comand = Console.ReadLine();
            }
            foreach (Trainer trainer in trainers.OrderByDescending(t=>t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
            
        }
    }
}
