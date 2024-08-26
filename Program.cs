using Factory_Methods_Design_Patterns;
using Factory_Methods_Design_Patterns.class_TypeVehicle;
using Factory_Methods_Design_Patterns.service;
using Factory_Methods_Design_Patterns.singleton;
using System;
using Factory_Methods_Design_Patterns.abstract_Factory;
internal class Program
{
        public static void Main(string[] args)
        {

        //ServiceVehicul vh = new ServiceVehicul();

        // vh.afisare();

        // Client cl = new Client();
        //cl.BuildVehicle(VehicleType.TwoWheeler);
        // Vehicle vhnew = cl.GetVehicle();
        // vh.InformComplete(vhnew);    //* mi sa adauga pe moment si imi afiseaza dar in momentul cand dau run pentru a doua oara nu este adaugat
        // vh.adaugareVehicle(vhnew);
        // vh.afisare();


        ///////////* Se instantiasa un singleton unic si cu functia DoSomething/////////////////////////////////////////

        //Singleton.GetInstance().DoSomething();
        //////Nu ne permite sa se instantieze a doua oara//////

        // Singleton.GetInstance();

        ///////Abstract  Factory  /////////////////////////////////////
         Console.WriteLine(CarFactory.BuildCar(Factory_Methods_Design_Patterns.abstract_Factory.Type.Seat));
        //Console.WriteLine(CarFactory.BuildCar(Factory_Methods_Design_Patterns.abstract_Factory.Type.Ford));
        //Console.WriteLine(CarFactory.BuildCar(Type.BMW));  ///Nu Ma lasa daca nu apele type-ul ca si mai sus










    }










}











