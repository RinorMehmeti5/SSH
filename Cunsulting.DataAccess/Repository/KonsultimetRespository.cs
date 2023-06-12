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
    
    public class KonsultimetRespository : Repository<Konsultimet>, IKonsultimetRespository
    {
        private readonly ApplicationDbContext _db;
        public KonsultimetRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Konsultimet obj)
        {
            var objFromDb = _db.Konsultimet.FirstOrDefault(u=>u.Kid == obj.Kid);
            if (objFromDb != null)
            {
                objFromDb.Ktitle = obj.Ktitle;
                objFromDb.Kpershkrimi = obj.Kpershkrimi;
                objFromDb.KkohaEMbarimit = obj.KkohaEMbarimit;
                objFromDb.KkohaEFillimit = obj.KkohaEFillimit;
                objFromDb.KLid = obj.KLid;
            }
        }
    }
}
