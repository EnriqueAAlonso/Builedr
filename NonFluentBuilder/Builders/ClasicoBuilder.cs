using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class ClasicoBuilder : SandwichBuilder
    {
        Sandwich burguer = new Sandwich();

        public ClasicoBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 55;
            burguer.foto = "Clasico.jpg";
            setIngredientes();
            burguer.nombre = "Clasico";
            burguer.pan = TipoPan.Integral;
        }

        public Sandwich cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Tomate");
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Lechuga");
            burguer.ingredientes.Add("Atun");




        }
    }
}
