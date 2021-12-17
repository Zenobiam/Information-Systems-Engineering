using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFabric
{
    abstract public class Blacksmith
    {        
        // Fabric method begin
        public abstract Armor Create();
    }

   public abstract class Armor { }
}
