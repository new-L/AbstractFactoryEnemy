using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Warrior : IEnemyFactory
    {
        public IWeapon GetWeapon()
        {
            return new Sword();
        }
        public IArmor GetArmor()
        {
            return new BodyArmor();
        }
    }
}
