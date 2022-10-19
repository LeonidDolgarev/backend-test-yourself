using System;
using System.Collections.Generic;
using static ListHelpers;

var list = new List<int>() { 1, 2, 3 };
var emptyList = new List<int>();

var resultMapSum = Map(list, x => x + 1);
var resultMapString = Map(list, x => x.ToString());
var resultMapEmptyList = Map(emptyList, x => x);

Console.WriteLine($"Map([1,2,3], x => x + 1): {resultMapSum.ToDelimitedString(",")}");
Console.WriteLine($"Map([1,2,3], x => x.ToString()): {resultMapString.ToDelimitedString(",")}");
Console.WriteLine($"Map([], ...): {resultMapEmptyList.ToDelimitedString(",")}");

int resultFoldSum = Fold(list, 0, (sum, x) => sum + x);
string resultFoldString = Fold(list, "", (str, x) => str + x.ToString());
var resultFoldEmptyList = Fold(emptyList, list, (lst, x) => lst);

Console.WriteLine($"Fold([1,2,3], 0, (sum, x) => sum + x): {resultFoldSum}");
Console.WriteLine($"Fold([1,2,3], \"\", (str, x) => str + x.ToString()): {resultFoldString}");
Console.WriteLine($"Fold([], init, ...): {resultFoldEmptyList.ToDelimitedString(",")}");

var resultMap2Sum = Map2(list, x => x + 1);
var resultMap2String = Map2(list, x => x.ToString());
var resultMap2EmptyList = Map2(emptyList, x => x);

Console.WriteLine($"Map2([1,2,3], x => x + 1): {resultMap2Sum.ToDelimitedString(",")}");
Console.WriteLine($"Map2([1,2,3], x => x.ToString()): {resultMap2String.ToDelimitedString(",")}");
Console.WriteLine($"Map2([], ...): {resultMap2EmptyList.ToDelimitedString(",")}");