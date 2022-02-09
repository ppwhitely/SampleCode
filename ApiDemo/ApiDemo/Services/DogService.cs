namespace ApiDemo.Services {
  public class DogService {
    private List<DogDTO> _dogs;

    public DogService() {
      _dogs = new List<DogDTO> {
        new DogDTO { Id = 1, Name = "Fido", Breed = PetShopLogic.DogBreed.Pmeranian },
        new DogDTO { Id = 2, Name = "Tina", Breed = PetShopLogic.DogBreed.LabradorRetriver },
        new DogDTO { Id = 3, Name = "Sam", Breed = PetShopLogic.DogBreed.BullDog }
      };
    }

    public List<DogDTO> GetDogs() {
      return _dogs;
    }

    public DogDTO? GetDogByName(string dogName) {
      return _dogs.FirstOrDefault(dog => dog.Name.Equals(dogName, StringComparison.InvariantCultureIgnoreCase));
    }

    public DogDTO? GetDogById(int id) {
      return _dogs.FirstOrDefault(dog => dog.Id == id);
    }

    public bool AddDog(DogDTO newDog) {
      if (_dogs.Any(x => x.Id == newDog.Id)) return false;

      var newDogid = _dogs.Max(dog => dog.Id);
      newDog.Id = newDogid + 1;
      _dogs.Add(newDog);
      //Save data
      return true;
    }

    public void RemoveDog(int dogId) {
      var dogToRemove = GetDogById(dogId);

      if (dogToRemove != null) {
        _dogs.Remove(dogToRemove);
      }
      //Save data
    }

    public void UpdateDog(DogDTO newDog) {
      var dogToUpdate = _dogs.FirstOrDefault(dog => dog.Id == newDog.Id);
      if(dogToUpdate != null) {
        dogToUpdate.Name = newDog.Name;
        dogToUpdate.Breed = newDog.Breed;
        dogToUpdate.Age = newDog.Age;
      }
      //Save data
    }
  }
}