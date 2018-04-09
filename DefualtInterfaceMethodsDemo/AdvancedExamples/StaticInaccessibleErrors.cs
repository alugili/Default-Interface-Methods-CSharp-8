
namespace DefualtInterfaceMethodsDemo.AdvancedExamples
{
  // (17,12): error CS0122: 'I1.M1()' is inaccessible due to its protection level

  interface IUser
  {
    private static void LoginCore() { }
    internal static void Logout() { }
    public static void Login() { }
    static void Send() { }
  }

  class User : IUser
  {
  }
}