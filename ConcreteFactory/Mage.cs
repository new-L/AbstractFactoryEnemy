using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Mage : IEnemyFactory
    {
        public IWeapon GetWeapon()
        {
            return new Wand();
        }
        public IArmor GetArmor()
        {
            return new Cloak();
        }
    }
}
