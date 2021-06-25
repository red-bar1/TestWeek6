using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Assicurazione.Models;

namespace TestWeek6.Assicurazione.Repository
{
    public interface IRepositoryCustomer : IRepository<Customer>
    {
        public double MonthlyExpense();
    }
}
