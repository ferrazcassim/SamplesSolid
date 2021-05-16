using SampleSRP.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSRP.Entities
{
    public class Developer : Employee
    {    
        public override decimal GetBaseSalary()
        {
            return 3.000M;
        }

        protected override void SetCalculatedSalary()
        {
            base.CalculatedSalary = new IncrementFifteenPercent().Calculate(this);           
        }
    }
}
