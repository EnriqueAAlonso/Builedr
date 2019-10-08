using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class FullBuilder:SandwichBuilder
    {
        Sandwich burguer = new Sandwich();

        public FullBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 85;
            burguer.foto = "Full.jpg";
            setIngredientes();
            burguer.nombre = "Full";
            burguer.pan = TipoPan.Blanco;
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
            burguer.ingredientes.Add("Ranch");
            burguer.ingredientes.Add("ketchup");




        }
    }
}
