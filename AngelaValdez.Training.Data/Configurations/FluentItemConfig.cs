using AngelaValdez.Training.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AngelaValdez.Training.Data.Configurations
{
    public class FluentItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> modelBuilder)
        {
            modelBuilder.HasKey(item => item.Id);
            modelBuilder.Property(item => item.Type).IsRequired();
            modelBuilder.Property(item => item.ContainerId).IsRequired(false);

            modelBuilder
                .HasOne(item => item.Container)
                .WithMany(item => item.Items).HasForeignKey(item => item.ContainerId).IsRequired(false);
            modelBuilder
                .HasOne(item => item.Warehouse)
                .WithMany(item => item.Items).HasForeignKey(item => item.WarehouseId);
        }
    }
}
