﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_48
{
    public class Factura : Documento
    {
        public Factura(int numero) : base(numero) { }

        public override string Mostrar()
        {
            return $"F: {base.Mostrar()}";
        }
    }
}
