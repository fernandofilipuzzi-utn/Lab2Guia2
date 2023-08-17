using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EscalerasYSerpientesClassLib;
using System.Collections;

namespace EscalerasYSerpientesLegacyClassLib
{
    public class JugadorLegacy:Jugador
    {
        public JugadorLegacy(string nombre) : base(nombre)
        {
            porQuienesFueAfectado = new ArrayList();
        }

        public ArrayList porQuienesFueAfectado 
        {
            get; private set; 
        }

        public int CantidadAfectadores
        {
            get
            {
                return porQuienesFueAfectado.Count;
            }
        }

        public int VerCantidadQuienes
        {
            get 
            { 
                return porQuienesFueAfectado.Count; 
            } 
        }

        public Elemento VerPorQuien(int idx)
        {
            Elemento quien = null;
            if (VerCantidadQuienes > 0 && VerCantidadQuienes < porQuienesFueAfectado.Count)
                quien = (Elemento)porQuienesFueAfectado[idx];

            return (Elemento)porQuienesFueAfectado[idx];
        }

        public void AgregarAfectador(Elemento e)
        {
            porQuienesFueAfectado.Add(e);
        }

        override public void Mover()
        {
            base.Mover();
            porQuienesFueAfectado = new ArrayList();
        }
    }
}
