using System;
using System.Collections.Generic;
using System.Text;

namespace GetStuff.Services
{
    public interface IGetStuffService
    {
        Car GetCar(string registration);

        List<Car> GetCars();
    }
}