using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_AustralianCricket
{
    class PlayerIncome:Player,ITax
    {
        #region Properties/Fields
        double _tax_percent = 0;
        private double _income;
        string _name;

        public double Income
        {
            get { return _income; }
            set { _income = value; }
        }
        public double Tax_Percent
        {
            get
            {
                return _tax_percent;
            }
            set
            {
                _tax_percent = value;
            }
        }

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
        #endregion

        #region constructor
        /// <summary>
        /// Constructor to supply name, income, tax percent
        /// </summary>
        /// <param name="name">The name of Player</param>
        /// <param name="income">Income for player</param>
        /// <param name="tax_percent">Tax percent for player</param>
        public PlayerIncome(string name, double income, double tax_percent) 
        {
            this._name = name;
            this._income = income;
            this._tax_percent = tax_percent;


        }
        #endregion


        public double CalculateTax()
        {
            return _income * _tax_percent/100;
        }     

        public override void DisplayDetail()
        {
            Console.WriteLine("Player {0} has Income: {1} and Tax: {2}", _name, _income, CalculateTax());
        }
    }
}
