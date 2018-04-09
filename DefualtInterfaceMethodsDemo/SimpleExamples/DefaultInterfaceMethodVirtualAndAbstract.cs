using System;

namespace DefualtInterfaceMethodsDemo.SimpleExamples
{
  // ------------------------ Virtual and Abstract---------------------------
  interface IDefaultInterfaceMethodVirtualAndAbstract
  {
    // By default this will be virtual and the virtual keyword can be here used!
    virtual void DefaultMethod()
    {
      Console.WriteLine("I am a default method");
    }

    // By default this will be abstract and the abstract keyword can be here used
    abstract void Sum();
  }

  interface IOverrideDefaultInterfaceMethod : IDefaultInterfaceMethodVirtualAndAbstract
  {
    void IDefaultInterfaceMethodVirtualAndAbstract.DefaultMethod()
    {
      Console.WriteLine("I am an overridden default method");
    }
  }

  class DefaultMethodOverrideClass : IDefaultInterfaceMethodVirtualAndAbstract, IOverrideDefaultInterfaceMethod
  {
    public void Sum()
    {
    }
  }
}
