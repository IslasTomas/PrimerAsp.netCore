using System;
using System.Collections.Generic;

namespace PrimerASP.NetCore.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();

    }
}