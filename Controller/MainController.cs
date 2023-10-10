using LilyMVC.Model;
using LilyMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilyMVC.Controller
{
    internal class MainController
    {
        public class TipCalculatorController
        {
            private Tip tip = null;

            private Display display = null;

            public TipCalculatorController()
            {
                display = new Display();

                tip = new Tip(display.Amount, display.Percent);

                display.TipAmount = tip.CalculateTip();
                display.Total = tip.CalculateTotal();

                display.ShowTipAndTotal();
            }
        }
    }
}
