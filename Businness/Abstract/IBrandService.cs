using Core.Utilities.Results;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abstract
{
    public interface IBrandService
    {
        IResult Add( Brand brand );
        IResult Update(Brand brand);
        IResult Delete( Brand brand );  
        IDataResult<Brand> GetById(int id);
        IDataResult<List<Brand>> GetAll();
    }
}
