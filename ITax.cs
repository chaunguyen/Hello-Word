using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_AustralianCricket
{
    interface ITax
    {
        double Tax_Percent { get; set; }

        double CalculateTax();
    }
}
