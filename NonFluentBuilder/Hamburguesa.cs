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
        Molde
    }

    public enum TipoCarne
    {
        Caballo,
        Vaca,
        Rellena
    }
    class Hamburguesa
    {
        public TipoPan pan { get; set; }
        public double costo { get; set; }
        public string nombre { get; set; }
        public string foto { get; set; }
        public List<string> ingredientes=new List<string>(); 
        public bool papas { get; set; }
        public TipoCarne carne { get; set; }

        public override string ToString()
        {
            return @"Tipo de Pan {}";
        }

        public Hamburguesa()
        {

        }

    }
}
