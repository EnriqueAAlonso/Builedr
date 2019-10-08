using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class PolloBuilder : SandwichBuilder
    {
        Sandwich burguer = new Sandwich();

        public PolloBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 60;
            burguer.foto = "Pollo.jpg";
            setIngredientes();
            burguer.nombre = "Pollo";
            burguer.pan = TipoPan.Blanco;
        }

        public Sandwich cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Lechuga");
            burguer.ingredientes.Add("Pollo");
            burguer.ingredientes.Add("Mayonesa");




        }
    }
}
