namespace Circustrain.classes
{
  public class TrainWagon
  {
    private List<Animal> Animals { get; set; }
    public IReadOnlyList<Animal> AnimalsInWagon { get { return Animals; } }
    private int MaxSize { get; set; }
    private int FreeSpace { get; set; }

    public TrainWagon()
    {
      Animals = new List<Animal>();
      MaxSize = 10;
      FreeSpace = MaxSize;
    }

    public bool AddAnimal(Animal animal)
    {
      if (CanAddAnimal(animal))
      {
        Animals.Add(animal);
        FreeSpace -= animal.GetSize();
        return true;
      }

      return false;
    }

    private bool CanAddAnimal(Animal animal)
    {
      if (FreeSpace < animal.GetSize())
      {
        return false;
      }

      foreach (var animalInWagon in Animals)
      {
        if (!animalInWagon.CanBeInSameWagon(animal))
        {
          return false;
        }
      }

      return true;
    }

    public void PrintWagon()
    {
      Console.WriteLine($"Wagon with {Animals.Count} animals");
      foreach (var animal in Animals)
      {
        Console.WriteLine($"- {animal.GetName()}");
      }
    }

  }
}