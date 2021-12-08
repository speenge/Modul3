using System;

namespace MultiDimentionalMadness
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr3d = new int[12, 12, 2];
            arr3d[0, 0, 0] = 13;
            arr3d[0, 0, 1] = 4;
            var storage = arrtest.StorageArray;
            storage.SetValue("testings",0,0);

            Console.WriteLine(arr3d[0,0,0] + " " + arr3d[0, 0, 1] + " " + storage.GetValue(0,0));
            Console.ReadKey();
            
        }
    }
}
