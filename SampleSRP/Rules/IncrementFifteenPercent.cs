using SampleSRP.Entities;
using SampleSRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSRP.Rules
{
    public class IncrementFifteenPercent : ICalculationRule
    {
        public decimal Calculate(Employee e)
        {
            return (0.15M * e.GetBaseSalary()) + e.GetBaseSalary();
        }
    }
}
