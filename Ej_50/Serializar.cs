using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_50
{
    public class Serializar<T, V> : IGuardar<T, V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }
        public V Leer()
        {
            string str = "Objeto Leído";
            return (V)Convert.ChangeType(str, typeof(V));
        }
    }
}
