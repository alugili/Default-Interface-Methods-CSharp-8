namespace DefualtInterfaceMethodsDemo.SimpleExamples
{
  interface IInterfaceWithDefaultProperty
  {
    int AnyProperty
    {
      get
      {
        System.Console.WriteLine("Get AnyProperty");
        return 0;
      }
      set
      {
        System.Console.WriteLine("Set AnyProperty");
      }
    }
  }

  class InterfaceWithDefaultProperty : IInterfaceWithDefaultProperty
  {
  }
}