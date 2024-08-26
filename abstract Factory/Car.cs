using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.abstract_Factory
{
    public abstract class Car
    {
        private Type _type;
        private Location _location;
        protected Car(Type type, Location location)
        {

            type = _type;
            location = _location;


        }
        public Car()
        {

        }
        public Type Tipul
        {
            get { return _type; }
            set { _type = value; }
        }
        public Location Locat 
        {
            get { return _location; }
            set { _location = value; }
        }

        public abstract void Construct();

        public void  ToString()
        {
            Console.WriteLine("Masina: " + Tipul + "se gaseste in Tara: " + Locat);

        }

         


    }
}
