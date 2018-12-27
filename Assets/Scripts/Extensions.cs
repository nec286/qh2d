using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public static class Extensions {

  public static T Min<T, TCompare>(this List<T> list, Func<T, TCompare> func) where TCompare : IComparable<TCompare>  {
    T min = list[0];
    foreach(var item in list) {
      if(min == null || (func(item)).CompareTo(func(min)) < 0) {
        min = item;
      }
    }
    return min;
  }

  public static T Max<T, TCompare>(this List<T> list, Func<T, TCompare> func) where TCompare : IComparable<TCompare>  {
    T max = list[0];
    foreach(var item in list) {
      if(max == null || (func(item)).CompareTo(func(max)) > 0) {
        max = item;
      }
    }
    return max;
  }

}