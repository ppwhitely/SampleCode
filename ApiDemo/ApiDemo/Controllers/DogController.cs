using Microsoft.AspNetCore.Mvc;
using ApiDemo.Services;

namespace ApiDemo.Controllers {

  [ApiController]
  [Route("[controller]")]
  public class DogController : ControllerBase {
    private readonly ILogger<DogController> _logger;
    private readonly DogService _dogService;

    public DogController(ILogger<DogController> logger) {
      _logger = logger;
      _dogService = new DogService();
    }

    [HttpGet]
    public ActionResult<DogDTO> GetByName(string dogName) {
      if (string.IsNullOrEmpty(dogName)) {
        return BadRequest();
      }

      var dog = _dogService.GetDogByName(dogName);
      if (dog == null) return NotFound();

      return Ok(dog);
    }

    [HttpPost]
    public ActionResult<DogDTO> Post(DogDTO newDog) {
      var addSuccessful = _dogService.AddDog(newDog);
      if (!addSuccessful) {
        return BadRequest();
      }

      return Ok();
    }
  }
}