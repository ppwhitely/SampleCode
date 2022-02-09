using PetShopLogic;
namespace ApiDemo {
  public class DogDTO {
    public int Id { get; set; }
    public string Name { get; set; }
    public DogBreed Breed { get; set; }
    public int Age { get; set; }
  }
}