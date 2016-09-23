---
title: "Classification of Standard Query Operators by Manner of Execution (C#)"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
ms.assetid: b9435ce5-a7cf-4182-9f01-f3468a5533dc
caps.latest.revision: 7
---
# Classification of Standard Query Operators by Manner of Execution (C#)
The LINQ to Objects implementations of the standard query operator methods execute in one of two main ways: immediate or deferred. The query operators that use deferred execution can be additionally divided into two categories: streaming and non-streaming. If you know how the different query operators execute, it may help you understand the results that you get from a given query. This is especially true if the data source is changing or if you are building a query on top of another query. This topic classifies the standard query operators according to their manner of execution.  
  
## Manners of Execution  
  
### Immediate  
 Immediate execution means that the data source is read and the operation is performed at the point in the code where the query is declared. All the standard query operators that return a single, non-enumerable result execute immediately.  
  
### Deferred  
 Deferred execution means that the operation is not performed at the point in the code where the query is declared. The operation is performed only when the query variable is enumerated, for example by using a `foreach` statement. This means that the results of executing the query depend on the contents of the data source when the query is executed rather than when the query is defined. If the query variable is enumerated multiple times, the results might differ every time. Almost all the standard query operators whose return type is <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> or <xref:System.Linq.IOrderedEnumerable`1?qualifyHint=False> execute in a deferred manner.  
  
 Query operators that use deferred execution can be additionally classified as streaming or non-streaming.  
  
#### Streaming  
 Streaming operators do not have to read all the source data before they yield elements. At the time of execution, a streaming operator performs its operation on each source element as it is read and yields the element if appropriate. A streaming operator continues to read source elements until a result element can be produced. This means that more than one source element might be read to produce one result element.  
  
#### Non-Streaming  
 Non-streaming operators must read all the source data before they can yield a result element. Operations such as sorting or grouping fall into this category. At the time of execution, non-streaming query operators read all the source data, put it into a data structure, perform the operation, and yield the resulting elements.  
  
## Classification Table  
 The following table classifies each standard query operator method according to its method of execution.  
  
> [!NOTE]
>  If an operator is marked in two columns, two input sequences are involved in the operation, and each sequence is evaluated differently. In these cases, it is always the first sequence in the parameter list that is evaluated in a deferred, streaming manner.  
  
|Standard Query Operator|Return Type|Immediate Execution|Deferred Streaming Execution|Deferred Non-Streaming Execution|  
|-----------------------------|-----------------|-------------------------|----------------------------------|---------------------------------------|  
|<xref:System.Linq.Enumerable.Aggregate``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.All``1?qualifyHint=False>|<xref:System.Boolean?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.Any``1?qualifyHint=False>|<xref:System.Boolean?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.AsEnumerable``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.Average?qualifyHint=False>|Single numeric value|X|||  
|<xref:System.Linq.Enumerable.Cast``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.Concat``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.Contains``1?qualifyHint=False>|<xref:System.Boolean?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.Count``1?qualifyHint=False>|<xref:System.Int32?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.DefaultIfEmpty``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.Distinct``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.ElementAt``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.ElementAtOrDefault``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.Empty``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.Except``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X|X|  
|<xref:System.Linq.Enumerable.First``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.FirstOrDefault``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.GroupBy``2?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>|||X|  
|<xref:System.Linq.Enumerable.GroupJoin?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X|X|  
<xref:System.Linq.Enumerable.Intersect?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X|X|  
|<xref:System.Linq.Enumerable.Join?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X|X|  
|<xref:System.Linq.Enumerable.Last``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.LastOrDefault``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.LongCount``1?qualifyHint=False>|<xref:System.Int64?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.Max?qualifyHint=False>|Single numeric value, TSource, or TResult|X|||  
|<xref:System.Linq.Enumerable.Min?qualifyHint=False>|Single numeric value, TSource, or TResult|X|||  
|<xref:System.Linq.Enumerable.OfType``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.OrderBy``2?qualifyHint=False>|<xref:System.Linq.IOrderedEnumerable`1?qualifyHint=False>|||X|  
|<xref:System.Linq.Enumerable.OrderByDescending``2?qualifyHint=False>|<xref:System.Linq.IOrderedEnumerable`1?qualifyHint=False>|||X|  
|<xref:System.Linq.Enumerable.Range?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.Repeat``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.Reverse``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>|||X|  
|<xref:System.Linq.Enumerable.Select``2?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.SelectMany?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.SequenceEqual?qualifyHint=False>|<xref:System.Boolean?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.Single``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.SingleOrDefault``1?qualifyHint=False>|TSource|X|||  
|<xref:System.Linq.Enumerable.Skip``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.SkipWhile``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.Sum?qualifyHint=False>|Single numeric value|X|||  
|<xref:System.Linq.Enumerable.Take``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
<xref:System.Linq.Enumerable.TakeWhile``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.ThenBy``2?qualifyHint=False>|<xref:System.Linq.IOrderedEnumerable`1?qualifyHint=False>|||X|  
|<xref:System.Linq.Enumerable.ThenByDescending``2?qualifyHint=False>|<xref:System.Linq.IOrderedEnumerable`1?qualifyHint=False>|||X|  
|<xref:System.Linq.Enumerable.ToArray``1?qualifyHint=False>|TSource array|X|||  
|<xref:System.Linq.Enumerable.ToDictionary``2?qualifyHint=False>|<xref:System.Collections.Generic.Dictionary`2?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.ToList``1?qualifyHint=False>|<xref:System.Collections.Generic.IList`1?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.ToLookup``2?qualifyHint=False>|<xref:System.Linq.ILookup`2?qualifyHint=False>|X|||  
|<xref:System.Linq.Enumerable.Union``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
|<xref:System.Linq.Enumerable.Where``1?qualifyHint=False>|<xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>||X||  
  
## See Also  
 <xref:System.Linq.Enumerable?qualifyHint=False>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [Query Expression Syntax for Standard Query Operators (C#)](../vs140/query-expression-syntax-for-standard-query-operators--csharp-.md)   
 [LINQ to Objects (C#)](../vs140/linq-to-objects--csharp-.md)