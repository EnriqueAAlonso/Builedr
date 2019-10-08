using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder
{
    class Sandwich:IFood
    {
        public TipoPan pan {
            get;
            set;
        }

        public string nombre;
        public List<string> ingredientes=new List<string>();
        public long id;
        public double costo;
        public string foto;
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
                ingreds += ing+" ";
            }
            return $"ID {id}| Nombre {nombre}| Costo {costo}| Ingredientes{ingreds}|Tipo de Pan{pan} ";
        }
    }
}
