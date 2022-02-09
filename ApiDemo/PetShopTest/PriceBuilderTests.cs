using NUnit.Framework;
using System;
using PetShopLogic;

namespace PetShopTest {

  public class PriceBuilderTests {
    [Test]
    public void AgeAdjustment_IncreasesPriceOfYoungPuppies() {
      var standardDog = new Dog { Age = 5, Breed = DogBreed.LabradorRetriver, Id = 1, Name = "Standard Dog" };
      var youngDog = new Dog { Age = 1, Breed = DogBreed.LabradorRetriver, Id = 2, Name = "puppy Dog" };

      var priceOfStandardDog = PriceBuilder.GetPrice(standardDog);
      var priceOfYoungDog = PriceBuilder.GetPrice(youngDog);

      Assert.IsTrue(priceOfYoungDog > priceOfStandardDog);
    }

    [Test]
    public void DayOfWeekModifier_WeekendsDoublePrice() {
      var standardDog = new Dog { Age = 5, Breed = DogBreed.LabradorRetriver, Id = 1, Name = "Standard Dog" };

      var priceDuringWeekday = PriceBuilder.GetPrice(standardDog, new DateTime(2022,01,04));
      var priceDuringWeekend = PriceBuilder.GetPrice(standardDog, new DateTime(2022, 01, 08));

      Assert.AreEqual(priceDuringWeekday * 2, priceDuringWeekend);
    }
  }
}
