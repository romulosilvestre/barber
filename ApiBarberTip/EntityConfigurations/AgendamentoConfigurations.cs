using BarberTip.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BarberTip.EntityConfigurations;
public class AgendamentoConfigurations : IEntityTypeConfiguration<Agendamento>
{
    public void Configure(EntityTypeBuilder<Agendamento> builder)
    {
        builder.ToTable("Agendamentos");
        builder.HasKey(a=>a.Id);

        builder.Property(a=>a.Data)
               .IsRequired();

        builder.Property(a=>a.Hora)
               .IsRequired(); //Realizar Manutenção

        //Depois a turma vai fazer o de Serviço-Funcionário
                       
    }
}