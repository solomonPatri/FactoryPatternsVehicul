using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Methods_Design_Patterns.class_TypeVehicle
{
    internal class FourWheeler : Vehicle
    {
        private string _prop;
        private string _model;
        private string _nrmatr;


        public FourWheeler(int id, string type, int year, string model, string prop, string nrmatric) : base(id, type, year)
        {
            this._model = model;
            this._prop = prop;
            this._nrmatr = nrmatric;


        }

        public FourWheeler() : base()
        {

        }
        public string Prop
        {


            get { return _prop; }
            set { _prop = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Nrmatr
        {
            get { return _nrmatr; }
            set { _nrmatr = value; }
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
            t += "Propietar: " + Prop + "\n";
            t += "Numarul de Matricola: " + Nrmatr + "\n";

            return t;



        }


        public override Vehicle ReturnVehicul()
        {
            FourWheeler masina = new FourWheeler(Id, Type, Year, Model,Prop,Nrmatr);

            masina.Id = Id;
            masina.Year = Year;
            masina.Type = Type;
            masina.Model = Model;
            masina._prop = Prop;
            masina._nrmatr = Nrmatr;
            return masina;





        }





    }
}
