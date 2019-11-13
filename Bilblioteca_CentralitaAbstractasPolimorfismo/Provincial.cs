using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_CentralitaAbstractasPolimorfismo
{
    public class Provincial : Llamada
    {
        #region Atributos & Propiedades

        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region Metodos

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        { }

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

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja Horaria: " + this.franjaHoraria.ToString());
            sb.AppendLine("Costo de Llamada: " + this.CostoLlamada.ToString());
            
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

        #endregion

    }
}
