using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunsult.DataAcess.Repository.IRepository
{
    internal interface IUnitOfwork
    {
        ILendetRepository Lendet { get; }

        void Save();
    }
}
