using EscuelaSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaSystem.Data.Interfaces
{
    public interface IBecadoRepository : IRepository<Becado>
    {
        void HInscrito();

    }
}
