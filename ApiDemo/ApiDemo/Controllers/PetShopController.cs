using Microsoft.AspNetCore.Mvc;
using PetShopLogic;
using ApiDemo.Mappers;
namespace ApiDemo.Controllers {

  [ApiController]
  [Route("[controller]/[action]")]
  public class PetShopController : Controller {
    private readonly ILogger<PetShopController> _logger;

    public PetShopController(ILogger<PetShopController> logger) {
      _logger = logger;
    }

    [HttpGet]
    public ActionResult<double> GetPrice([FromQuery] DogDTO dogDto) {
      var dog = Mapper.DogFromDTO(dogDto);
      return Ok(PriceBuilder.GetPrice(dog));
    }
  }
}