using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SACM.Entities;

namespace SACM.Data.Map
{
    public class EspecialidadeMap : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.ToTable("especialidade");            
            builder.HasKey(x => x.Codigo);
            builder.Property(x => x.Codigo).HasColumnName("codigo").ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
        }
    }
}
