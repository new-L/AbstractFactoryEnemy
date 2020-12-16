using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Wand : IWeapon
    {
        public string Item()
        {
            return "Великий посох какого-то древнего и очень могучего мага!";
        }
    }
}
