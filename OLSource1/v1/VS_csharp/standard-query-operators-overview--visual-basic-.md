---
title: "Standard Query Operators Overview (Visual Basic)"
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
ms.assetid: 302bd39e-2ec1-495b-94bf-37d370d6f05f
caps.latest.revision: 5
---
# Standard Query Operators Overview (Visual Basic)
The *standard query operators* are the methods that form the LINQ pattern. Most of these methods operate on sequences, where a sequence is an object whose type implements the <xref:System.Collections.Generic.IEnumerable`1*> interface or the <xref:System.Linq.IQueryable`1*> interface. The standard query operators provide query capabilities including filtering, projection, aggregation, sorting and more.  
  
 There are two sets of LINQ standard query operators, one that operates on objects of type <xref:System.Collections.Generic.IEnumerable`1*> and the other that operates on objects of type <xref:System.Linq.IQueryable`1*>. The methods that make up each set are static members of the <xref:System.Linq.Enumerable*> and <xref:System.Linq.Queryable*> classes, respectively. They are defined as *extension methods* of the type that they operate on. This means that they can be called by using either static method syntax or instance method syntax.  
  
 In addition, several standard query operator methods operate on types other than those based on <xref:System.Collections.Generic.IEnumerable`1*> or <xref:System.Linq.IQueryable`1*>. The <xref:System.Linq.Enumerable*> type defines two such methods that both operate on objects of type <xref:System.Collections.IEnumerable*>. These methods, <xref:System.Linq.Enumerable.Cast``1(System.Collections.IEnumerable)> and <xref:System.Linq.Enumerable.OfType``1(System.Collections.IEnumerable)>, let you enable a non-parameterized, or non-generic, collection to be queried in the LINQ pattern. They do this by creating a strongly-typed collection of objects. The <xref:System.Linq.Queryable*> class defines two similar methods, <xref:System.Linq.Queryable.Cast``1(System.Linq.IQueryable)> and <xref:System.Linq.Queryable.OfType``1(System.Linq.IQueryable)>, that operate on objects of type <xref:System.Linq.Queryable*>.  
  
 The standard query operators differ in the timing of their execution, depending on whether they return a singleton value or a sequence of values. Those methods that return a singleton value (for example, <xref:System.Linq.Enumerable.Average*> and <xref:System.Linq.Enumerable.Sum*>) execute immediately. Methods that return a sequence defer the query execution and return an enumerable object.  
  
 In the case of the methods that operate on in-memory collections, that is, those methods that extend <xref:System.Collections.Generic.IEnumerable`1*>, the returned enumerable object captures the arguments that were passed to the method. When that object is enumerated, the logic of the query operator is employed and the query results are returned.  
  
 In contrast, methods that extend <xref:System.Linq.IQueryable`1*> do not implement any querying behavior, but build an expression tree that represents the query to be performed. The query processing is handled by the source <xref:System.Linq.IQueryable`1*> object.  
  
 Calls to query methods can be chained together in one query, which enables queries to become arbitrarily complex.  
  
 The following code example demonstrates how the standard query operators can be used to obtain information about a sequence.  
  
```vb  
Dim sentence = "the quick brown fox jumps over the lazy dog"  
' Split the string into individual words to create a collection.  
Dim words = sentence.Split(" "c)  
  
Dim query = From word In words   
            Group word.ToUpper() By word.Length Into gr = Group   
            Order By Length _  
            Select Length, GroupedWords = gr  
  
Dim output As New System.Text.StringBuilder  
For Each obj In query  
    output.AppendLine(String.Format("Words of length {0}:", obj.Length))  
    For Each word As String In obj.GroupedWords  
        output.AppendLine(word)  
    Next  
Next  
  
'Display the output  
MsgBox(output.ToString())  
  
' This code example produces the following output:  
'  
' Words of length 3:  
' THE  
' FOX  
' THE  
' DOG  
' Words of length 4:  
' OVER  
' LAZY  
' Words of length 5:  
' QUICK  
' BROWN  
' JUMPS   
```  
  
## Query Expression Syntax  
 Some of the more frequently used standard query operators have dedicated C# and Visual Basic language keyword syntax that enables them to be called as part of a *query* *expression*. For more information about standard query operators that have dedicated keywords and their corresponding syntaxes, see [Query Expression Syntax for Standard Query Operators (Visual Basic)](../VS_csharp/query-expression-syntax-for-standard-query-operators--visual-basic-.md).  
  
## Extending the Standard Query Operators  
 You can augment the set of standard query operators by creating domain-specific methods that are appropriate for your target domain or technology. You can also replace the standard query operators with your own implementations that provide additional services such as remote evaluation, query translation, and optimization. See <xref:System.Linq.Enumerable.AsEnumerable*> for an example.  
  
## Related Sections  
 The following links take you to topics that provide additional information about the various standard query operators based on functionality.  
  
 [Sorting Data (Visual Basic)](../VS_csharp/sorting-data--visual-basic-.md)  
  
 [Set Operations (Visual Basic)](../VS_csharp/set-operations--visual-basic-.md)  
  
 [Filtering Data (Visual Basic)](../VS_csharp/filtering-data--visual-basic-.md)  
  
 [Quantifier Operations (Visual Basic)](../VS_csharp/quantifier-operations--visual-basic-.md)  
  
 [Projection Operations (Visual Basic)](../VS_csharp/projection-operations--visual-basic-.md)  
  
 [Partitioning Data (Visual Basic)](../VS_csharp/partitioning-data--visual-basic-.md)  
  
 [Join Operations (Visual Basic)](../VS_csharp/join-operations--visual-basic-.md)  
  
 [Grouping Data (Visual Basic)](../VS_csharp/grouping-data--visual-basic-.md)  
  
 [Generation Operations (Visual Basic)](../VS_csharp/generation-operations--visual-basic-.md)  
  
 [Equality Operations (Visual Basic)](../VS_csharp/equality-operations--visual-basic-.md)  
  
 [Element Operations (Visual Basic)](../VS_csharp/element-operations--visual-basic-.md)  
  
 [Converting Data Types (Visual Basic)](../VS_csharp/converting-data-types--visual-basic-.md)  
  
 [Concatenation Operations (Visual Basic)](../VS_csharp/concatenation-operations--visual-basic-.md)  
  
 [Aggregation Operations (Visual Basic)](../VS_csharp/aggregation-operations--visual-basic-.md)  
  
## See Also  
 <xref:System.Linq.Enumerable*>   
 <xref:System.Linq.Queryable*>   
 [Introduction to LINQ (Visual Basic)](../VS_csharp/introduction-to-linq--visual-basic-.md)   
 [Query Expression Syntax for Standard Query Operators (Visual Basic)](../VS_csharp/query-expression-syntax-for-standard-query-operators--visual-basic-.md)   
 [Classification of Standard Query Operators by Manner of Execution (Visual Basic)](../VS_csharp/classification-of-standard-query-operators-by-manner-of-execution--visual-basic-.md)   
 [Extension Methods (Visual Basic)](../VS_csharp/extension-methods--visual-basic-.md)