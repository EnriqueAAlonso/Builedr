using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder
{
    public enum TipoPan
    {
        Blando,
        Molde,
        Centeno,
        Blanco,
        Integral
    }

    public enum TipoCarne
    {
        Caballo,
        Vaca,
        Rellena
    }
    public class Hamburguesa:IFood
    {
        public TipoPan pan { get; set; }
        public long id { get; set; }
        public double costo { get; set; }

        
        public string nombre { get; set; }

        public string foto { get; set; }
        public List<string> ingredientes=new List<string>(); 
        public bool papas { get; set; }
        public TipoCarne carne { get; set; }

        

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
            return $"ID {id}| Nombre {nombre}| Costo {costo}| Tipo de Carne {carne}|Tipo de Pan{pan} |Papas{papas}";
        }

        public override string ToString()
        {
            return @"Tipo de Pan {}";
        }

        public Hamburguesa()
        {

        }

    }
}
