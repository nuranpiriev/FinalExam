using Final.CL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final.DL.Configurations
{
    public class TreatmentConfiguration : IEntityTypeConfiguration<Treatment>
    {
        public void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder.HasMany(t=>t.Doctors).WithOne(d=>d.Treatment).HasForeignKey(d=>d.TreatmentId).OnDelete(DeleteBehavior.Restrict);
            builder.Property(t=>t.Title).HasMaxLength(50).IsRequired();
            builder.Property(t=>t.Description).HasMaxLength(150).IsRequired();
        }
    }

}
