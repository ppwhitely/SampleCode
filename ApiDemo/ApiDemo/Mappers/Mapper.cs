namespace ApiDemo.Mappers {
  public  static class Mapper {

    public static PetShopLogic.Dog DogFromDTO(this DogDTO dog) {
      return new PetShopLogic.Dog { Id = dog.Id,Name = dog.Name, Breed = dog.Breed, Age = dog.Age};
    }
    public static DogDTO DogFromDTO(this PetShopLogic.Dog dog) {
      return new DogDTO { Id = dog.Id, Name = dog.Name, Breed = dog.Breed, Age = dog.Age };
    }
  }
}