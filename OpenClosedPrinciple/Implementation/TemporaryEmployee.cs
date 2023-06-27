using OpenClosedPrinciple.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Implementation
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() { }
        public TemporaryEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal caculateBonus(decimal salary)
        {
            return salary * 0.5M;
        }

        public override decimal GetMinimumsalary()
        {
            return 50;
        }
    }
}
