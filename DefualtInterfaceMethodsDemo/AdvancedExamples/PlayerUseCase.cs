using System;

namespace DefualtInterfaceMethodsDemo.AdvancedExamples
{
  // ------------------------- Player: Real Use Case -------------------------- 

  public interface IPlayer
  {
    int Attack(int amount);
  }

  public interface IPowerPlayer : IPlayer
  {
    int IPlayer.Attack(int amount)
    {
      return amount + 50;
    }
  }

  public interface ILimitedPlayer : IPlayer
  {
    new int Attack(int amount)
    {
      return amount + 10;
    }
  }

  public class Player : IPowerPlayer, ILimitedPlayer
  {
  }
}