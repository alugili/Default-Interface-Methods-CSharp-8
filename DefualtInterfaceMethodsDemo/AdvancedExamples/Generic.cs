using System;
using System.Collections.Generic;

namespace DefualtInterfaceMethodsDemo.AdvancedExamples
{

  // ------------------------- Generic Example-------------------------- 

  interface IGenericFilters<T>
  {
    IEnumerable<T> ApplyFilter(IEnumerable<T> collection, Func<T, bool> predicate)
    {
      foreach (var item in collection)
      {
        if (predicate(item))
        {
          yield return item;
        }
      }
    }
  }

  interface IDummyFilter<T> : IGenericFilters<T>
  {
    IEnumerable<T> IGenericFilters<T>.ApplyFilter(IEnumerable<T> collection, Func<T, bool> predicate)
    {
      return default;
    }
  }

  public class GenericFiltersExample: IGenericFilters<int>, IDummyFilter<int>
  {
  }
}