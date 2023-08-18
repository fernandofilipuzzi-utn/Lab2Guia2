using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaTeTiClassLib
{
    public class TaTeTiBasico
    {
        protected string[,] tablero;
        public Jugador Jugador1 { get; private set; }
        public Jugador Jugador2 { get; private set; }

        public TaTeTiBasico():this("Maquina 2")
        {
        }

        public TaTeTiBasico(string Nombre) 
        {
            Jugador1 = new Jugador(this, "O", Nombre);
            Jugador2 = new Jugador(this, "X", "Maquina 1");

            InicializarTablero();
        }

        void InicializarTablero()
        {
            tablero = new string[3, 3];
            for (int n = 0; n < 3; n++)
                for (int m = 0; m < 3; m++)
                    tablero[n, m] = "";
        }

        public bool MarcarTablero(string marca, int fila, int columna)
        {
            bool marcado = tablero[fila, columna] == "";
            if (marcado) tablero[fila, columna] = marca;
            return marcado;
        }

        virtual  public bool VerificarJugada(Jugador jugador)
        {

            //verificar filas
            int cnt = 0;
            for (int fila = 0; fila < 3 && cnt < 3; fila++)
            {
                cnt = 0;
                for (int columna = 0; columna < 3; columna++)
                {
                    if (tablero[fila, columna] == jugador.Marca) cnt++;
                }
            }

            //verifico columnas
            for (int columna = 0; columna < 3 && cnt < 3; columna++)
            {
                cnt = 0;
                for (int fila = 0; fila < 3; fila++)
                {
                    if (tablero[fila, columna] == jugador.Marca) cnt++;
                }
            }

            return cnt == 3;
        }

        public bool HaFinalizado()
        {
            int cnt = 0;
            for (int fila = 0; fila < 3; fila++)
                for (int columna = 0; columna < 3; columna++)
                    if (tablero[fila, columna] != "")
                        cnt++;

            return cnt == 8 || HayGanador()!=null;                        
        }

        public Jugador HayGanador()
        {
            Jugador ganador=null;
            bool j1 = Jugador1.VerificarGanador();
            bool j2 = Jugador2.VerificarGanador();

            if (j1 == true && j2 == false) ganador = Jugador1;
            else if (j2 == true && j1 == false) ganador = Jugador2;

            return ganador;
        }
    }
}
