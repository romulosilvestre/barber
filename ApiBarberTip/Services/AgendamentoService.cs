using BarberTip.Contexts;//É o banco
using BarberTip.Entities;//Classes de entidades
using BarberTip.ViewModels; //camada de dados da view
using Microsoft.EntityFrameworkCore;//framework de ORM

namespace BarberTip.Services;

public class AgendamentoService{
    
    private readonly BarberTipContext _context;

    public AgendamentoService(BarberTipContext context)
    {
        _context = context;
    }
    public DetalhesAgendamentoViewModel AdicionarAgendamento(AdicionarAgendamentoViewModel dados){

        var agendamento = new Agendamento
        (
          dados.Data,
          dados.Hora,
          dados.IdCliente
        ); 
        _context.Add(agendamento);
        _context.SaveChanges();

        return null;
    }
    
}

