using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.class_TypeVehicle
{
    internal class ThreeWheeler : Vehicle
    {
        private string _model;
        private string _culoare;
        private int _kilometraj;

        public ThreeWheeler(int id, string type, int year, string model, string culoare, int kilometraj) : base(id, type, year)
        {
            this._model = model;
            this._culoare = culoare;
            this._kilometraj = kilometraj;

        }
        public ThreeWheeler() : base()
        {

        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Culoare
        {
            get { return _culoare; }
            set { _culoare = value; }
        }
        public int Kilometraj
        {
            get { return _kilometraj; }
            set { _kilometraj = value; }
        }

        public override void AfisareVehicul()
        {
            Console.WriteLine(this.ToString());
        }

        public string ToString()
        {
            string t = " ";
            t += "Type: " + base.Type + "\n";
            t += "Year: " + base.Year + "\n";
            t += "Model: " + Model + "\n";
            t += "Culoare: " + Culoare + "\n";
            t += "Kilometraj: " + Kilometraj + "\n";

            return t;



        }

        public override Vehicle ReturnVehicul()
        {
            ThreeWheeler masina = new ThreeWheeler(Id, Type, Year, Model,Culoare,Kilometraj);

            masina.Id = Id;
            masina.Year = Year;
            masina.Type = Type;
            masina.Model = Model;
            masina.Culoare = Culoare;
            masina.Kilometraj = Kilometraj;
            return masina;





        }

       



    }
}
