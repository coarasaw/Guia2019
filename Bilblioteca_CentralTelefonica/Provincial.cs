using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_CentralTelefonica
{
        public class Provincial : Llamada
        {
            #region Atributos
            private Franja franjaHoraria;
            #endregion

            #region Propiedades
            public float CostoLlamada
            {
                get { return CalcularCosto(); }
            }
            #endregion

            #region Metodos
            public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
            {
                this.franjaHoraria = miFranja;
            }
            public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion, destino, origen))
            {

            }
            public string Mostrar()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(base.Mostrar());
                sb.AppendLine("Costo Llama " + CostoLlamada);
                sb.AppendLine("Franja Horaia " + this.franjaHoraria);
                return sb.ToString();
            }
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
                }
                return costo;
            }
            public enum Franja
            {
                Franja_1,
                Franja_2,
                Franja_3
            }
            #endregion
        }
}
