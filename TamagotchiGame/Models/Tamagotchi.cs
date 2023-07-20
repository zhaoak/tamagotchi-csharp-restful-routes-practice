using System.Collections.Generic;

namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public int food { get; set; }
    public int happiness { get; }
    public int sleep { get; }
    public int Id { get; }

    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};
    public static int food_max { get; } = 20;
    public static int happiness_max { get; } = 40;
    public static int sleep_max { get; } = 30;

    public Tamagotchi(string name) {
      Name = name;
      food = 10;
      happiness = 20;
      sleep = 20;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void Feed(int Id) {
      foreach (Tamagotchi pet in _instances)
      {
        pet.food = pet.food - 2;
      }
      _instances[Id - 1].food += 7; // mechanically +5, but we compensate for the global -2 food
    }

    public static void Sleep(int Id) {

    }

    public static void Play(int Id) {

    }

    public static Tamagotchi Find(int Id)
    {
      return _instances[Id];
    }

    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
