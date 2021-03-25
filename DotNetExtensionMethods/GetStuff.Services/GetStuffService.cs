using System.Collections.Generic;
using GetStuff.Services.Configuration;
using Microsoft.Extensions.Options;

namespace GetStuff.Services
{
    public class GetStuffService : IGetStuffService
    {
        private readonly IOptions<CarSettings> _options;

        public GetStuffService(IOptions<CarSettings> options)
        {
            _options = options;
        }

        public Car GetCar(string registration)
        {
            var car = new Car
            {
                MakeModel = "Make Blah",
                Registration = "A1"
            };

            car.MakeModel = car.MakeModel.Replace("Make", _options.Value.OverrideMakeWithName);

            return car;
        }

        public List<Car> GetCars()
        {
            var list = new List<Car>
            {
                new Car
                {
                    MakeModel = "Make Blah",
                    Registration = "A1"
                },
                new Car
                {
                    MakeModel = "Make sdsd",
                    Registration = "A2"
                }
            };

            list.ForEach(x =>
            {
                x.MakeModel = x.MakeModel.Replace("Make", _options.Value.OverrideMakeWithName);
            });

            return list;
        }
    }
}