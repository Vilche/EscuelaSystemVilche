﻿using EscuelaSystem.models;
using System;
using System.Collections.Generic;
using System.Text;


namespace EscuelaSystem.Data.Interfaces
{
    public interface IMateriaRepository : IRepository<Materia>
    {
        void DeleteHabilitada();

    }
}
