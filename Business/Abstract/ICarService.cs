using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface ICarService
    {
        void Add(Car car);
        List<Car> GetAll();
        Car GetById(int carId);
        List<CarDetailDto> GetCarDetails();
    }
}
