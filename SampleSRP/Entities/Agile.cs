using SampleSRP.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSRP.Entities
{
    public class Agile : Employee
    {
        public override decimal GetBaseSalary()
        {
            return 1.000M;
        }

        protected override void SetCalculatedSalary()
        {
            base.CalculatedSalary = new IncrementTenPercent().Calculate(this);
        }
    }
}
