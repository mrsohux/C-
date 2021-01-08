using CalculatorApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Model
{
    class CalcuModel : ICalcuModel
    {
        public decimal Total  {get; private set;}

        public void CalculateTotal(List<decimal> numbers)
        {
        Total = numbers.Sum();

        }
    }
}
