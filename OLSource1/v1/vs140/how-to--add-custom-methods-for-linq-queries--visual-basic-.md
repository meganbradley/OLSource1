---
title: "How to: Add Custom Methods for LINQ Queries (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
ms.assetid: 099b2e2a-83cd-45c6-aa4d-01b398b5faaf
caps.latest.revision: 7
---
# How to: Add Custom Methods for LINQ Queries (Visual Basic)
You can extend the set of methods that you can use for LINQ queries by adding extension methods to the <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface. For example, in addition to the standard average or maximum operations, you can create a custom aggregate method to compute a single value from a sequence of values. You can also create a method that works as a custom filter or a specific data transform for a sequence of values and returns a new sequence. Examples of such methods are <xref:System.Linq.Enumerable.Distinct``1?qualifyHint=False>, <xref:System.Linq.Enumerable.Skip``1?qualifyHint=False>, and <xref:System.Linq.Enumerable.Reverse``1?qualifyHint=False>.  
  
 When you extend the <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface, you can apply your custom methods to any enumerable collection. For more information, see [Extension Methods (Visual Basic Programming Guide)](../vs140/extension-methods--visual-basic-.md).  
  
## Adding an Aggregate Method  
 An aggregate method computes a single value from a set of values. LINQ provides several aggregate methods, including <xref:System.Linq.Enumerable.Average``1?qualifyHint=False>, <xref:System.Linq.Enumerable.Min``1?qualifyHint=False>, and <xref:System.Linq.Enumerable.Max``1?qualifyHint=False>. You can create your own aggregate method by adding an extension method to the <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface.  
  
 The following code example shows how to create an extension method called `Median` to compute a median for a sequence of numbers of type `double`.  
  
```vb  
Imports System.Runtime.CompilerServices  
  
Module LINQExtension  
  
    ' Extension method for the IEnumerable(of T) interface.   
    ' The method accepts only values of the Double type.  
    <Extension()>   
    Function Median(ByVal source As IEnumerable(Of Double)) As Double  
        If source.Count = 0 Then  
            Throw New InvalidOperationException("Cannot compute median for an empty set.")  
        End If  
  
        Dim sortedSource = From number In source   
                           Order By number  
  
        Dim itemIndex = sortedSource.Count \ 2  
  
        If sortedSource.Count Mod 2 = 0 Then  
            ' Even number of items in list.  
            Return (sortedSource(itemIndex) + sortedSource(itemIndex - 1)) / 2  
        Else  
            ' Odd number of items in list.  
            Return sortedSource(itemIndex)  
        End If  
    End Function  
End Module  
```  
  
 You call this extension method for any enumerable collection in the same way you call other aggregate methods from the <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface.  
  
> [!NOTE]
>  In Visual Basic, you can either use a method call or standard query syntax for the `Aggregate` or `Group By` clause. For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md) and [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md).  
  
 The following code example shows how to use the `Median` method for an array of type `double`.  
  
```vb  
Dim numbers1() As Double = {1.9, 2, 8, 4, 5.7, 6, 7.2, 0}  
  
Dim query1 = Aggregate num In numbers1 Into Median()  
  
Console.WriteLine("Double: Median = " & query1)  
```  
  
```vb  
' This code produces the following output:  
'  
' Double: Median = 4.85  
```  
  
### Overloading an Aggregate Method to Accept Various Types  
 You can overload your aggregate method so that it accepts sequences of various types. The standard approach is to create an overload for each type. Another approach is to create an overload that will take a generic type and convert it to a specific type by using a delegate. You can also combine both approaches.  
  
#### To create an overload for each type  
 You can create a specific overload for each type that you want to support. The following code example shows an overload of the `Median` method for the `integer` type.  
  
```vb  
' Integer overload  
  
<Extension()>   
Function Median(ByVal source As IEnumerable(Of Integer)) As Double  
    Return Aggregate num In source Select CDbl(num) Into med = Median()  
End Function  
```  
  
 You can now call the `Median` overloads for both `integer` and `double` types, as shown in the following code:  
  
