using SampleSRP.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSRP.Entities
{
    public class DBA : Employee
    {
        public override decimal GetBaseSalary()
        {
            return 2.000M;
        }

        protected override void SetCalculatedSalary()
        {
            base.CalculatedSalary = new IncrementTenPercent().Calculate(this);
        }
    }
}
