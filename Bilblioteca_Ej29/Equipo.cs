using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_Ej29
{
    public class Equipo
    {
        #region Atributos

        private short cantidadDeJuadores;
        private List<Jugador> jugadores;
        private string nombre;

        #endregion

        #region Metodos

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad,string nombre)
        {
            this.cantidadDeJuadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool existe = false;
            foreach (Jugador item in e.jugadores)
            {
                if (item == j)
                {
                    existe = true;
                }
            }
            if (!existe && e.jugadores.Count < e.cantidadDeJuadores)
            {
                e.jugadores.Add(j);
                existe = true;
            }
            else
            {
                existe = false;
            }
            return existe;
        }
        #endregion
    }
}
