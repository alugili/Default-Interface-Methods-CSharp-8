using System;

namespace DefualtInterfaceMethodsDemo.SimpleExamples
{
  // ------------------------Default Interface Methods---------------------------
  interface IDefualtInterfaceMethod
  {
    public void DefaultMethod()
    {
      Console.WriteLine("I’m a default method");
    }
  }

  class DefaultInterfaceMethod : IDefualtInterfaceMethod
  {
  }
}