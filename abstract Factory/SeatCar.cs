using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Factory_Methods_Design_Patterns.abstract_Factory
{
    public class SeatCar: Car
    {
        private string _propietar;
        private string _model;

        public SeatCar(string propietar, string model)
        {
            propietar = _propietar;
            model = _model;
        }
        public string Prop
        {
            get { return _propietar; }
            set { _propietar = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public SeatCar(Location location, string propietar, string model):base(Type.Seat,location)
        {
            propietar = _propietar;
            model = _model;

        }


        public SeatCar(Location location) : base(Type.Seat, location)
        {
            Construct();

        }

        public override void Construct()
        {
            Console.WriteLine("You create a new Seat Car");
        }
        


    }
}
