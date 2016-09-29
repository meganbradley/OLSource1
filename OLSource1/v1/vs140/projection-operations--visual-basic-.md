---
title: "Projection Operations (Visual Basic)"
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
ms.assetid: b8d38e6d-21cf-4619-8dbb-94476f4badc7
caps.latest.revision: 7
---
# Projection Operations (Visual Basic)
Projection refers to the operation of transforming an object into a new form that often consists only of those properties that will be subsequently used. By using projection, you can construct a new type that is built from each object. You can project a property and perform a mathematical function on it. You can also project the original object without changing it.  
  
 The standard query operator methods that perform projection are listed in the following section.  
  
## Methods  
  
|Method Name|Description|Visual Basic Query Expression Syntax|More Information|  
|-----------------|-----------------|------------------------------------------|----------------------|  
|Select|Projects values that are based on a transform function.|`Select`|<xref:System.Linq.Enumerable.Select*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.Select*?displayProperty=fullName>|  
|SelectMany|Projects sequences of values that are based on a transform function and then flattens them into one sequence.|Use multiple `From` clauses|<xref:System.Linq.Enumerable.SelectMany*?displayProperty=fullName><br /><br /> <xref:System.Linq.Queryable.SelectMany*?displayProperty=fullName>|  
  
## Query Expression Syntax Examples  
  
### Select  
 The following example uses the `Select` clause to project the first letter from each string in a list of strings.  
  
```vb  
Dim words = New List(Of String) From {"an", "apple", "a", "day"}  
  
Dim query = From word In words   
            Select word.Substring(0, 1)  
  
Dim sb As New System.Text.StringBuilder()  
For Each letter As String In query  
    sb.AppendLine(letter)  
Next  
  
' Display the output.  
MsgBox(sb.ToString())  
  
' This code produces the following output:  
  
' a  
' a  
' a  
' d  
```  
  
### SelectMany  
 The following example uses multiple `From` clauses to project each word from each string in a list of strings.  
  
```vb  
Dim phrases = New List(Of String) From {"an apple a day", "the quick brown fox"}  
  
Dim query = From phrase In phrases   
            From word In phrase.Split(" "c)   
            Select word  
  
Dim sb As New System.Text.StringBuilder()  
For Each str As String In query  
    sb.AppendLine(str)  
Next  
  
' Display the output.  
MsgBox(sb.ToString())  
  
' This code produces the following output:  
  
' an  
' apple  
' a  
' day  
' the  
' quick  
' brown  
' fox  
```  
  
## Select versus SelectMany  
 The work of both `Select()` and `SelectMany()` is to produce a result value (or values) from source values. `Select()` produces one result value for every source value. The overall result is therefore a collection that has the same number of elements as the source collection. In contrast, `SelectMany()` produces a single overall result that contains concatenated sub-collections from each source value. The transform function that is passed as an argument to `SelectMany()` must return an enumerable sequence of values for each source value. These enumerable sequences are then concatenated by `SelectMany()` to create one large sequence.  
  
 The following two illustrations show the conceptual difference between the actions of these two methods. In each case, assume that the selector (transform) function selects the array of flowers from each source value.  
  
 This illustration depicts how `Select()` returns a collection that has the same number of elements as the source collection.  
  
 ![Conceptual illustration of the action of Select&#40;&#41;](../vs140/media/selectaction.png "SelectAction")  
  
 This illustration depicts how `SelectMany()` concatenates the intermediate sequence of arrays into one final result value that contains each value from each intermediate array.  
  
 ![Graphic showing the action of SelectMany&#40;&#41;.](../vs140/media/selectmany.png "SelectMany")  
  
### Code Example  
 The following example compares the behavior of `Select()` and `SelectMany()`. The code creates a "bouquet" of flowers by taking the first two items from each list of flower names in the source collection. In this example, the "single value" that the transform function <xref:System.Linq.Enumerable.Select``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})> uses is itself a collection of values. This requires the extra `For Each` loop in order to enumerate each string in each sub-sequence.  
  
```vb  
Class Bouquet  
    Public Flowers As List(Of String)  
End Class  
  
Sub SelectVsSelectMany()  
    Dim bouquets = New List(Of Bouquet) From {   
        New Bouquet With {.Flowers = New List(Of String)(New String() {"sunflower", "daisy", "daffodil", "larkspur"})},   
        New Bouquet With {.Flowers = New List(Of String)(New String() {"tulip", "rose", "orchid"})},   
        New Bouquet With {.Flowers = New List(Of String)(New String() {"gladiolis", "lily", "snapdragon", "aster", "protea"})},   
        New Bouquet With {.Flowers = New List(Of String)(New String() {"larkspur", "lilac", "iris", "dahlia"})}}  
  
    Dim output As New System.Text.StringBuilder  
  
    ' Select()  
    Dim query1 = bouquets.Select(Function(b) b.Flowers)  
  
    output.AppendLine("Using Select():")  
    For Each flowerList In query1  
        For Each str As String In flowerList  
            output.AppendLine(str)  
        Next  
    Next  
  
    ' SelectMany()  
    Dim query2 = bouquets.SelectMany(Function(b) b.Flowers)  
  
    output.AppendLine(vbCrLf & "Using SelectMany():")  
    For Each str As String In query2  
        output.AppendLine(str)  
    Next  
  
    ' Display the output  
    MsgBox(output.ToString())  
  
    ' This code produces the following output:  
    '  
    ' Using Select():  
    ' sunflower  
    ' daisy  
    ' daffodil  
    ' larkspur  
    ' tulip  
    ' rose  
    ' orchid  
    ' gladiolis  
    ' lily  
    ' snapdragon  
    ' aster  
    ' protea  
    ' larkspur  
    ' lilac  
    ' iris  
    ' dahlia  
  
    ' Using SelectMany()  
    ' sunflower  
    ' daisy  
    ' daffodil  
    ' larkspur  
    ' tulip  
    ' rose  
    ' orchid  
    ' gladiolis  
    ' lily  
    ' snapdragon  
    ' aster  
    ' protea  
    ' larkspur  
    ' lilac  
    ' iris  
    ' dahlia  
  
End Sub  
```  
  
## See Also  
 <xref:System.Linq*>   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Select Clause (Visual Basic)](../vs140/select-clause--visual-basic-.md)   
 [How To: Combine Data with LINQ by Using Joins (Visual Basic)](../vs140/how-to--combine-data-with-linq-by-using-joins--visual-basic-.md)   
 [How to: Populate Object Collections from Multiple Sources (LINQ) (Visual Basic)](../vs140/how-to--populate-object-collections-from-multiple-sources--linq---visual-basic-.md)   
 [How To: Return a LINQ Query Result as a Specific Type (Visual Basic)](../vs140/how-to--return-a-linq-query-result-as-a-specific-type--visual-basic-.md)   
 [How to: Split a File Into Many Files by Using Groups (LINQ) (Visual Basic)](../vs140/how-to--split-a-file-into-many-files-by-using-groups--linq---visual-basic-.md)