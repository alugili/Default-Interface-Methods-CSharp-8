namespace DefualtInterfaceMethodsDemo.AdvancedExamples
{

  // Enable the code to see the errors.
  public interface IAbstractInterface
  {
    //abstract void M1() { }
    //abstract private void M2() { }
    //abstract static void M3() { }
    //static extern void M4() { }
  }

  class TestMe : IAbstractInterface
  {
    //void IAbstractInterface.M1() { }
    //void IAbstractInterface.M2() { }
    //void IAbstractInterface.M3() { }
    //void IAbstractInterface.M4() { }
  }
}
