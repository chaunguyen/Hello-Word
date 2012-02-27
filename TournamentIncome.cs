using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_AustralianCricket
{
    class TournamentIncome : Player, IGradeBonus
    {
        #region Properties/Fields
        double _grade;
        public double Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }
        double _rate;
        public double Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        string _name;
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _chautest;
        #endregion 

        #region constructor
        /// <summary>
        /// Constructor of class TournamentIncome
        /// </summary>
        /// <param name="n">The name of Player</param>
        /// <param name="grade">The Grade of Player</param>
        /// <param name="rate">The Rate of Player</param>
        public TournamentIncome(string n, int grade, double rate)
        {
            this._name = n;
            this._grade = grade;
            this._rate = rate;
        }
        #endregion
        public double GRADE_BONUS_PERCENT
        {
            set;
            get;
        }

        public double CalculateGradeBonus()
        {
            return Grade * Rate * GRADE_BONUS_PERCENT/100;
        }


        public override void DisplayDetail()
        {
            double netIncome =0;
            double bonus = CalculateGradeBonus();
            netIncome = bonus + Grade * Rate;
            Console.WriteLine("Player Name: {0}, Grade: {1}, Rate: {2}, Bonus: {3}, Total income: {4}", _name, _grade, _rate, bonus, netIncome);
        }

        

        
    }

}
