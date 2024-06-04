using Business.Abstract;
using Business.Abstract.Dtos.Requests;
using Business.Abstract.Dtos.Responses;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse Add(CreateBrandRequest createdBrandRequest)
        {
            //business rules
            // mapping ---> automapper
            Brand brand = new();
            brand.Name = createdBrandRequest.Name;
            _brandDal.Add(brand);
            //mapping
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = createdBrandRequest.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedDate = brand.CreatedDate;

            return createdBrandResponse;

        }

        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands = _brandDal.GetAll();
            List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();
            foreach (Brand brand in brands)
            {
                GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
                getAllBrandResponse.Name = brand.Name;
                getAllBrandResponse.Id= brand.Id;
                getAllBrandResponse.CreatedDate= brand.CreatedDate;

                getAllBrandResponses.Add(getAllBrandResponse);

            }
            return getAllBrandResponses;
        } 
    }
}
