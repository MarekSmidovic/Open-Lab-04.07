using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] myArr = original.ToCharArray();
            Array.Reverse(myArr);
            return new string(myArr);
        }
    }
}
