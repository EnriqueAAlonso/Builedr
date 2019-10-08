﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder.Builders
{
    class GruesoBuilder : BaguetteBuilder
    {
        Baguette burguer = new Baguette();

        public GruesoBuilder(long id) : base(id)
        {
            burguer.setId(id);
            burguer.costo = 95;
            burguer.foto = "Grueso.jpg";
            setIngredientes();
            burguer.nombre = "Grueso";
            burguer.pan = TipoPan.Molde;
        }

        public Baguette cocinar()
        {
            return burguer;
        }

        public void setIngredientes()
        {
            burguer.ingredientes.Add("Jamon");
            burguer.ingredientes.Add("Queso Amarillo");
            burguer.ingredientes.Add("Cebolla");
            burguer.ingredientes.Add("Tomate");


        }

    }
}