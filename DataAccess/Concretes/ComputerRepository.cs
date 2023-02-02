using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concretes
{
    public class ComputerRepository:EfRepositoryBase<Computer,AppDbContext>, IComputerRepository
    {
        public ComputerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
