using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6.Assicurazione.Models
{
    public class TheftInsurance : InsurancePolicy
    {
        public int PercentageRefunded { get; set; }

        public override string ToString()
        {
            return base.ToString()+ $" - Percentuale rimborsata: {PercentageRefunded}";
        }
    }
}
