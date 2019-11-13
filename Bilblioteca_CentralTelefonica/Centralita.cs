using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilblioteca_CentralTelefonica
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        #endregion

        #region Propiedades
        public float GanaciasPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GanaciasPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincia);
            }
        }

        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }
        public List<Llamada> ListaDeLlamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0, gananciaLoc = 0, gananciaProv = 0;

            foreach (Llamada item in listaDeLlamadas)
            {
                if (tipo == TipoLlamada.Local && item is Local)
                {
                    ganancia += ((Local)item).CostoLlamada;
                }
                if (tipo == TipoLlamada.Provincia && item is Provincial)
                {
                    ganancia += ((Provincial)item).CostoLlamada;
                }
                if (tipo == TipoLlamada.Todas)
                {
                    if (item is Local)
                    {
                        gananciaLoc += ((Local)item).CostoLlamada;
                    }
                    if (item is Provincial)
                    {
                        gananciaProv += ((Provincial)item).CostoLlamada;
                    }
                    ganancia = gananciaLoc + gananciaProv;
                }
            }
            return ganancia;
        }
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon Social          " + this.razonSocial);
            sb.AppendLine("Ganancia Total        " + this.GananciaPorTotal);
            sb.AppendLine("Ganancia Locales      " + this.GanaciasPorLocal);
            sb.AppendLine("Ganancia Provinciales " + this.GanaciasPorProvincial);
            foreach (Llamada item in listaDeLlamadas)
            {
                sb.AppendLine("Nro Origen " + item.NroOrigen);
                sb.AppendLine("Nro Destino " + item.NroDestino);
            }
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion
    }
}
