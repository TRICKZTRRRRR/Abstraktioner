using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.Model
{
    internal class Dog : Animals // Inherit from the Animals class
    {
        #region Variables
        private int _tailLength;
        private bool _hasDoubleCoat;
        #endregion

        internal Dog(bool hasFeathers, bool hasFourLegs, bool isMammal, bool layEggs, bool hasFur, bool canFly, bool isMale, int age, string eats, string name, int tailLenght, bool hasDoubleCoat)
            : base(hasFeathers, hasFourLegs, isMammal, layEggs, hasFur, canFly, isMale, age, eats, name)
        {
            _tailLength = tailLenght;
            _hasDoubleCoat = hasDoubleCoat;
        }
    }
}
