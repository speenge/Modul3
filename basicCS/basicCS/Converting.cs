using System;


namespace basicCS
{
    class Converting
    {
        static void Somthing()
        {
            // to string
            // anta variabel x - uansett datatype (av våre utvalgte)
            var x = true;
            string s = "" + x;
            double d = 99.123;
            string s2 = d.ToString("F");

            //to int
            int i = Convert.ToInt32(d);

            float f1 = Convert.ToSingle(i);
            float f2 = Convert.ToSingle(d);

            double d2 = Convert.ToDouble(s2);

        }
    }
}
