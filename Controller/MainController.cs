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
            private MainModel tip = null;

            private MainView display = null;

            public TipCalculatorController()
            {
                display = new MainView();

                tip = new MainModel(display.Amount, display.Percent);

                display.TipAmount = tip.CalculateTip();
                display.Total = tip.CalculateTotal();

                display.ShowTipAndTotal();
            }
        }
    }
}
