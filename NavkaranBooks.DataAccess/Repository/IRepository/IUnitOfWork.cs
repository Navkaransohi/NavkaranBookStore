using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavkaranBooks.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }

        ICoverTypeRepository CoverType { get; }

        IProductRepository Product { get; }

        void Save();
    }
}