﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_47
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion) return true;
            return false;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public string Ficha()
        {
            return $"{this.nombre} fundado el {this.fechaCreacion}]";
        }
    }
}
