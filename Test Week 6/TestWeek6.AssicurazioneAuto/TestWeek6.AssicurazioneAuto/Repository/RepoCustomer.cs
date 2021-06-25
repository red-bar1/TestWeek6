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
    public class RepoCustomer : IRepositoryCustomer
    {
        public Customer Create(Customer item)
        {
            using (var ctx = new InsurancePolicyContext())
            {
                if (item != null)
                {
                    try
                    {
                        ctx.Entry<Customer>(item).State = EntityState.Added;
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

        public ICollection<Customer> GetAll()
        {
            using(var ctx = new InsurancePolicyContext())
            {
                return ctx.Customers.ToList();
            }
        }

        public double MonthlyExpense()
        {
            throw new NotImplementedException();
        }
    }
}
