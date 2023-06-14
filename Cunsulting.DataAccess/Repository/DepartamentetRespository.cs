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

    public class DepartamentetRespository : Repository<Departament>, IDepartamentetRespository
    {
        private readonly ApplicationDbContext _db;
        public DepartamentetRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Departament obj)
        {
            _db.Departamentet.Update(obj);
        }
    }
}
