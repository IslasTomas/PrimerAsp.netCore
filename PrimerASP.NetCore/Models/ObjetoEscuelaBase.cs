using System;

namespace PrimerASP.NetCore.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId{ get; set; } //= Guid.NewGuid().ToString(); // // lo definimos privado por lo que solo se puede asignar desde la clase
                                                //lo asignamos con el constructur 
   
        public string Nombre { get; set;}
        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        } 
    }
}