using Consult.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunsult.DataAcess.Repository.IRepository
{
    public interface IVitiRespository : IRepository<Viti>
    {
        void Update(Viti obj);
    }
}
