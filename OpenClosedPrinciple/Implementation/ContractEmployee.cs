using OpenClosedPrinciple.Abstract;
using OpenClosedPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ContractEmployee()
        { }

        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        public decimal GetMinimumsalary()
        {
            return 50;
        }
    }
}
