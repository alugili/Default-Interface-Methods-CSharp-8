namespace DefualtInterfaceMethodsDemo.SimpleExamples
{
  // ------------------------Diamond inheritance and classes---------------------------
  interface A
  {
    void m();
  }

  interface B : A
  {
    void A.m() { System.Console.WriteLine("interface B"); }
  }

  interface C : A
  {
    void A.m() { System.Console.WriteLine("interface C"); }
  }

  class D : B, C
  {
    // Now the compiler will use the most specific override  which is defined in the class ‘D’
    // Todo: !!!Remove this method to see the Diamond problem.!!!
    void A.m()
    {
      System.Console.WriteLine("I am in te class D!");
    }
  }
}