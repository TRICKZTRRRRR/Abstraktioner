using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.Model
{
    internal class Rabbit : Animals // Inherit from the Animals class
    {
        #region Variables
        private int _blinkPerMin;
        #endregion

        internal Rabbit(bool hasFeathers, bool hasFourLegs, bool isMammal, bool layEggs, bool hasFur, bool canFly, bool isMale, int age, string eats, string name, int blinkPerMin)
                : base(hasFeathers, hasFourLegs, isMammal, layEggs, hasFur, canFly, isMale, age, eats, name)
        {
            _blinkPerMin = blinkPerMin;
        }
    }
}
