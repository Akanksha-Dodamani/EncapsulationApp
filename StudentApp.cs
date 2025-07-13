using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationApp
{
    public class StudentApp
    {
        private int rollNo;
        private string name;
        private double cgpa;

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                    rollNo = value;
                else
                    Console.WriteLine("Invalid Roll Number. It must be positive.");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length >= 5)
                {
                    name = value;
                }
                else
                {
                    name = "";
                }
            }
        }
        public double Cgpa
        {
            get { return cgpa; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    cgpa = value;
                }
                else
                {
                    Console.WriteLine("Invalid CGPA. It must be between 1 and 10.");
                }
            }
        }
        public double GetPercentage()
        {
            return cgpa * 9.5;
        }
    }
}
