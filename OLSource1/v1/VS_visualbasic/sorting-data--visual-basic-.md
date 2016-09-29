---
title: "Sorting Data (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 6f81065c-0c89-4bf3-a6d8-442273f8810e
caps.latest.revision: 3
---
# Sorting Data (Visual Basic)
A sorting operation orders the elements of a sequence based on one or more attributes. The first sort criterion performs a primary sort on the elements. By specifying a second sort criterion, you can sort the elements within each primary sort group.  
  
 The following illustration shows the results of an alphabetical sort operation on a sequence of characters.  
  
 ![LINQ Sorting Operation](../VS_csharp/media/linq_ordering.png "LINQ_Ordering")  
  
 The standard query operator methods that sort data are listed in the following section.  
  
## Methods  
  
|Method Name|Description|Visual Basic Query Expression Syntax|More Information|  
|-----------------|-----------------|------------------------------------------|----------------------|  
|OrderBy|Sorts values in ascending order.|`Order By`|<xref:System.Linq.Enumerable.OrderBy*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.OrderBy*?displayProperty=fullName>|  
|OrderByDescending|Sorts values in descending order.|`Order By … Descending`|<xref:System.Linq.Enumerable.OrderByDescending*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.OrderByDescending*?displayProperty=fullName>|  
|ThenBy|Performs a secondary sort in ascending order.|`Order By …, …`|<xref:System.Linq.Enumerable.ThenBy*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.ThenBy*?displayProperty=fullName>|  
|ThenByDescending|Performs a secondary sort in descending order.|`Order By …, … Descending`|<xref:System.Linq.Enumerable.ThenByDescending*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.ThenByDescending*?displayProperty=fullName>|  
|Reverse|Reverses the order of the elements in a collection.|Not applicable.|<xref:System.Linq.Enumerable.Reverse*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.Reverse*?displayProperty=fullName>|  
  
## Query Expression Syntax Examples  
  
### Primary Sort Examples  
  
#### Primary Ascending Sort  
 The following example demonstrates how to use the `Order By` clause in a LINQ query to sort the strings in an array by string length, in ascending order.  
  
```vb  
Dim words = {"the", "quick", "brown", "fox", "jumps"}  
  
Dim sortQuery = From word In words   
                Order By word.Length   
                Select word  
  
Dim sb As New System.Text.StringBuilder()  
For Each str As String In sortQuery  
    sb.AppendLine(str)  
Next  
  
' Display the results.  
MsgBox(sb.ToString())  
  
' This code produces the following output:  
  
' the  
' fox  
' quick  
' brown  
' jumps  
```  
  
#### Primary Descending Sort  
 The next example demonstrates how to use the `Order By Descending` clause in a LINQ query to sort the strings by their first letter, in descending order.  
  
```vb  
Dim words = {"the", "quick", "brown", "fox", "jumps"}  
  
Dim sortQuery = From word In words   
                Order By word.Substring(0, 1) Descending   
                Select word  
  
Dim sb As New System.Text.StringBuilder()  
For Each str As String In sortQuery  
    sb.AppendLine(str)  
Next  
  
' Display the results.  
MsgBox(sb.ToString())  
  
' This code produces the following output:  
  
' the  
' quick  
' jumps  
' fox  
' brown  
```  
  
### Secondary Sort Examples  
  
#### Secondary Ascending Sort  
 The following example demonstrates how to use the `Order By` clause in a LINQ query to perform a primary and secondary sort of the strings in an array. The strings are sorted primarily by length and secondarily by the first letter of the string, both in ascending order.  
  
```vb  
Dim words = {"the", "quick", "brown", "fox", "jumps"}  
  
Dim sortQuery = From word In words   
                Order By word.Length, word.Substring(0, 1)   
                Select word  
  
Dim sb As New System.Text.StringBuilder()  
For Each str As String In sortQuery  
    sb.AppendLine(str)  
Next  
  
' Display the results.  
MsgBox(sb.ToString())  
  
' This code produces the following output:  
  
' fox  
' the  
' brown  
' jumps  
' quick  
```  
  
#### Secondary Descending Sort  
 The next example demonstrates how to use the `Order By Descending` clause in a LINQ query to perform a primary sort, in ascending order, and a secondary sort, in descending order. The strings are sorted primarily by length and secondarily by the first letter of the string.  
  
```vb  
Dim words = {"the", "quick", "brown", "fox", "jumps"}  
  
Dim sortQuery = From word In words   
                Order By word.Length, word.Substring(0, 1) Descending   
                Select word  
  
Dim sb As New System.Text.StringBuilder()  
For Each str As String In sortQuery  
    sb.AppendLine(str)  
Next  
  
' Display the results.  
MsgBox(sb.ToString())  
  
' This code produces the following output:  
  
' fox  
' the  
' quick  
' jumps  
' brown  
```  
  
## See Also  
 <xref:System.Linq*>   
 [Standard Query Operators Overview (Visual Basic)](../VS_csharp/standard-query-operators-overview--visual-basic-.md)   
 [Order By Clause (Visual Basic)](../VS_csharp/order-by-clause--visual-basic-.md)   
 [How to: Sort Query Results by Using LINQ (Visual Basic)](../VS_csharp/how-to--sort-query-results-by-using-linq--visual-basic-.md)   
 [How to: Sort or Filter Text Data by Any Word or Field (LINQ) (Visual Basic)](../VS_csharp/how-to--sort-or-filter-text-data-by-any-word-or-field--linq---visual-basic-.md)