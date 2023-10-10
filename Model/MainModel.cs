using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilyMVC.Model
{
    internal class MainModel
    {
        private double amount;

        public double Amount
        {
            get { return amount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Must be positive!");
                }
                amount = value;
            }
        }

        private double percent;

        public double Percent
        {
            get { return percent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Must be positive!");
                }
                if (value > 1)
                {
                    percent = value / 100.0;
                }
                else
                {
                    percent = value;
                }
            }
        }


        public MainModel(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }

       
        public MainModel() : this(0, 0)
        {
            ; ;
        }

      
        public double CalculateTip()
        {
            return Amount * Percent;
        }

       
        public double CalculateTotal()
        {
            return Amount + CalculateTip();
        }
    }
}
