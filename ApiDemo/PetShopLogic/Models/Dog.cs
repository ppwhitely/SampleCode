using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLogic {
  public class Dog {
    public int Id { get; set; }
    public string Name { get; set; }
    public DogBreed Breed { get; set; }
    public int Age { get; set; }
  }
}
