using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFluentBuilder
{
    interface IFood
    {
        

        string print();
        double getCosto();
        void setId(long inID);
        long getID();

    }
}
