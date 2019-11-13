using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca_Ej31
{
    //public enum Puesto
    //{
    //    Caja1,
    //    Caja2
    //}
    public class PuestoAtencion
    {       
        #region Atributos & Propiedades

        private static int numeroActual;

        public static int NumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;
            }           
        }

        private Puesto puesto;

        #endregion

        #region Metodos

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        #endregion

    }
    
}
