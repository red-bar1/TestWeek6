using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWeek6.Assicurazione.Models;

namespace TestWeek6.Assicurazione.Context
{
    public class InsurancePolicyConfiguration : IEntityTypeConfiguration<InsurancePolicy>
    {
        public void Configure(EntityTypeBuilder<InsurancePolicy> builder)
        {
            builder.ToTable("InsurancePolicy");
            builder.HasKey(k => k.Number);
            builder.Property("Number").HasColumnType("int");
            builder.Property("StipulationDate").HasColumnType("datetime2").IsRequired();
            builder.Property("InsuredAmount").HasColumnType("float").IsRequired();
            builder.Property("MonthlyPayment").HasColumnType("float").IsRequired();

            builder.HasOne(i => i.Customer).WithMany(c => c.InsurancePolicies).HasForeignKey(f => f.CustomerCF);

            //per gestire la gerarchia con discriminante intero
            builder.HasDiscriminator<int>("InsuranceType")
                    .HasValue<RCcar>(1) //("RC Car")
                    .HasValue<LifeInsurance>(2) //("Life Insurance")
                    .HasValue<TheftInsurance>(3); //("Theft Insurance");
        }
    }
}