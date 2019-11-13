using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_41
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }
        public abstract float CostoLlamada { get; }

        public Llamada(string origen, string destino, float duracion)
        {
            this.nroOrigen = origen;
            this.nroDestino = destino;
            this.duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero Destino: " + this.nroDestino.ToString());
            sb.AppendLine("Numero Origen: " + this.nroOrigen.ToString());
            sb.AppendLine("Duracion: " + this.duracion.ToString());

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
    }
}
