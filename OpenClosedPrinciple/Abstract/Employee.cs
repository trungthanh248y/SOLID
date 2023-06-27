using OpenClosedPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Abstract
{
    public abstract class Employee:IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract decimal caculateBonus(decimal saraly);

        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}", Id, Name);
        }

        public abstract decimal GetMinimumsalary();
    }

}
