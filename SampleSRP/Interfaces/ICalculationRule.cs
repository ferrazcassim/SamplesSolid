using SampleSRP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSRP.Interfaces
{
    public interface ICalculationRule
    {
        decimal Calculate(Employee e);
    }
}
