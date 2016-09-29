---
title: "Query Expression Syntax for Standard Query Operators (Visual Basic)"
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
ms.assetid: eb978d86-d3b5-497b-95ce-a054bea8f510
caps.latest.revision: 5
---
# Query Expression Syntax for Standard Query Operators (Visual Basic)
Some of the more frequently used standard query operators have dedicated Visual Basic language keyword syntax that enables them to be called as part of a *query expression*. A query expression is a different, more readable form of expressing a query than its *method-based*  equivalent. Query expression clauses are translated into calls to the query methods at compile time.  
  
## Query Expression Syntax Table  
 The following table lists the standard query operators that have equivalent query expression clauses.  
  
|Method|Visual Basic Query Expression Syntax|  
|------------|------------------------------------------|  
|<xref:System.Linq.Enumerable.All*>|`Aggregate … In … Into All(…)`<br /><br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Any*>|`Aggregate … In … Into Any()`<br /><br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Average*>|`Aggregate … In … Into Average()`<br /><br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Cast*>|`From … As …`<br /><br /> (For more information, see [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Count*>|`Aggregate … In … Into Count()`<br /><br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Distinct``1(System.Collections.Generic.IEnumerable{``0})>|`Distinct`<br /><br /> (For more information, see [Distinct Clause (Visual Basic)](../vs140/distinct-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.GroupBy*>|`Group … By … Into …`<br /><br /> (For more information, see [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.GroupJoin``4(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``1},System.Func{``0,``2},System.Func{``1,``2},System.Func{``0,System.Collections.Generic.IEnumerable{``1},``3})>|`Group Join … In … On …`<br /><br /> (For more information, see [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Join``4(System.Collections.Generic.IEnumerable{``0},System.Collections.Generic.IEnumerable{``1},System.Func{``0,``2},System.Func{``1,``2},System.Func{``0,``1,``3})>|`From x In …, y In … Where x.a = b.a`<br /><br /> -or-<br /><br /> `Join … [As …]In … On …`<br /><br /> (For more information, see [Join Clause (Visual Basic)](../vs140/join-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.LongCount*>|`Aggregate … In … Into LongCount()`<br /><br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Max*>|`Aggregate … In … Into Max()`<br /><br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Min*>|`Aggregate … In … Into Min()`<br /><br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.OrderBy``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})>|`Order By`<br /><br /> (For more information, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.OrderByDescending``2(System.Collections.Generic.IEnumerable{``0},System.Func{``0,``1})>|`Order By … Descending`<br /><br /> (For more information, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Select*>|`Select`<br /><br /> (For more information, see [Select Clause (Visual Basic)](../vs140/select-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.SelectMany*>|Multiple `From` clauses<br /><br /> (For more information, see [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Skip*>|`Skip`<br /><br /> (For more information, see [Skip Clause (Visual Basic)](../vs140/skip-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.SkipWhile*>|`Skip While`<br /><br /> (For more information, see [Skip While Clause (Visual Basic)](../vs140/skip-while-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Sum*>|`Aggregate … In … Into Sum()`<br /><br /> (For more information, see [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Take*>|`Take`<br /><br /> (For more information, see [Take Clause (Visual Basic)](../vs140/take-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.TakeWhile*>|`Take While`<br /><br /> (For more information, see [Take While Clause (Visual Basic)](../vs140/take-while-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.ThenBy``2(System.Linq.IOrderedEnumerable{``0},System.Func{``0,``1})>|`Order By …, …`<br /><br /> (For more information, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.ThenByDescending``2(System.Linq.IOrderedEnumerable{``0},System.Func{``0,``1})>|`Order By …, … Descending`<br /><br /> (For more information, see [Order By Clause (Visual Basic)](../vs140/order-by-clause--visual-basic-.md).)|  
|<xref:System.Linq.Enumerable.Where*>|`Where`<br /><br /> (For more information, see [Where Clause (Visual Basic)](../vs140/where-clause--visual-basic-.md).)|  
  
## See Also  
 <xref:System.Linq.Enumerable*>   
 <xref:System.Linq.Queryable*>   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Classification of Standard Query Operators by Manner of Execution (Visual Basic)](../vs140/classification-of-standard-query-operators-by-manner-of-execution--visual-basic-.md)