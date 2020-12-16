using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Sword : IWeapon
    {
        public string Item()
        {
            return "Очень острый меч!";
        }
    }
}
