using Circustrain.classes;

namespace Circustrain
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var animals = new List<Animal> {
        new("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
        new("Rabbit", AnimalSize.Small, AnimalDiet.Herbivore),
        new("Fox", 1, AnimalDiet.Herbivore),
        new("Lion", 5, AnimalDiet.Carnivore),
        new("Giraffe", AnimalSize.Large, AnimalDiet.Herbivore),
        new("Wolf", 3, AnimalDiet.Carnivore),
        new("Elephant", AnimalSize.Large, AnimalDiet.Herbivore),
        new("Lion", 5, AnimalDiet.Carnivore),
        new("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
        new("Rabbit", AnimalSize.Small, AnimalDiet.Herbivore),
        new("Fox", 1, AnimalDiet.Herbivore),
        new("Lion", 5, AnimalDiet.Carnivore),
        new("Giraffe", AnimalSize.Large, AnimalDiet.Herbivore),
        new("Wolf", 3, AnimalDiet.Carnivore),
        new("Elephant", AnimalSize.Large, AnimalDiet.Herbivore),
        new("Lion", 5, AnimalDiet.Carnivore),
      };

      var train = new Train();
      train.FillTrain(animals);
      train.PrintTrain();
    }
  }
}