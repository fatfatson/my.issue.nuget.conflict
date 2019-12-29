using System;

namespace DirectLib
{
    public class Class1
    {
        public static int GetValue()
        {
            return ConflictLib.Class1.GetValue() * 2;
        }
    }
}
