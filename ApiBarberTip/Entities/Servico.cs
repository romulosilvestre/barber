using BarberTip.Contexts;

public class Servico{
    public Servico(string nome, decimal valor, DateTime tempo)
    {
        Nome = nome;
        Valor = valor;
        Tempo = tempo;
    }

    public int Id { get; set; }
   public string Nome { get; set; }
   
   public decimal Valor { get; set; }

   public DateTime Tempo { get; set; }
   


}