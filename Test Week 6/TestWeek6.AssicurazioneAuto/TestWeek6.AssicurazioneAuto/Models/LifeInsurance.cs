using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6.Assicurazione.Models
{
    public class LifeInsurance : InsurancePolicy
    {
        public int CustomerAge { get; set; }


        public override string ToString()
        {
            return base.ToString()+$" - Anni dell'assicurato: {CustomerAge}";
        }
    }
}
