using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Business.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        IRepository<User> Users { get; }
        Task<int> SaveChangesAsync();
    }
}
