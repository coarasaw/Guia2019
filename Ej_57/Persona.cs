using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Ej_57
{
    public class Persona
    {
        public string apellido;
        public string nombre;

        public Persona()
        { }
    
        public Persona(string vApellido, string vNombre)
        {
            this.apellido = vApellido;
            this.nombre = vNombre;
        }

        public static string Guardar(Persona persona)
        {
            try
            {
                DateTime myDateTime = DateTime.Now;
                string year = myDateTime.Year.ToString();
                string mes = myDateTime.Month.ToString();
                string dia = myDateTime.Day.ToString();
                string hora = myDateTime.Hour.ToString();
                string minuto = myDateTime.Minute.ToString();
                string fecha = year + mes + dia + "-" + hora + minuto;

                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = folder + Path.DirectorySeparatorChar + "Ej57-" + fecha + ".xml";

                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                string rutaArchivoXml = filePath;
                XmlTextWriter writer = new XmlTextWriter(rutaArchivoXml, Encoding.UTF8);
                serializer.Serialize(writer, persona);
                writer.Close();
                return rutaArchivoXml;
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Error Guardar ", e.ToString());
                return "";
            }
            
        }
        
        public static Persona Leer(Persona persona,string archivo)
        {
            try
            {
                Persona datoLeido;
              
                //string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                //string filePath = folder + Path.DirectorySeparatorChar + archivo; //"Ej57-2019114-208.xml";  //Tomar el nombre del archivo que se gueda
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                //XmlTextReader writer = new XmlTextReader(filePath);
                XmlTextReader writer = new XmlTextReader(archivo);
                datoLeido = (Persona)serializer.Deserialize(writer);
                writer.Close();
                return datoLeido;
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Lleer ", e.ToString());
                return null;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Apellido " +  this.apellido);
            sb.AppendLine("Nombre   " + this.nombre);

            return sb.ToString();
        }

    }
}
