using System;

namespace Laba._19._11
{
    public class Parishioner : IReaction //Observer
    {
        private string name;

        public Parishioner(string name, IChurch church)
        {
            this.name = name;
            church.registerParishioner(this);
        }

        public void Reaction(string newsChurch)
        {
           Console.WriteLine(name + " узнал новость: " + newsChurch + "\nРеакция: принял, купил\n");
        }
    }
}