using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_Repaso
{
    public class Producto
    {
        #region Atributos

        private string codigoDeBarra;
        private string marca;
        private float precio;

        #endregion

        #region Metodos

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            float valor = this.precio;
            return valor;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca " + p.GetPrecio());
            sb.AppendLine("Precio " + p.GetPrecio());

            return sb.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p,string marca)
        {
            return (p.marca == marca);
        }

        public static bool operator !=(Producto p, string marca)
        {
            return (p == marca);
        }

        #endregion
    }
}
