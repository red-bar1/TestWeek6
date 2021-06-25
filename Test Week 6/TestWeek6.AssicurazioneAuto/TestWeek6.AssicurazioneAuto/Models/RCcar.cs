using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6.Assicurazione.Models
{
    public class RCcar : InsurancePolicy
    {
        public String Plate { get; set; } 
        public int Displacement { get; set; }

        public override string ToString()
        {
            return base.ToString() +$" - Targa: {Plate} - Cilindrata: {Displacement}";
        }
    }
}
