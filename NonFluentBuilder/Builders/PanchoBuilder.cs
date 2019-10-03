using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class PanchoBuilder
    {
        Hamburguesa burguer = new Hamburguesa();
        public PanchoBuilder()
        {
            burguer.carne = TipoCarne.Vaca;
            burguer.costo = 100;
            burguer.foto = "Pancho.jpg";
            setIngredientes();
            burguer.nombre = "Pancho";
            burguer.pan = TipoPan.Blando;
            burguer.papas = true;
        }

        public Hamburguesa cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Lechuga");
            burguer.ingredientes.Add("Queso En Tiras");
            burguer.ingredientes.Add("Tocino");
            burguer.ingredientes.Add("Queso blanco");
            burguer.ingredientes.Add("Mayonesa");

        }
    }
}
