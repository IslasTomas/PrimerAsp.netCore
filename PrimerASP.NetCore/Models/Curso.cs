
using System;
using System.Collections.Generic;

namespace PrimerASP.NetCore.Models
{
    public class Curso: ObjetoEscuelaBase
    {
         public TurnoCurso turno {get;set;}
        public List<Alumno> Alumnos { get; set; } = new List<Alumno>();
        public List<Materia> Materias { get; set; } = new List<Materia>();
        public string Direccion { get; set; }

       
    }
}       