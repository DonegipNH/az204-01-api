using AZ204.Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AZ204.Demo.Infrastructure.SchemaDefinition
{
    public class GenreEntitySchemaDefinition : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres", CatalogContext.DEFAULT_SCHEMA);
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
