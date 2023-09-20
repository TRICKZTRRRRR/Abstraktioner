using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.Model
{
    internal class Chicken : Animals // Inherit from the Animals class
    {
        #region Variables
        private string _eggColor;
        #endregion

        internal Chicken(bool hasFeathers, bool hasFourLegs, bool isMammal, bool layEggs, bool hasFur, bool canFly, bool isMale, int age, string eats, string name, string eggColor) 
            :base(hasFeathers, hasFourLegs, isMammal, layEggs, hasFur, canFly, isMale, age, eats, name) 
        {
            _eggColor = eggColor;
        }
    }
}
