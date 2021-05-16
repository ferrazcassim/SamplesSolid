using SampleSRP.Rules;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SampleSRP.Entities
{
    public class Manager : Employee
    {
        public override decimal GetBaseSalary()
        {
            return 5.000M;
        }

        protected override void SetCalculatedSalary()
        {
            base.CalculatedSalary = new IncrementTenPercent().Calculate(this);
        }
    }
}
