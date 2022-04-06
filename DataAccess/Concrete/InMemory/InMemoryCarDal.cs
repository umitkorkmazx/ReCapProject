using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId=2, ModelYear=2017, DailyPrice=8950, Description="Sahibinden Temiz Ford Mondeo"},
                new Car {Id=2, BrandId=2, ColorId=3, ModelYear=2020, DailyPrice=12500, Description="Volvo 360xc"},
                new Car {Id=3, BrandId=1, ColorId=3, ModelYear=2020, DailyPrice=9950, Description="Sahibinden Yeni Ford"}
            };
        }
        public void Add(Car car)
        { 
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
        }
    }
}
