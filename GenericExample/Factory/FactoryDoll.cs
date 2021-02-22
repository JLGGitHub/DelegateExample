using GenericExample.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample.Factory
{
    public class FactoryDoll : IFactory<Doll>
    {
        public Doll MakeGif() => new Doll(); 
    }
}
