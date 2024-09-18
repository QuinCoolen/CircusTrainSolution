namespace Circustrain.classes
{
  public class Animal
  {
    private string Name { get; set; }
    private AnimalSize Size { get; set; }
    private AnimalDiet Diet { get; set; }

    public Animal(string name, AnimalSize size, AnimalDiet diet)
    {
      Name = name;
      Size = size;
      Diet = diet;
    }
    public Animal(string name, int size, AnimalDiet diet)
    {
      Name = name;
      Size = (AnimalSize)size;
      Diet = diet;
    }

    public string GetName()
    {
      return Name;
    }

    public int GetSize()
    {
      return (int)Size;
    }

    public AnimalDiet GetDiet()
    {
      return Diet;
    }

    public bool CanBeInSameWagon(Animal animal)
    {
      if (Diet == AnimalDiet.Carnivore && animal.Size <= Size)
      {
        return false;
      }

      if (animal.Diet == AnimalDiet.Carnivore && animal.Size >= Size)
      {
        return false;
      }

      return true;
    }
  }
}