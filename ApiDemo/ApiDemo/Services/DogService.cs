namespace ApiDemo.Services {
  public class DogService {
    private List<Dog> _dogs;

    public DogService() {
      _dogs = new List<Dog> {
        new Dog { Id = 1, Name = "Fido", Breed = Breeds.Pmeranian },
        new Dog { Id = 2, Name = "Tina", Breed = Breeds.LabradorRetriver },
        new Dog { Id = 3, Name = "Sam", Breed = Breeds.Bulldog }
      };
    }

    public List<Dog> GetDogs() {
      return _dogs;
    }

    public Dog? GetDogByName(string dogName) {
      return _dogs.FirstOrDefault(dog => dog.Name == dogName);
    }

    public Dog? GetDogById(int id) {
      return _dogs.FirstOrDefault(dog => dog.Id == id);
    }

    public bool AddDog(Dog newDog) {
      if (_dogs.Any(x => x.Id == newDog.Id)) return false;

      var newDogid = _dogs.Max(dog => dog.Id);
      newDog.Id = newDogid +1;
      _dogs.Add(newDog);
      return true;
    }
  }
}