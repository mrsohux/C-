using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Interface
{
    public interface ICalcuModel
    {
        decimal Total { get; }

        void CalculateTotal(List<decimal> numbers);
    }
}
