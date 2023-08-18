using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaTeTiClassLib;

namespace TaTeTiDesktop.Modelo
{
    class TaTeTiComplejo : TaTeTiBasico
    {
        public TaTeTiComplejo() : base()
        {
        }

        public TaTeTiComplejo(string Nombre) : base(Nombre)
        {
        }


        override public bool VerificarJugada(Jugador jugador)
        {
            bool v = base.VerificarJugada(jugador);
            
            int cnt = 0;

            //diagonal
            if (cnt < 3)
            {
                cnt = 0;
                for (int n = 0; n < 3; n++)
                {
                    if (tablero[n, n] == jugador.Marca) cnt++;
                }
            }

            //diagonal invertida
            if (cnt < 3)
            {
                cnt = 0;
                for (int n = 0; n < 3; n++)
                {
                    if (tablero[n, 2 - n] == jugador.Marca) cnt++;
                }
            }

            return v || cnt == 3;
        }
    }
}
