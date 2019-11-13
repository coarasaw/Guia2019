using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_Repaso
{
    public class Estante
    {
        #region MyRegion

        private Producto[] productos;
        private int ubicacionEstante;

        #endregion

        #region Metodos

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion): this(capacidad) 
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {            
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ubicacion " + e.ubicacionEstante);

            for (int i = 0; i < e.GetProductos().Count(); i++)
            {
                sb.AppendLine("Producto " + e.GetProductos()[i].GetMarca());
            }            

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool bandera = false;

            for (int i = 0; i < e.GetProductos().Count(); i++)
            {
                
                if (e.productos[i] is null)
                {
                    break;
                }
                else
                {
                    if (e.productos[i].GetMarca() == p.GetMarca())
                    {
                        bandera = true;
                        break;
                    }
                }
                
            }

            return bandera;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e,Producto p)
        {
            bool pudo = false;

            if (!(e==p))
            {
                for (int i = 0; i < e.GetProductos().Count(); i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        pudo = true;
                        break;
                    }
                }

            }
            return pudo;
        }

        public static bool operator -(Estante e, Producto p)
        {
            bool pudo = false;

            if (e == p)
            {
                for (int i = 0; i < e.GetProductos().Count(); i++)
                {
                    if (e.productos[i].GetMarca() == p.GetMarca())
                    {
                        e.productos[i] = null;
                        pudo = true;
                    }
                }

            }
            return pudo;
        }

        #endregion

    }
}
