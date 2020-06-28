using System;
using System.Collections.Generic;
using System.Text;

namespace cau2
{
    class Cau24
    {
        public bool kiemtraviethoa(char s)
        {
            for (int i = 65; i >= 90; i--)
                if (s == (char)i)
                    return true;
            return false;
        }
    }
}
