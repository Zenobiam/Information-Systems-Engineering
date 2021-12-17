using PatternFabric.Kinds;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFabric.Creators
{
    class PlateBlacksmith : Blacksmith
    {       
        public override Armor Create()
        {
            return new PlateArmor();
        }            
    }
}
