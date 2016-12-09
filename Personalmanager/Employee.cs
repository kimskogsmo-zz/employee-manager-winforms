using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Personalmanager
{
    public class Employee
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string fullname;

        public override string ToString()
        {
            fullname = fname + " " + lname;
            return fullname;
        }
        
        public string email { get; set; }
        public bool onleave { get; set; }
        public int role { get; set; }
        public decimal salary { get; set; }
        public int store { get; set; }
        public DateTime date { get; set; }        
    }
}