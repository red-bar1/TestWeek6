using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek6.Assicurazione.Models;

namespace TestWeek6.Assicurazione.Context
{
    public class InsurancePolicyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = True; 
                                    Initial Catalog = InsurancePolicy; Server = .\SQLEXPRESS");
        }

        public InsurancePolicyContext() : base() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Customer>(new CustomerConfiguration());
            builder.ApplyConfiguration <InsurancePolicy>(new InsurancePolicyConfiguration());
        }

    }
}
