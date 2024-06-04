using Business.Abstract.Dtos.Requests;
using Business.Abstract.Dtos.Responses;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreateBrandRequest createdBrandRequest);
        List<GetAllBrandResponse> GetAll();
    }
}
