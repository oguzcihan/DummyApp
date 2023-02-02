using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IComputerRepository:IRepository<Computer>,IAsyncRepository<Computer>
    {
        //Special path operations write here
    }
}
