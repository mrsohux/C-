using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Interface
{
    public interface ICalcuView
    {
        event EventHandler Add;
        event EventHandler Reset;

        string iValue1 { get; set; }
        string iValue2 { get; set; }

        string iTotal { get; set; }

        void Show();
    }
}
