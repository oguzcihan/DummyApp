using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ComputerManager : IComputerService
    {
        private readonly IComputerRepository _computerRepository;
        public ComputerManager(IComputerRepository computerRepository)
        {
            _computerRepository = computerRepository;
        }
        public IDataResult<List<Computer>> GetList()
        {
            return new SuccessDataResult<List<Computer>>(_computerRepository.GetList().ToList());
        }

        public IDataResult<Computer> GetById(int id)
        {
            var queryResult = _computerRepository.Get(c => c.Id == id);
            if (queryResult != null)
            {
                return new SuccessDataResult<Computer>(queryResult);
            }

            return new ErrorDataResult<Computer>(Messages.ComputerNotFound);
        }

        public IResult Add(Computer computer)
        {
            _computerRepository.Add(computer);
            return new SuccessResult(Messages.ComputerAdded);
        }

        public IResult Delete(Computer computer)
        {
            _computerRepository.Delete(computer);
            return new SuccessResult(Messages.ComputerDeleted);
        }

        public IResult Update(Computer computer)
        {
            _computerRepository.Update(computer);
            return new SuccessResult(Messages.ComputerUpdated);
        }
    }
}
