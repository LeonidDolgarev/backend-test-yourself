using System.Collections.Generic;

public static class ListExtensions {
  public static string ToDelimitedString<T>(this List<T> values, string separator) {
    return string.Join(separator, values);
  }
}