using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class AtualizarAgendamentoViewModel{
    public AtualizarAgendamentoViewModel(int id,DateTime data, DateTime hora, int idCliente)
    {
        Id = id;    
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
    }
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public DateTime Hora { get; set; }
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; } = null!;    
}