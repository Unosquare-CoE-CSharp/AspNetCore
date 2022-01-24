using AngelaValdez.Training.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AngelaValdez.Training.Data.Configurations
{
    //TODO: We can remove the Fluent word
    public class FluentWarehouseConfig : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> modelBuilder)
        {
            modelBuilder.HasKey(b => b.Id);
            modelBuilder.Property(b => b.Name).IsRequired();
        }
    }
}
