using GenericExample.Factory;
using GenericExample.Factory.Interfaces;
using GenericExample.Helper;
using System;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var doll = new Doll();
            //var car = new Car();
            //var pencil = new Pencil(); 
            //var box = new Box<Doll>();
            //var box2 = new Box<Car>();
            //var box3 = new Box<Pencil>();
            //box.Put(doll); 
            //box2.Put(car); 
            //box3.Put(pencil);

            IFactory<Car> factory = new FactoryCars();
            var gifs = BoxHelper.GenerateGifs<Car>(5, factory.MakeGif); 


        }
    }
}
