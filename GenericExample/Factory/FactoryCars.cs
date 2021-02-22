using GenericExample.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample.Factory
{
    public class FactoryCars : IFactory<Car>
    {
        public Car MakeGif() => new Car(); 
    }
}
