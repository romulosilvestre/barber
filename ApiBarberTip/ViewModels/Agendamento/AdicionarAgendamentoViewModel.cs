using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class AdicionarAgendamentoViewModel{
    public AdicionarAgendamentoViewModel(DateTime data, DateTime hora, int idCliente)
    {          
        Data = data;
        Hora = hora;
        IdCliente = idCliente;
    }
   
    public DateTime Data { get; set; }
    public DateTime Hora { get; set; }
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; } = null!;    
}