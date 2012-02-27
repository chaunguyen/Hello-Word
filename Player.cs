using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_AustralianCricket
{
    abstract class Player
    {
        public abstract string Name { get; set; }

        public abstract void DisplayDetail();
    }
}
