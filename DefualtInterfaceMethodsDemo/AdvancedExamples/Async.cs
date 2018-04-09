using System.Threading.Tasks;

namespace DefualtInterfaceMethodsDemo.AdvancedExamples
{
  // ------------------------ Async Example ----------------------------------

  interface IBotPlayer : IPlayer
  {
    async Task AutoAttack()
    {
      await Task.Factory.StartNew(() => System.Console.WriteLine("IPlayer.AutoAttack"));
    }
  }

  class BotPlayer : IBotPlayer
  {
    public int Attack(int amount)
    {
      throw new System.NotImplementedException();
    }
  }
}