using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length >=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                
                    
            }
            else
            {
                Console.WriteLine(Messages.CarNameInValid);
            }
            return new SuccessResult( Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id),"Arabalar Listelendi");
        }

        public IDataResult<List<Car>> GetAllCarsByColorId(int id)
        {
            return new DataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id),true,"Arabalar listelendi");
        }

        public IDataResult<Car> GetById(int id)
        {
            return new DataResult<Car> (_carDal.Get(c=>c.CarId==id),true,"Arabalar listelendi");
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails());
        }
    }
}
