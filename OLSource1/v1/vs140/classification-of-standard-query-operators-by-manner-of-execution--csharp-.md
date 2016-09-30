---
title: "Classification of Standard Query Operators by Manner of Execution (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: b9435ce5-a7cf-4182-9f01-f3468a5533dc
caps.latest.revision: 7
---
# Classification of Standard Query Operators by Manner of Execution (C#)
The LINQ to Objects implementations of the standard query operator methods execute in one of two main ways: immediate or deferred. The query operators that use deferred execution can be additionally divided into two categories: streaming and non-streaming. If you know how the different query operators execute, it may help you understand the results that you get from a given query. This is especially true if the data source is changing or if you are building a query on top of another query. This topic classifies the standard query operators according to their manner of execution.  
  
## Manners of Execution  
  
### Immediate  
 Immediate execution means that the data source is read and the operation is performed at the point in the code where the query is declared. All the standard query operators that return a single, non-enumerable result execute immediately.  
  
### Deferred  
 Deferred execution means that the operation is not performed at the point in the code where the query is declared. The operation is performed only when the query variable is enumerated, for example by using a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement. This means that the results of executing the query depend on the contents of the data source when the query is executed rather than when the query is defined. If the query variable is enumerated multiple times, the results might differ every time. Almost all the standard query operators whose return type is <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*> execute in a deferred manner.  
  
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
|\<xref:System.Linq.Enumerable.Aggregate*>|TSource|X|||  
|\<xref:System.Linq.Enumerable.All*>|\<xref:System.Boolean*>|X|||  
|\<xref:System.Linq.Enumerable.Any*>|\<xref:System.Boolean*>|X|||  
|\<xref:System.Linq.Enumerable.AsEnumerable*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*>||X||  
|\<xref:System.Linq.Enumerable.Concat*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>1*>||X||  
|\<xref:System.Linq.Enumerable.Distinct*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*>|X|||  
|\<xref:System.Linq.Enumerable.Except*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1*>|||X|  
|\<xref:System.Linq.Enumerable.GroupJoin*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>1*>||X|X|  
|\<xref:System.Linq.Enumerable.Join*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1*>||X||  
|\<xref:System.Linq.Enumerable.OrderBy*>|<xref:System.Linq.IOrderedEnumerable<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>1*>|||X|  
|\<xref:System.Linq.Enumerable.Range*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>1*>||X||  
|\<xref:System.Linq.Enumerable.Reverse*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>1*>||X||  
|\<xref:System.Linq.Enumerable.SelectMany*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>1*>||X||  
|\<xref:System.Linq.Enumerable.SkipWhile*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>1*>||X||  
\<xref:System.Linq.Enumerable.TakeWhile*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>1*>|||X|  
|\<xref:System.Linq.Enumerable.ThenByDescending*>|<xref:System.Linq.IOrderedEnumerable<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>2*>|X|||  
|\<xref:System.Linq.Enumerable.ToList*>|<xref:System.Collections.Generic.IList<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>2*>|X|||  
|\<xref:System.Linq.Enumerable.Union*>|<xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>1*>||X||  
  
## See Also  
 \<xref:System.Linq.Enumerable*>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [Query Expression Syntax for Standard Query Operators (C#)](../vs140/query-expression-syntax-for-standard-query-operators--csharp-.md)   
 [LINQ to Objects (C#)](../vs140/linq-to-objects--csharp-.md)