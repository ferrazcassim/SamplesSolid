using System;
using System.Collections.Generic;
using System.Text;

namespace SampleSRP.Entities
{
    public abstract class Employee
    {
        public Employee()
        {
            SetCalculatedSalary();
        }
        public abstract decimal GetBaseSalary();
        protected abstract void SetCalculatedSalary();

        public decimal CalculatedSalary { get; protected set; }
    }
}
