using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_41
{
    class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(origen, destino, duracion)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        { }

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = (float)0.99 * Duracion;
                    break;
                case Franja.Franja_2:
                    costo = (float)1.25 * Duracion;
                    break;
                case Franja.Franja_3:
                    costo = (float)0.66 * Duracion;
                    break;
                default:
                    break;
            }
            return costo;

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Franja Horaria: " + this.franjaHoraria.ToString());
            sb.AppendLine("Costo de Llamada: " + this.CostoLlamada.ToString());
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
