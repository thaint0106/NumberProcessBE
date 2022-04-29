using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessApplication.Extentions
{
    public static class Extention
    {
        public static bool MyEmpty(this string str)
        {
            return String.IsNullOrEmpty(str);
        }
    }
}
