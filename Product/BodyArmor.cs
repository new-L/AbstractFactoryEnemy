using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class BodyArmor : IArmor
    {
        public string Item()
        {
            return "Железные латы";
        }
    }
}
