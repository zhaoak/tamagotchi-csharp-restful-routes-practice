using System.Collections.Generic;

namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public int food { get; set; }
    public int happiness { get; set; }
    public int sleep { get; set; }
    public int Id { get; set; }

    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};
    public static int food_max { get; } = 20;
    public static int happiness_max { get; } = 40;
    public static int sleep_max { get; } = 30;

    public Tamagotchi(string name) {
      Name = name;
      food = 10;
      happiness = 20;
      sleep = 20;
      Id = _instances.Count;
      _instances.Add(this);
    }

    public static void Feed(int Id) {
      foreach (Tamagotchi pet in _instances)
      {
        pet.food = pet.food - 2;
      }
      _instances[Id].food += 7; // mechanically +5, but we compensate for the global -2 food

      if (_instances[Id].food > Tamagotchi.food_max)
      {
        _instances[Id].food = Tamagotchi.food_max; // 
      }
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

    public static void Euthanize(int id)
    {
      _instances[id].food = 0;
      _instances[id].sleep = 0;
      _instances[id].happiness = 0;
    }

    // abandon your pet, removing it from list
    // you monster
    public static void Abandon(int id)
    {
      _instances.RemoveAt(id);
      foreach (Tamagotchi pet in _instances)
      {
        if (pet.Id > id)
        {
          pet.Id--;
        }
      }
    }
  }
}
