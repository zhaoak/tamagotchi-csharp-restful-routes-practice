using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TamagotchiGame.Models;
using System;

namespace TamagotchiGame.Tests
{
  [TestClass]
  public class TamagotchiTests : IDisposable
  {

    public void Dispose()
    {
      Tamagotchi.ClearAll();
    }

    [TestMethod]
    public void Constructor_CreatesNew_Tamagotchi()
    {
      Tamagotchi testgotchi = new Tamagotchi("testy");
      Assert.AreEqual(typeof(Tamagotchi), testgotchi.GetType());
      Assert.AreEqual(testgotchi.Name, "testy");
      Assert.AreEqual(testgotchi.food, 10);
      Assert.AreEqual(testgotchi.sleep, 20);
      Assert.AreEqual(testgotchi.happiness, 20);
      Assert.AreEqual(testgotchi.Id, 1);
    }

    [TestMethod]
    public void FeedFunc_IncreasesTamagotchiFoodAndDecreasesOtherTamagotchiFood_Int()
    {
      Tamagotchi testgotchi1 = new Tamagotchi("testy");
      Tamagotchi testgotchi2 = new Tamagotchi("toasty");

      Tamagotchi.Feed(testgotchi1.Id);

      Assert.AreEqual(testgotchi1.food, 15);
      Assert.AreEqual(testgotchi2.food, 8);
    }

  }
}
