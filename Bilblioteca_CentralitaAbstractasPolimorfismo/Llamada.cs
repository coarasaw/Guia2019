using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_CentralitaAbstractasPolimorfismo
{
    public abstract class Llamada
    {
        #region Atributos & Propiedades

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }
        public abstract float CostoLlamada { get; }

        #endregion

        #region Metodos

        public Llamada(float duracion, string destino, string origen)
        {
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;                       
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Duracion: " + this.duracion.ToString());
            sb.AppendLine("Numero Destino: " + this.nroDestino.ToString());
            sb.AppendLine("Numero Origen: " + this.nroOrigen.ToString());
            
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return uno.Duracion.CompareTo(dos.Duracion);
        }

        public static bool operator ==(Llamada uno, Llamada dos)
        {
            if ((uno.Equals(dos) && (uno.NroDestino == dos.NroDestino) && (uno.NroOrigen == dos.NroOrigen)))
                return true;
            return false;
        }
        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }

        #endregion

    }
}
