using System;
using System.Collections.Generic;

// Could be converted to extension methods, but implemented as static methods due to definition given in the description
public static class ListHelpers {
  public static List<B> Map<A, B>(List<A> list, Func<A, B> f) {
    if (list == null) {
      throw new ArgumentNullException(nameof(list));
    }

    if (f == null) {
      throw new ArgumentNullException(nameof(f));
    }

    var result = new List<B>();

    foreach (A item in list) {
      result.Add(f(item));
    }

    return result;
  }

  public static B Fold<A, B>(List<A> list, B initial, Func<B, A, B> folder) {
    if (list == null) {
      throw new ArgumentNullException(nameof(list));
    }

    if (initial == null) {
      throw new ArgumentNullException(nameof(initial));
    }

    if (folder == null) {
      throw new ArgumentNullException(nameof(folder));
    }
    
    foreach (A item in list) {
      initial = folder(initial, item);
    }

    return initial;
  }

  public static List<B> Map2<A, B>(List<A> list, Func<A, B> f) {
    if (list == null) {
      throw new ArgumentNullException(nameof(list));
    }

    if (f == null) {
      throw new ArgumentNullException(nameof(f));
    }

    var result = Fold(list, new List<B>(), (lst, x) => {
      lst.Add(f(x));
      return lst;
    });

    return result;
  }
}