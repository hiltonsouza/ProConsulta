using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProConsulta.Models;

namespace ProConsulta.Data.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Medicos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Documento)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(11)");

            builder.Property(x => x.Crm)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(8)");

            builder.Property(x => x.Celular)
                .IsRequired(true)
                .HasColumnType("NVARCHAR(11)");

            builder.Property(x => x.EspecialidadeId)
                .IsRequired(true);

            builder.HasIndex(x => x.Documento)
            .IsUnique();

            builder.HasMany<Agendamento>(a => a.Agendamentos)
                .WithOne(m => m.Medico)
                .HasForeignKey(a => a.MedicoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
