using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscuelaSystem.Data.Repositories
{
    public class BecadoRepository : Repository<Becado>, IBecadoRepository
    {
        private readonly ApplicationDbContext _db;
        public BecadoRepository(ApplicationDbContext db) : base(db)
        {

        }
        public void HInscrito()
        {
            var Inscritas = _db.Becados.Where(c => c.Inscrito == true).ToList();
            _db.RemoveRange(Inscritas);
            _db.SaveChanges();
        }
    }
}
