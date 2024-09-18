namespace Circustrain.classes
{
  public class Train
  {
    private List<TrainWagon> Wagons { get; set; }

    public Train()
    {
      Wagons = new List<TrainWagon>();
    }

    public IReadOnlyList<TrainWagon> GetWagons()
    {
      return Wagons;
    }

    public void FillTrain(List<Animal> animals)
    {
      animals.Sort((a, b) => b.GetSize().CompareTo(a.GetSize()));
      
      foreach (var animal in animals)
      {
        if (!Wagons.Any(wagon => wagon.AddAnimal(animal)))
        {
          var newWagon = new TrainWagon();
          newWagon.AddAnimal(animal);
          Wagons.Add(newWagon);
        }
      }
    }

    public void PrintTrain()
    {
      Console.WriteLine($"Train with {Wagons.Count} wagons");
      foreach (var wagon in Wagons)
      {
        wagon.PrintWagon();
      }
    }
  }
}