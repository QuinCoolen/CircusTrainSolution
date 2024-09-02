using NUnit.Framework;
using Circustrain.classes;

namespace YourProjectName.Tests
{
    [TestFixture]
    public class TrainTests
    {
        [Test]
        public void FillTrain_WithMixedAnimals()
        {
            // Arrange
            var animals = new List<Animal>
            {
                new("Elephant", AnimalSize.Large, AnimalDiet.Herbivore),
                new("Lion", AnimalSize.Large, AnimalDiet.Carnivore),
                new("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
                new("Rabbit", AnimalSize.Small, AnimalDiet.Herbivore),
            };
            var train = new Train();

            // Act
            train.FillTrain(animals);

            Assert.That(train.GetWagons(), Has.Count.EqualTo(2)); // Expecting at least 3 wagons
        }

        [Test]
        public void FillTrain_WithOnlyHerbivores()
        {
            // Arrange
            var animals = new List<Animal>
            {
                new("Rabbit", AnimalSize.Small, AnimalDiet.Herbivore),
                new("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
                new("Rabbit", AnimalSize.Small, AnimalDiet.Herbivore),
                new("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
            };
            var train = new Train();

            // Act
            train.FillTrain(animals);

            // Assert
            Assert.That(train.GetWagons(), Has.Count.EqualTo(1)); // Expecting exactly 1 wagon
        }

        [Test]
        public void FillTrain_WithCarnivoresAndHerbivores()
        {
            // Arrange
            var animals = new List<Animal>
            {
                new("Rabbit", AnimalSize.Small, AnimalDiet.Herbivore),
                new("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
                new("Lion", AnimalSize.Large, AnimalDiet.Carnivore),
                new("Zebra", AnimalSize.Medium, AnimalDiet.Herbivore),
            };
            var train = new Train();

            // Act
            train.FillTrain(animals);

            // Assert
            Assert.That(train.GetWagons(), Has.Count.EqualTo(2));
        }
    }
}
