using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_CentralTelefonica
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        { }

        public string Mostrar()
        {
            Centralita c = new Centralita();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(c.Mostrar());
            sb.AppendLine("Costo LLamada " + CostoLlamada);
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return (this.Duracion * this.costo);
        }
    }
}
