//Para a classe usar o Framework
using Microsoft.EntityFrameworkCore;
using BarberTip.Entities;
using BarberTip.EntityConfigurations;
//Entity Framework = ORM
//Mapeamento Objeto-Relacional

//Classe é um conjunto de objetos.
//Herança - Pai e um Filho
//O Filho herda do Pai

namespace BarberTip.Contexts;
public class BarberTipContext:DbContext{

    //Definimos uma propriedade que irá configuração
    //Aplica as configuração = ConnectionString
    //IConfiguration - Injeção de Dependência.
    //Animal a = new Animal(); - não injetado
    //Animal _a; - injetado.
     private readonly IConfiguration _configuration;
    public BarberTipContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    //Definir uma classe que será mapeada
    //Lambda
    public DbSet<Cliente> Clientes=>Set<Cliente>();
    public DbSet<Agendamento> Agendamentos=>Set<Agendamento>();


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

          optionsBuilder.UseSqlServer(_configuration.GetConnectionString("BarberTip"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
       
       modelBuilder.ApplyConfiguration(new ClienteConfigurations());
       modelBuilder.ApplyConfiguration(new AgendamentoConfigurations());

    }
     


}