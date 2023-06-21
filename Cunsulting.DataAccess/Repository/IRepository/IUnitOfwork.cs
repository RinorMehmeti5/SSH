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
        IKonsultimetRespository Konsultimet { get; }
        IDepartamentetRespository Departamentet{ get; }
        IVitiRespository Viti{ get; }

        void Save();
    }
}
