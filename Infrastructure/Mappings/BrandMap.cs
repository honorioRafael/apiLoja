using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("marcas");
            builder.Property(x => x.Name).HasColumnName("nome");
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.CreationDate).HasColumnName("data_criacao");
            builder.Property(x => x.ChangeDate).HasColumnName("data_alteracao");
        }
    }
}
