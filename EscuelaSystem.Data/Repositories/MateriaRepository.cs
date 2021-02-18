using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscuelaSystem.Data.Repositories
{
    public class MateriaRepository : Repository<Materia>, IMateriaRepository
    {
        private readonly ApplicationDbContext _db;
        public MateriaRepository(ApplicationDbContext db) : base(db)
        {

        }
        public void DeleteHabilitada()
        {
            var habilitadas = _db.Materias.Where(c => c.Habilitada == true).ToList();
            _db.RemoveRange(habilitadas);
            _db.SaveChanges();
        }
    }
}
