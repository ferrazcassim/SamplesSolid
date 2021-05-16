using SampleSRP.Entities;
using SampleSRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSRP.Rules
{
    public class IncrementTenPercent : ICalculationRule
    {
        public decimal Calculate(Employee e)
        {
            return (0.1M * e.GetBaseSalary()) + e.GetBaseSalary();
        }
    }
}
