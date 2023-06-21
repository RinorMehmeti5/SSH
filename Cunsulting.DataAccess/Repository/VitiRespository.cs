using Consult.DataAcess.Data;
using Consult.Models;
using Cunsult.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cunsult.DataAcess.Repository
{

    public class VitiRespository : Repository<Viti>, IVitiRespository
    {
        private readonly ApplicationDbContext _db;
        public VitiRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Viti obj)
        {
            _db.Viti.Update(obj);
        }
    }
}
