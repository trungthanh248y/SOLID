using OpenClosedPrinciple.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Implementation
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public override decimal caculateBonus(decimal saraly)
        {
            return saraly * 0.8M;
        }

        public override decimal GetMinimumsalary()
        {
            return 150;
        }
    }
}
