using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWeek6.Assicurazione.Models;

namespace TestWeek6.Assicurazione.Context
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(k => k.CF);
            builder.Property("CF").IsFixedLength().HasMaxLength(16);
            builder.Property("FirstName").HasMaxLength(20).IsRequired();
            builder.Property("LastName").HasMaxLength(20).IsRequired();
            builder.Property("Address").HasMaxLength(50).IsRequired();


        }
    }
}