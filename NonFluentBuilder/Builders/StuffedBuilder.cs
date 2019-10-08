using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class StuffedBuilder : BaguetteBuilder
    {
        Baguette burguer = new Baguette();

        public StuffedBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 95;
            burguer.foto = "Stuffed.jpg";
            setIngredientes();
            burguer.nombre = "Stuffed";
            burguer.pan = TipoPan.Molde;
        }

        public Baguette cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Carne");
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Cebolla");
            burguer.ingredientes.Add("Hierba");


        }

    }
}
