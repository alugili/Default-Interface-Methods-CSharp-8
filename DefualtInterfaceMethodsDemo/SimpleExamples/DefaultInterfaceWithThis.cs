namespace DefualtInterfaceMethodsDemo.SimpleExamples
{
  // --------------------------This on interface example ------------------------- 

  public interface IDefaultInterfaceWithThis
  {
    internal int this[int x]
    {
      get
      {
        System.Console.WriteLine(x);
        return x;
      }
      set
      {
        System.Console.WriteLine("SetX");
      }
    }

    void CallDefaultThis(int x)
    {
      this[0] = x;
    }
  }

  class DefaultMethodWithThis : IDefaultInterfaceWithThis
  {
  }
}