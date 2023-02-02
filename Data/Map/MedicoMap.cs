using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SACM.Entities;

namespace SACM.Data.Map
{
    public class MedicoMap : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("medico");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.CodigoEspecialidade).HasColumnName("codigo_especialidade");
            builder.Property(x => x.Crm).HasColumnName("crm").HasMaxLength(15).IsRequired();
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.InstituicaoFormatura).HasColumnName("instituicao_formatura").IsRequired();
            builder.Property(x => x.AnoFormatura).HasColumnName("ano_formatura").HasMaxLength(4).IsRequired();
            builder.Property(x => x.AnoNascimento).HasColumnName("ano_nascimento").HasMaxLength(4).IsRequired();
            builder.Property(x => x.MesNascimento).HasColumnName("mes_nascimento").HasMaxLength(2).IsRequired();
            builder.Property(x => x.DiaNascimento).HasColumnName("dia_nascimento").HasMaxLength(2).IsRequired();
        }
    }
}
