using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Assicurazione.Models;

namespace TestWeek6.Assicurazione.Repository
{
    public class RepoLifeInsurance : IRepositoryInsurancePolicy, IRepository<LifeInsurance>
    {
       

        public LifeInsurance Create(LifeInsurance item)
        {
            throw new NotImplementedException();
        }


        ICollection<LifeInsurance> IRepository<LifeInsurance>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