```vb  
Dim numbers1() As Double = {1.9, 2, 8, 4, 5.7, 6, 7.2, 0}  
  
Dim query1 = Aggregate num In numbers1 Into Median()  
  
Console.WriteLine("Double: Median = " & query1)  
```  
  
```vb  
Dim numbers2() As Integer = {1, 2, 3, 4, 5}  
  
Dim query2 = Aggregate num In numbers2 Into Median()  
  
Console.WriteLine("Integer: Median = " & query2)  
```  
  
```vb  
' This code produces the following output:  
'  
' Double: Median = 4.85  
' Integer: Median = 3  
```  
  
#### To create a generic overload  
 You can also create an overload that accepts a sequence of generic objects. This overload takes a delegate as a parameter and uses it to convert a sequence of objects of a generic type to a specific type.  
  
 The following code shows an overload of the `Median` method that takes the <xref:System.Func`2?qualifyHint=False> delegate as a parameter. This delegate takes an object of generic type T and returns an object of type `double`.  
  
```vb  
' Generic overload.  
  
<Extension()>   
Function Median(Of T)(ByVal source As IEnumerable(Of T),   
                      ByVal selector As Func(Of T, Double)) As Double  
    Return Aggregate num In source Select selector(num) Into med = Median()  
End Function  
```  
  
 You can now call the `Median` method for a sequence of objects of any type. If the type does not have its own method overload, you have to pass a delegate parameter. In Visual Basic, you can use a lambda expression for this purpose. Also, if you use the `Aggregate` or `Group By` clause instead of the method call, you can pass any value or expression that is in the scope this clause.  
  
 The following example code shows how to call the `Median` method for an array of integers and an array of strings. For strings, the median for the lengths of strings in the array is calculated. The example shows how to pass the <xref:System.Func`2?qualifyHint=False> delegate parameter to the `Median` method for each case.  
  
```vb  
Dim numbers3() As Integer = {1, 2, 3, 4, 5}  
  
' You can use num as a parameter for the Median method   
' so that the compiler will implicitly convert its value to double.  
' If there is no implicit conversion, the compiler will  
' display an error message.  
  
Dim query3 = Aggregate num In numbers3 Into Median(num)  
  
Console.WriteLine("Integer: Median = " & query3)  
  
Dim numbers4() As String = {"one", "two", "three", "four", "five"}  
  
' With the generic overload, you can also use numeric properties of objects.  
  
Dim query4 = Aggregate str In numbers4 Into Median(str.Length)  
  
Console.WriteLine("String: Median = " & query4)  
  
' This code produces the following output:  
'  
' Integer: Median = 3  
' String: Median = 4  
```  
  
## Adding a Method That Returns a Collection  
 You can extend the <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface with a custom query method that returns a sequence of values. In this case, the method must return a collection of type <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>. Such methods can be used to apply filters or data transforms to a sequence of values.  
  
 The following example shows how to create an extension method named `AlternateElements` that returns every other element in a collection, starting from the first element.  
  
```vb  
' Extension method for the IEnumerable(of T) interface.   
' The method returns every other element of a sequence.  
  
<Extension()>   
Function AlternateElements(Of T)(  
    ByVal source As IEnumerable(Of T)  
    ) As IEnumerable(Of T)  
  
    Dim list As New List(Of T)  
    Dim i = 0  
    For Each element In source  
        If (i Mod 2 = 0) Then  
            list.Add(element)  
        End If  
        i = i + 1  
    Next  
    Return list  
End Function  
```  
  
 You can call this extension method for any enumerable collection just as you would call other methods from the <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface, as shown in the following code:  
  
```vb  
Dim strings() As String = {"a", "b", "c", "d", "e"}  
  
Dim query = strings.AlternateElements()  
  
For Each element In query  
    Console.WriteLine(element)  
Next  
  
' This code produces the following output:  
'  
' a  
' c  
' e  
```  
  
## See Also  
 <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>   
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)