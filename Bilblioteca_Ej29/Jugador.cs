using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_Ej29
{
    public class Jugador
    {
        #region Atributos

        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        #endregion

        #region Metodos

        public float GetPromedioGoles()
        {
            return this.promedioGoles = (float)(this.totalGoles / this.partidosJugados);
        }

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre " + this.nombre);
            sb.AppendLine("DNI " + this.dni);
            sb.AppendLine("Partidos Jugados " + this.partidosJugados);
            sb.AppendLine("Promedio Goles " + GetPromedioGoles());
            sb.AppendLine("Total de Goles " + this.totalGoles);

            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        #endregion
    }
}
