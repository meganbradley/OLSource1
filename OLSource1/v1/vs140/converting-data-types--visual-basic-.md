---
title: "Converting Data Types (Visual Basic)"
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
ms.assetid: 9b0cf1ab-de48-4c6e-9f00-05b40fade46e
caps.latest.revision: 7
---
# Converting Data Types (Visual Basic)
Conversion methods change the type of input objects.  
  
 Conversion operations in LINQ queries are useful in a variety of applications. Following are some examples:  
  
-   The <xref:System.Linq.Enumerable.AsEnumerable``1?qualifyHint=True> method can be used to hide a type's custom implementation of a standard query operator.  
  
-   The <xref:System.Linq.Enumerable.OfType``1?qualifyHint=True> method can be used to enable non-parameterized collections for LINQ querying.  
  
-   The <xref:System.Linq.Enumerable.ToArray``1?qualifyHint=True>, <xref:System.Linq.Enumerable.ToDictionary``2?qualifyHint=True>, <xref:System.Linq.Enumerable.ToList``1?qualifyHint=True>, and <xref:System.Linq.Enumerable.ToLookup``2?qualifyHint=True> methods can be used to force immediate query execution instead of deferring it until the query is enumerated.  
  
## Methods  
 The following table lists the standard query operator methods that perform data-type conversions.  
  
 The conversion methods in this table whose names start with "As" change the static type of the source collection but do not enumerate it. The methods whose names start with "To" enumerate the source collection and put the items into the corresponding collection type.  
  
|Method Name|Description|Visual Basic Query Expression Syntax|More Information|  
|-----------------|-----------------|------------------------------------------|----------------------|  
|AsEnumerable|Returns the input typed as <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>.|Not applicable.|<xref:System.Linq.Enumerable.AsEnumerable``1?qualifyHint=True>|  
|AsQueryable|Converts a (generic) <xref:System.Collections.IEnumerable?qualifyHint=False> to a (generic) <xref:System.Linq.IQueryable?qualifyHint=False>.|Not applicable.|<xref:System.Linq.Queryable.AsQueryable?qualifyHint=True>|  
|Cast|Casts the elements of a collection to a specified type.|`From … As …`|<xref:System.Linq.Enumerable.Cast``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Cast``1?qualifyHint=True>|  
|OfType|Filters values, depending on their ability to be cast to a specified type.|Not applicable.|<xref:System.Linq.Enumerable.OfType``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.OfType``1?qualifyHint=True>|  
|ToArray|Converts a collection to an array. This method forces query execution.|Not applicable.|<xref:System.Linq.Enumerable.ToArray``1?qualifyHint=True>|  
|ToDictionary|Puts elements into a <xref:System.Collections.Generic.Dictionary`2?qualifyHint=False> based on a key selector function. This method forces query execution.|Not applicable.|<xref:System.Linq.Enumerable.ToDictionary``2?qualifyHint=True>|  
|ToList|Converts a collection to a <xref:System.Collections.Generic.List`1?qualifyHint=False>. This method forces query execution.|Not applicable.|<xref:System.Linq.Enumerable.ToList``1?qualifyHint=True>|  
|ToLookup|Puts elements into a <xref:System.Linq.Lookup`2?qualifyHint=False> (a one-to-many dictionary) based on a key selector function. This method forces query execution.|Not applicable.|<xref:System.Linq.Enumerable.ToLookup``2?qualifyHint=True>|  
  
## Query Expression Syntax Example  
 The following code example uses the `From As` clause to cast a type to a subtype before accessing a member that is available only on the subtype.  
  
```vb  
Class Plant  
    Public Property Name As String  
End Class  
  
Class CarnivorousPlant  
    Inherits Plant  
    Public Property TrapType As String  
End Class  
  
Sub Cast()  
  
    Dim plants() As Plant = {   
        New CarnivorousPlant With {.Name = "Venus Fly Trap", .TrapType = "Snap Trap"},   
        New CarnivorousPlant With {.Name = "Pitcher Plant", .TrapType = "Pitfall Trap"},   
        New CarnivorousPlant With {.Name = "Sundew", .TrapType = "Flypaper Trap"},   
        New CarnivorousPlant With {.Name = "Waterwheel Plant", .TrapType = "Snap Trap"}}  
  
    Dim query = From plant As CarnivorousPlant In plants   
                Where plant.TrapType = "Snap Trap"   
                Select plant  
  
    Dim sb As New System.Text.StringBuilder()  
    For Each plant In query  
        sb.AppendLine(plant.Name)  
    Next  
  
    ' Display the results.  
    MsgBox(sb.ToString())  
  
    ' This code produces the following output:  
  
    ' Venus Fly Trap  
    ' Waterwheel Plant  
  
End Sub  
```  
  
## See Also  
 <xref:System.Linq?qualifyHint=False>   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md)   
 [How to: Query an ArrayList with LINQ (Visual Basic)](../vs140/how-to--query-an-arraylist-with-linq--visual-basic-.md)