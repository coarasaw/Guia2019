using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_CentralTelefonica
{
    public enum TipoLlamada
    {
        Local,
        Provincia,
        Todas
    }
    public class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Propiedades
        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        #endregion
        #region Metodos
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duración " + Duracion);
            sb.AppendLine("Nro Destino " + NroDestino);
            sb.AppendLine("Nro Origen " + NroOrigen);
            return sb.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;
            }

            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            return retorno;
        }

        #endregion
    }
}
