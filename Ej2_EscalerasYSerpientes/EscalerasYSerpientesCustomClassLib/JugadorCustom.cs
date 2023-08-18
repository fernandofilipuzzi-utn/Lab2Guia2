using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscalerasYSerpientesClassLib;

namespace EscalerasYSerpientesCustomClassLib
{
    public class JugadorCustom:Jugador
    {
        public JugadorCustom(string nombre) : base(nombre)
        {
        }

        public int TurnosSuspendos { get; set; }

        public override void Mover() 
        {
            if (TurnosSuspendos <= 0)
                base.Mover();
            else
                TurnosSuspendos--;
        }
    }
}
