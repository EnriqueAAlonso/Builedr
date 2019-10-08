using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class ClubBuilder : SandwichBuilder
    {
        Sandwich burguer = new Sandwich();

        public ClubBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 75;
            burguer.foto = "Club.jpg";
            setIngredientes();
            burguer.nombre = "Club";
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
            burguer.ingredientes.Add("Pollo");




        }
    }
    
}
