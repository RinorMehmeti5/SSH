using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunsult.DataAcess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ILendetRepository Lendet { get; }

        void Save();
    }
}
