using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.Model
{
    internal class Animals
    {
        #region Fields
        private bool _hasFeathers;
        private bool _hasFourLegs;
        private bool _isMammal;
        private bool _layEggs;
        private bool _hasFur;
        private bool _canFly;
        private bool _isMale;
        public int age;
        private string _eats;
        private string _name;
        #endregion

        #region Constructor
        protected Animals(bool hasFeathers, bool hasFourLegs, bool isMammal, bool layEggs, bool hasFur, bool canFly, bool isMale, int age, string eats, string name)
        {
            _hasFeathers = hasFeathers;
            _hasFourLegs = hasFourLegs;
            _isMammal = isMammal;
            _layEggs = layEggs;
            _hasFur = hasFur;
            _canFly = canFly;
            _isMale = isMale;
            this.age = age;
            _eats = eats;
            _name = name;
        }
        #endregion
    }
}
