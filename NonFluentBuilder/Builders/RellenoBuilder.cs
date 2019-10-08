using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class RellenoBuilder : SandwichBuilder
    {
        Sandwich burguer = new Sandwich();

        public RellenoBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 95;
            burguer.foto = "relleno.jpg";
            setIngredientes();
            burguer.nombre = "Relleno";
            burguer.pan = TipoPan.Molde;
        }

        public Sandwich cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Carne");
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Jamon");
            
        }
    }

}
