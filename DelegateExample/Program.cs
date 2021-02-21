using System;
using System.Threading;

namespace DelegateExample
{
    class Program
    {
        private delegate void CallMethod(); 

        /// <summary>
        /// 
        /// </summary>
        private static void func1()
        {
            Thread.Sleep(1000);  // Se espera 1 segundo, 

        }

        /// <summary>
        /// 
        /// </summary>
        private static void func2()
        {
            Thread.Sleep(2000);  // Se espera 1 segundo, 

        }

        /// <summary>
        /// 
        /// </summary>
        private static void func3()
        {
            Thread.Sleep(3000);  // Se espera 1 segundo, 

        }

        private static double MeasureExecutionTime(CallMethod callMethod)
        {
            var executionStart = DateTime.Now;
            callMethod();
            var executionEnd = DateTime.Now;
            return (executionEnd - executionStart).TotalMilliseconds; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Tiempo de ejecucion en func1 {MeasureExecutionTime(func1)} Ms");
            Console.WriteLine($"Tiempo de ejecucion en func1 {MeasureExecutionTime(func2)} Ms");
            Console.WriteLine($"Tiempo de ejecucion en func1 {MeasureExecutionTime(func3)} Ms");
        }
    }
}
