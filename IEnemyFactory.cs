using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IEnemyFactory
    {
        IWeapon GetWeapon();
        IArmor GetArmor();
    }
}
