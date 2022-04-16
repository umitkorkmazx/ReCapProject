using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandal;

        public BrandManager(IBrandDal brandal)
        {
            _brandal = brandal;
        }

        public IResult Add(Brand brand)
        {
           _brandal.Add(brand);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
            _brandal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandal.GetAll();
            return new SuccessDataResult<List<Brand>>(result, Messages.Listed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            var result = _brandal.Get(c=> c.BrandId==id);
            return new DataResult<Brand>(result,true, Messages.Listed);

        }
    }
}
