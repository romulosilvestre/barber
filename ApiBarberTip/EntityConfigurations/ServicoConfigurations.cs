using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BarberTip.Entities;

namespace BarberTip.EntityConfigurations;

public class ServicoConfigurations : IEntityTypeConfiguration<Servico>
{
    public void Configure(EntityTypeBuilder<Servico> builder)
    {
        builder.ToTable("Servicos"); //definindo a tabela
        builder.HasKey(s=>s.Id); //definindo a chave primária
        //definindo a propriedade tipo - Varchar(60)
        
        builder.Property(s=>s.Nome)
            .IsRequired()
            .HasMaxLength(60);

        builder.Property(s=>s.Valor)
            .IsRequired();
        
        builder.Property(s=>s.Tempo)
            .IsRequired();

    }
}