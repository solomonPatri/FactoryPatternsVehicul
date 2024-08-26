using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.abstract_Factory
{
    public  class BMWCar :Car
    {
        private string _model;
        private string _dataRepar;

         public BMWCar(string model, string dataRepar)
        {
            _model = model;
            _dataRepar = dataRepar;
        }

        public BMWCar(Location location) : base(Type.BMW, location)
        {

            Construct();
  
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public override void Construct()
        {
            Console.WriteLine("You create a new BMW Car");
        }




    }
}
