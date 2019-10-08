using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class VietnamBuilder : BaguetteBuilder
    {
        Baguette burguer = new Baguette();

        public VietnamBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 95;
            burguer.foto = "Vientam.jpg";
            setIngredientes();
            burguer.nombre = "Vietnam";
            burguer.pan = TipoPan.Molde;
        }

        public Baguette cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Carne");
            burguer.ingredientes.Add("Zanahoria");
            burguer.ingredientes.Add("Pimiento");
            burguer.ingredientes.Add("Lechuga");


        }

    }
}
