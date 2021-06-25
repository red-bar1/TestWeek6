using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek6.Assicurazione.Models
{
    public class Customer
    {
        public String CF { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }

        //relazione 1 a molti con Polizza
        public ICollection<InsurancePolicy> InsurancePolicies = new List<InsurancePolicy>();

        public override string ToString()
        {
            return $"CF: {CF} - Nome: {FirstName} - Cognome: {LastName} - Indirizzo: {Address}";
        }
    }
}
