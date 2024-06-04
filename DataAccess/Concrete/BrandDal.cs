using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BrandDal : IBrandDal
    {
     
        List<Brand> _brands;

        public BrandDal()
        {
            _brands =new List<Brand>();
            _brands.Add(new Brand {Id=4,Name="BMW",CreatedDate=DateTime.Now });
            _brands.Add(new Brand { Id = 5, Name = "AUDI", CreatedDate = DateTime.Now });
            _brands.Add(new Brand { Id = 6, Name = "CHERRY", CreatedDate = DateTime.Now });

        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }
    }
}
