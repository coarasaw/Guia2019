using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_41
{
    class Local : Llamada
    {
        protected float costo;
        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public Local(string origen, float duracion, string destino, float costo)
            : base(origen, destino, duracion)
        {
            this.costo = costo;
        }

        public Local(Llamada unaLlamada, float costo)
            : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)
        { }

        private float CalcularCosto()
        {
            float costo = 0;
            costo += this.costo * base.duracion;
            return costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Costo: " + this.CostoLlamada.ToString());
            sb.AppendLine(base.Mostrar().ToString());

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;
            return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }

    }
}
