using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class DobleBuilder
    {
        Hamburguesa burguer=new Hamburguesa();

        public DobleBuilder()
        {
            burguer.carne = TipoCarne.Caballo;
            burguer.costo = 70;
            burguer.foto = "Doble.jpg";
            setIngredientes();
            burguer.nombre = "Doble";
            burguer.pan = TipoPan.Blando;
            burguer.papas = false;
        }

        public Hamburguesa cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Tomate");
            burguer.ingredientes.Add("Queso Blanco");
            burguer.ingredientes.Add("Lechuga");



        }

    }
}
