using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using GetStuff.Services;

namespace TheApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IGetStuffService _getStuffService;

        public CarController(IGetStuffService getStuffService)
        {
            _getStuffService = getStuffService;
        }

        [HttpGet]
        [Route("car")]
        public Car GetCar(string registration)
        {
            return _getStuffService.GetCar(registration);
        }

        [HttpGet]
        [Route("cars")]
        public List<Car> GetCars()
        {
            return _getStuffService.GetCars();
        }
    }
}