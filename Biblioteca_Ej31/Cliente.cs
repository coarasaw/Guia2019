using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ej31
{
    public class Cliente
    {
        #region Atributos privados & Propiedades para ser publicos

        private string nombre;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        private int numero;

        public int Numero
        {
            get { return numero; }            
        }

        #endregion

        #region Metodos

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return (c1.numero == c2.numero);
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        #endregion
    }
}
