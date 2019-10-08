using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class JamonBuilder : BaguetteBuilder
    {
        Baguette burguer = new Baguette();

        public JamonBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 95;
            burguer.foto = "Jamon.jpg";
            setIngredientes();
            burguer.nombre = "Jamon";
            burguer.pan = TipoPan.Molde;
        }

        public Baguette cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Jamon");
            burguer.ingredientes.Add("Queso Americano");
            burguer.ingredientes.Add("Lechuga");
            burguer.ingredientes.Add("Tomate");


        }

    }
}
