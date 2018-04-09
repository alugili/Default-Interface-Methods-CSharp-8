using DefualtInterfaceMethodsDemo.AdvancedExamples;
using DefualtInterfaceMethodsDemo.SimpleExamples;
using System;
using System.Collections.ObjectModel;

namespace DefualtInterfaceMethodsDemo
{
  class Program
  {
    static void Main()
    {
      // ------------------------ Basic Example---------------------------

      IDefualtInterfaceMethod defaultInterfaceMethod = new DefaultInterfaceMethod();
      defaultInterfaceMethod.DefaultMethod(); // Output: I’m a default method

      // ------------------------ Virtual and Abstract---------------------------

      //IDefaultInterfaceMethodVirtualAndAbstract defaultInterfaceMethodExample = new DefaultMethodOverrideClass();
      //defaultInterfaceMethodExample.DefaultMethod();
      //defaultInterfaceMethodExample.Sum();

      //IOverrideDefaultInterfaceMethod defaultMethodOverrideExample = new DefaultMethodOverrideClass();
      //defaultMethodOverrideExample.DefaultMethod();
      //defaultMethodOverrideExample.Sum();

      //// ------------------------ Diamond Problem---------------------------

      //A a = new D();
      //a.m(); // Outout: I am in te class D!

      //// ------------------------ -This-  Example---------------------------

      //IDefaultInterfaceWithThis defualtMethodWithThis = new DefaultMethodWithThis();
      //Console.WriteLine(defualtMethodWithThis[0]);  //  Output: 0
      //defualtMethodWithThis.CallDefaultThis(0); //  Output: SetX


      //// ------------------------ Property Example---------------------------

      //IInterfaceWithDefaultProperty interfaceWithDefaultProperty = new InterfaceWithDefaultProperty();
      //var value = interfaceWithDefaultProperty.AnyProperty; //Output : Get AnyProperty and value = 0

      //// ------------------------ Player Example---------------------------

      //AdvancedExamples.IPlayer player = new Player();
      //Console.WriteLine(player.Attack(5)); // Output 55

      //IPowerPlayer powerPlayer = new Player();
      //Console.WriteLine(powerPlayer.Attack(5));  // Output 55

      //ILimitedPlayer limitedPlayer = new Player();
      //Console.WriteLine(limitedPlayer.Attack(5));  // Output 15

      //// ------------------------  Inaccessibl Errors ---------------------------

      //// Enable this line to see the error!
      //// IUser.LoginCore();
      //IUser.Logout();
      //IUser.Login();
      //IUser.Send();

      //// ------------------------  LimitationErrors Errors ---------------------------
      //// Enable the code in the IAbstractInterface!

      //// ------------------------  Async Example ---------------------------

      //IBotPlayer botPlayer = new BotPlayer();
      //botPlayer.AutoAttack().Wait();

      //// ------------------------  Generic Example ---------------------------

      //IGenericFilters<int> genericFilter = new GenericFiltersExample();
      //var result = genericFilter.ApplyFilter(new Collection<int>() { 1, 2, 3 }, x => x > 1);

      //IDummyFilter<int> dummyFilter = new GenericFiltersExample();
      //var emptyResult = dummyFilter.ApplyFilter(new Collection<int>() { 1, 2, 3 }, x => x > 1);

    }
  }
}
