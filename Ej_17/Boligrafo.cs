using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 10; //100
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {            
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            
            if (this.tinta >= tinta)
            {
                this.tinta = (short)(this.tinta - tinta);                
            }
            else
            {
                this.tinta = (short)(this.tinta + tinta);
            }            
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool rta = true;
            int aPintar,cantidadPintada = 0;
            string dibujoCaracter = "";

            if (this.tinta >= gasto)
            {

                for (int i = 0; i < gasto; i++)
                {
                    dibujoCaracter = dibujoCaracter + "*";
                    cantidadPintada++;
                }
                SetTinta(gasto);
            }
            else
            {
                if (this.tinta <= gasto)
                {
                    aPintar = this.tinta;
                    for (int i = 0; i < gasto; i++)
                    {
                        if (aPintar != 0)
                        {
                            dibujoCaracter = dibujoCaracter + "*";
                            cantidadPintada++;
                            aPintar = aPintar - 1;
                        }
                        
                    }
                    SetTinta(gasto);
                }

            }
            if (this.tinta < 0)
            {
                this.tinta = 0;
                rta = false;
            }            
           
            dibujo = dibujoCaracter + " Cantidad de *  es " + cantidadPintada;
            return rta;
        }

        public static string Mostrar(Boligrafo b)
        {
            StringBuilder boligrafo = new StringBuilder();
            boligrafo.Append("Color ");
            boligrafo.Append(b.GetColor().ToString() + "  ");
            boligrafo.Append(b.GetTinta().ToString());

            return boligrafo.ToString();
        }
    }
}
