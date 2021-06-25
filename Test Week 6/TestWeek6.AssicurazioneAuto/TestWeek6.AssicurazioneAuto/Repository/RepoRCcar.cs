using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Assicurazione.Context;
using TestWeek6.Assicurazione.Models;

namespace TestWeek6.Assicurazione.Repository
{
    public class RepoRCcar : IRepositoryInsurancePolicy, IRepository<RCcar>
    {
        public RCcar Create(RCcar item)
        {
            using (var ctx = new InsurancePolicyContext())
            {
                if (item != null)
                {
                    try
                    {
                        ctx.Entry<RCcar>(item).State = EntityState.Added;
                        ctx.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return null;
                    }

                }
                return item;
            }
        }

        public ICollection<RCcar> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
