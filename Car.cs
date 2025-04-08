using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_McVey_Cason
{
    class Car
    {
        // Privated
        private string model;

        // any string with Model in it get updated and returned
        public string Model { get { return model; } set { model = value; }  }

        // This code is an automatic property
        public string Make { get; set; }




    }
}
