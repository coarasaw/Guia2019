﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_43
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public short VueltaRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return (v1.Numero == v2.Numero && v1.Escuderia == v2.Escuderia);
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ------------- VehiculoDeCarrera -----------------");
            sb.AppendLine("Cantidad de Combustible " + CantidadCombustible.ToString());
            sb.AppendLine("En Competencia " + EnCompetencia.ToString());
            sb.AppendLine("Escuderia " + Escuderia);
            sb.AppendLine("Numero " + Numero.ToString());
            sb.AppendLine("Vueltas Restantes " + VueltaRestantes.ToString());
            sb.AppendLine(" ---------------------------------------------------");

            return sb.ToString();
        }
    }
}
