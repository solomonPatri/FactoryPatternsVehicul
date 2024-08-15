using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Factory_Methods_Design_Patterns;

namespace Factory_Methods_Design_Patterns.class_TypeVehicle
{
    public class TwoWheeler : Vehicle
    {
        private string _culoare;
        private string _propietar;

        public TwoWheeler(int id, string type, int year, string culoare, string propietar) : base(id, "Two Wheeler", year)
        {

            this._culoare = culoare;
            this._propietar = propietar;
        }
        public TwoWheeler() : base() { 
        
        
        
        }
        

        public string Culoare
        {
            get { return _culoare; }
            set { _culoare = value; }
        }

        public string Propietar
        {
            get { return _propietar; }
            set { _propietar = value; }
        }


        public override void AfisareVehicul()
        {
            Console.WriteLine(this.ToString());

        }
        public string ToString()
        {
            string text = " ";
            text += "Type: " + base.Type + "\n";
            text += "Year: " + base.Year + "\n";
            text += "Culoare: " + Culoare + "\n";
            text += "Propietar: " + Propietar + "\n";
            return text;
        }

        public override Vehicle ReturnVehicul()
        {
           TwoWheeler masina = new TwoWheeler(Id,Type,Year,Culoare,Propietar);

            masina.Id = Id;
            masina.Year = Year;
            masina.Type = Type;
            masina.Culoare = Culoare;
            masina.Propietar = Propietar;
           
            return masina;





        }

       








    }
}
