public class AppDbSeeder(AppDbContext dbContext)
{
  public void Seed()
  {
    if (dbContext.Set<Preset>().Any()) return;
    SeedTables();
  }

  void SeedTables()
  {
    dbContext.Set<Preset>().AddRange([
      new Preset() {
        Name = "Pipoca",
        Food = "Pipoca (de micro-ondas)",
        Time = 180,
        Power = 7,
        Instructions = "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.",
        WarmSymbol = "popcorn"
      },
      new Preset() {
        Name = "Leite",
        Food = "Leite",
        Time = 300,
        Power = 5,
        Instructions = "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.",
        WarmSymbol = "milk"
      },
      new Preset() {
        Name = "Frango",
        Food = "Frango (qualquer corte)",
        Time = 480,
        Power = 7,
        Instructions = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",
        WarmSymbol = "chicken"
      },
      new Preset() {
        Name = "Carnes de boi",
        Food = "Carne em pedaço ou fatias",
        Time = 840,
        Power = 4,
        Instructions = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.",
        WarmSymbol = "meat"
      },
      new Preset() {
        Name = "Feijão",
        Food = "Feijão congelado",
        Time = 840,
        Power = 9,
        Instructions = "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.",
        WarmSymbol = "bean"
      },
    ]);

    dbContext.SaveChanges();
  }
}