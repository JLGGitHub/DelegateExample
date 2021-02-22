using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample.Helper
{
    public static class BoxHelper
    {

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numberOfGifs"></param>
        /// <param name="getContent"></param>
        /// <returns></returns>
        public static List<Box<T>> GenerateGifs<T>(int numberOfGifs, Func<T> getContent)
        {
            var lstGifs = new List<Box<T>>();
            for (int i = 0; i < numberOfGifs; i++)
            {
                var box = new Box<T>();
                box.Put(getContent());
                lstGifs.Add(box);
            }

            return lstGifs; 
        }
    }
}
