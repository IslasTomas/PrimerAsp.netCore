using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimerASP.NetCore.Models;

namespace PrimerASP.NetCore.Controllers
{
    public class EscuelaController : Controller
    {///Los controladores son los que hacen la coneccion entre las vistas y el modelo
        public IActionResult Index()
        {
            var escuela = new Escuela();            ///Creamos un obejto escuela que lo definimos en el Models
            escuela.AñoDeCreacion = 2000;
            escuela.UniqueId= Guid.NewGuid().ToString();
            escuela.Nombre = "San Cayetano";
            return View(escuela);  //Enviamos por parametro la escuela a la vista (a escuela index)
        }
    }
}
