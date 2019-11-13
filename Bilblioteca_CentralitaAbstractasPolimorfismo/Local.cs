using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_CentralitaAbstractasPolimorfismo
{
    public class Local : Llamada
    {
        #region Atributos & Propiedades

        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region Metodos

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
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

            sb.AppendLine(base.Mostrar().ToString());
            sb.AppendLine("Costo: " + this.CostoLlamada.ToString());
            
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

        #endregion

    }
}
