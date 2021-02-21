using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidanceExamtest
{
    class MyClass
    {
        public MyClass()
        {

        }
        private int studentId;
        private String fanme;
        private String lanme;
        private double salary;

        public int StudentId { get => studentId; set => studentId = value; }
        public string Fanme { get => fanme; set => fanme = value; }
        public string Lanme { get => lanme; set => lanme = value; }
        public double Salary { get => salary; set => salary = value; }

       public string GetFullName()
        {
            string fullName = "";
            fullName = this.Fanme + this.Lanme; 
            return fullName;
      }
    }
}
