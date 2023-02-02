using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IComputerService
    {
        IDataResult<List<Computer>> GetList();
        IDataResult<Computer> GetById(int id);
        IResult Add(Computer computer);
        IResult Delete(Computer computer);
        IResult Update(Computer computer);
    }
}
