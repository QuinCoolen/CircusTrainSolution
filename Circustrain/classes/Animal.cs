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

    public AnimalSize GetSize()
    {
      return Size;
    }

    public AnimalDiet GetDiet()
    {
      return Diet;
    }

    public bool CanBeInSameWagon(Animal animal)
    {
        if (Diet == AnimalDiet.Carnivore && animal.Diet == AnimalDiet.Carnivore)
        {
            return false;
        }

        if (Diet == AnimalDiet.Carnivore && animal.GetSize() <= GetSize())
        {
            return false;
        }

        if (animal.Diet == AnimalDiet.Carnivore && animal.GetSize() >= GetSize())
        {
            return false;
        }

        // if (Diet == AnimalDiet.Carnivore && GetSize() <= AnimalSize.Medium && 
        //     animal.GetSize() == AnimalSize.Large && animal.Diet == AnimalDiet.Herbivore)
        // {
        //     return true;
        // }

        // if (Diet == AnimalDiet.Herbivore && animal.Diet == AnimalDiet.Herbivore &&
        //     GetSize() == AnimalSize.Large && animal.GetSize() == AnimalSize.Large)
        // {
        //     return false;
        // }

        return true;
    }
  }
}