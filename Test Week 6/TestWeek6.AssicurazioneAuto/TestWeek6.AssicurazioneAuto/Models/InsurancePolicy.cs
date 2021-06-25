using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6.Assicurazione.Models
{
    public abstract class InsurancePolicy
    {
        public int Number { get; set; }
        public DateTime StipulationDate { get; set; }
        public float InsuredAmount { get; set; }
        public float MonthlyPayment { get; set; }

        //relazione 1 a molti tra Polizza e Cliente
        public String CustomerCF { get; set; }
        public Customer Customer { get; set; }




        public override string ToString()
        {
            return $"Numero: {Number} - Data di stipula: {StipulationDate} - " +
                $"Importo assicupato: {InsuredAmount} - Rata mensile: {MonthlyPayment}";
        }
    }
}
