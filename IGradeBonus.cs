using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_AustralianCricket
{
    interface IGradeBonus
    {
        double GRADE_BONUS_PERCENT
        {
            get;
            set;
        }
        double CalculateGradeBonus();
    }
}
