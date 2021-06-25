using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Assicurazione.Models;

namespace TestWeek6.Assicurazione.Repository
{
    public class RepoTheftInsurance : IRepositoryInsurancePolicy, IRepository<TheftInsurance>
    {
        public TheftInsurance Create(TheftInsurance item)
        {
            throw new NotImplementedException();
        }

        public ICollection<TheftInsurance> GetAll()
        {
            throw new NotImplementedException();
        }
    }


}
