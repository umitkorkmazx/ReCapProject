using Core.Utilities;
using Core.Utilities.Results;
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
        IResult Add(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllCarsByBrandId(int id);
        IDataResult<List<Car>> GetAllCarsByColorId(int id);
        IDataResult<Car> GetById(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
