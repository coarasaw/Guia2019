using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Ej_61_Form
{
    public class PersonaDAO
    {

        public static void Guardar(Persona p)
        {
            
            SqlConnection conect = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            //SqlConnection conect = new SqlConnection("Data Source=HNPMW12-144\\SQLEXPRESS;Initial Catalog=Personal;Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conect;
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = string.Format("INSERT INTO Personal (nombre,apellido) VALUES('{0}','{1}')", p.Nombre, p.Apellido);
            conect.Open();
            comando.ExecuteNonQuery();
            conect.Close();
        }

        public static List<Persona> Leer()
        {
            List<Persona> dato = new List<Persona>();

            SqlConnection conect = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conect;
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = string.Format("select * from Personal");
            conect.Open();

            SqlDataReader leer;
            leer = comando.ExecuteReader();

            while (leer.Read() == true)
            {                
                int a = 0;
                int.TryParse(leer["id"].ToString(), out a);
                Persona p = new Persona(a, leer["nombre"].ToString(), leer["apellido"].ToString());
                dato.Add(p);
            }
            conect.Close();
            return dato;
        }

        public static void Modificar(Persona p)
        {

            SqlConnection conect = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");            
            SqlCommand comando = new SqlCommand();
            comando.Connection = conect;
            comando.CommandType = System.Data.CommandType.Text;

            string enviar = "UPDATE Personal SET nombre = '" + p.Nombre + "', apellido = '" + p.Apellido + "' WHERE id = " + p.ID;            
            comando.CommandText = string.Format(enviar);
            conect.Open();
            comando.ExecuteNonQuery();
            conect.Close();
        }
        
        public static void Eliminar(Persona p)
        {

            SqlConnection conect = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Persona;Integrated Security=True");
            SqlCommand comando = new SqlCommand();
            comando.Connection = conect;
            comando.CommandType = System.Data.CommandType.Text;

            string enviar = "DELETE FROM Personal WHERE id = " + p.ID;

            comando.CommandText = string.Format(enviar);
            conect.Open();
            comando.ExecuteNonQuery();
            conect.Close();
        }
    }
}
