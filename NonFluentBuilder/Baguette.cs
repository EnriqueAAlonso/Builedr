using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder
{
    public class Baguette:IFood
    {
        public TipoPan pan
        {
            get;
            set;
        }

        public string aderezo;
        public string nombre;
        public List<string> ingredientes=new List<string>();
        public long id;
        public string foto;
        public double costo;
        public double getCosto()
        {
            return costo;
        }

        public void setId(long inID)
        {
            id = inID;
        }

        public long getID()
        {
            return id;
        }


        public string print()
        {
            string ingreds = "";
            foreach (var ing in ingredientes)
            {
                ingreds += ing + " ";
            }
            return $"ID {id}| Nombre {nombre}| Costo {costo}| Ingredientes{ingreds}|Tipo de Pan{pan} |Aderezo {aderezo}";
        }
    }
}
