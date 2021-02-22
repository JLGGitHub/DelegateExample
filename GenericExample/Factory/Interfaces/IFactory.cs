using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample.Factory.Interfaces
{
    public interface IFactory<T>
    {
        T MakeGif(); 
    }
}
