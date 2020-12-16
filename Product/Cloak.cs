using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Cloak : IArmor
    {
        public string Item()
        {
            return "Одеяние мага";
        }
    }
}
