using Factory_Methods_Design_Patterns;
using Factory_Methods_Design_Patterns.class_TypeVehicle;
using Factory_Methods_Design_Patterns.service;
using System;

internal class Program
{
        public static void Main(string[] args)
        {
          
           ServiceVehicul vh = new ServiceVehicul();

             vh.afisare();
           
            Client cl = new Client();
           cl.BuildVehicle(VehicleType.TwoWheeler);
            Vehicle vhnew = cl.GetVehicle();
            vh.InformComplete(vhnew);    //mi sa adauga pe moment si imi afiseaza dar in momentul cand dau run pentru a doua oara nu este adaugat
            vh.adaugareVehicle(vhnew);
            vh.afisare();
           
           












        }






    



}











