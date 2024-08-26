using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.abstract_Factory
{
    public  class FordCar:Car
    {
        private string _fabricaname;
        private int _year;

        public FordCar(string fabricaname, int year)
        {
            _fabricaname = fabricaname;
            _year = year;
        }

        public FordCar(Location location) : base(Type.Ford, location)
        {

            Construct();

        }


        public string Fabr
        {
            get { return _fabricaname; }
            set { _fabricaname = value; }
        }


        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public override void Construct()
        {
            Console.WriteLine("You create a new Ford Car");
        }




    }
}
