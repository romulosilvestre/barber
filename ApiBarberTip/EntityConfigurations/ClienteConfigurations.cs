using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;
public class ClienteConfigurations : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");

        builder.HasKey(a=>a.Id);

        builder.Property(a=>a.Nome)
               .IsRequired()
               .HasMaxLength(60);

        builder.Property(a=>a.Telefone)
               .IsRequired()
               .HasMaxLength(11);

        builder.Property(a=>a.Email)
               .IsRequired()
               .HasMaxLength(60);

        builder.Property(a=>a.DataNascimento)
               .IsRequired(); //Data não tem tamanho porque é uma estrutura (struct)
               //DateTime = Struct
        builder.HasMany(a=>a.Agendamentos)
               .WithOne(c=>c.Cliente)
               .HasForeignKey(a=>a.IdCliente);      
    
    }
}