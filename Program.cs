using System;

namespace WK1LotsOfProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var wk1 = new Week1Properties();
            wk1.SetReadAndWritePropertyWithMethods("Hallo");
            wk1.ReadAndWriteProperty = " ";
            wk1.ReadAndWritePropertyFull = "Wereld";
            wk1.ReadAndWritePropertyFullLambda = "!";
            Console.WriteLine($"{wk1.GetReadAndWritePropertyWithMethods()}{wk1.ReadAndWriteProperty}{wk1.ReadAndWritePropertyFull}{wk1.ReadAndWritePropertyFullLambda}");
            Console.ReadLine();
        }
    }
}
