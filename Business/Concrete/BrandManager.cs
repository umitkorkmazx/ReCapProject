using Business.Abstract;
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

        public List<Brand> GetAll()
        {
            return _brandal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandal.Get(b=>b.BrandId == brandId);
        }
    }
}
