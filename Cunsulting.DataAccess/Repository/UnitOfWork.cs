﻿using Consult.DataAcess.Data;
using Cunsult.DataAcess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cunsult.DataAcess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ILendetRepository Lendet { get; private set; } 
        public IKonsultimetRespository Konsultimet { get; private set; }
        public IDepartamentetRespository Departamentet { get; private set; }
        public IVitiRespository Viti { get; private set; }
        public UnitOfWork(ApplicationDbContext db)  
        {
            _db = db;
            Lendet = new LendetRespository(_db);
            Konsultimet = new KonsultimetRespository(_db);
            Departamentet = new DepartamentetRespository(_db);
            Viti = new VitiRespository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
