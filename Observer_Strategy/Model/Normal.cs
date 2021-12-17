using System;
using System.Collections.Generic;
using System.Text;

namespace Laba._19._11.Model
{
    public class Normal : IReaction // Observer
    {
        private string name;

        public Normal(string name, IChurch church)
        {
            this.name = name;
            church.registerNormal(this);
        }

        public void Reaction(string newsChurch)
        {
            Console.WriteLine(name + " узнал новость: " + newsChurch + "\nРеакция: не понял и ушел\n");
        }
    }
}