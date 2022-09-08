using BarberTip.Entities;
namespace BarberTip.ViewModels;
public class ListarAgendamentoViewModel{
    public ListarAgendamentoViewModel(int id,DateTime data, int idCliente)
    {
        Id = id;    
        Data = data;   
        IdCliente = idCliente;
    }
    public int Id { get; set; }
    public DateTime Data { get; set; }   
    public int IdCliente { get; set; }
    public Cliente Cliente { get; set; } = null!;    
}

