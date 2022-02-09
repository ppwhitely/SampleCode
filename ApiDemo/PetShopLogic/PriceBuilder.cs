
namespace PetShopLogic {
  public static class PriceBuilder {
    private const int OldDogAgeLimit = 10;
    private const int YoungDogAgeLimit = 2;

    public static double GetPrice(Dog dog, DateTime? dayOfWeekOveride = null) {
      return (DefaultPriceOfBreed(dog.Breed) + AgeAdjustment(dog.Age)) * DayOfWeekModifier(dayOfWeekOveride);
    }

    private static double DefaultPriceOfBreed(DogBreed breed) {
      return breed switch {
        DogBreed.Pmeranian => 100.00,
        DogBreed.GermanShepard => 50.00,
        _ => 10,
      };
    }

    private static int DayOfWeekModifier(DateTime? DayOfWeekOveride = null) {
      DateTime day = (DayOfWeekOveride != null) ? DayOfWeekOveride.Value : DateTime.Today;

      if (day.DayOfWeek == DayOfWeek.Sunday || day.DayOfWeek == DayOfWeek.Saturday) {
        return 2;
      }
      return 1;
    }

    private static double AgeAdjustment(int age) {
      if (age < YoungDogAgeLimit) {
        return 20;
      }
      else if (age >= OldDogAgeLimit) {
        return -20;
      }
      return 0;
    }
  }
}