using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns
{
    public abstract class Vehicle
    {
        private int _id;
        private string _type;
        private int _year;
        public Vehicle(int id, string type, int year)
        {
            Id = id;
            Type = type;
            Year = year;

        }
        public Vehicle()
        {

        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public abstract void AfisareVehicul();


        public abstract Vehicle ReturnVehicul();








    }
}
