---
title: "Standard Query Operators Overview (C#)"
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
ms.assetid: 812fa119-5f65-4139-b4fa-55dccd8dc3ac
caps.latest.revision: 7
---
# Standard Query Operators Overview (C#)
The *standard query operators* are the methods that form the LINQ pattern. Most of these methods operate on sequences, where a sequence is an object whose type implements the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*> interface. The standard query operators provide query capabilities including filtering, projection, aggregation, sorting and more.  
  
 There are two sets of LINQ standard query operators, one that operates on objects of type <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*>. The methods that make up each set are static members of the \<xref:System.Linq.Enumerable*> and \<xref:System.Linq.Queryable*> classes, respectively. They are defined as *extension methods* of the type that they operate on. This means that they can be called by using either static method syntax or instance method syntax.  
  
 In addition, several standard query operator methods operate on types other than those based on <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>1*>. The \<xref:System.Linq.Enumerable*> type defines two such methods that both operate on objects of type \<xref:System.Collections.IEnumerable*>. These methods, <xref:System.Linq.Enumerable.Cast<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1(System.Collections.IEnumerable)>, let you enable a non-parameterized, or non-generic, collection to be queried in the LINQ pattern. They do this by creating a strongly-typed collection of objects. The \<xref:System.Linq.Queryable*> class defines two similar methods, <xref:System.Linq.Queryable.Cast<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>1(System.Linq.IQueryable)>, that operate on objects of type \<xref:System.Linq.Queryable*>.  
  
 The standard query operators differ in the timing of their execution, depending on whether they return a singleton value or a sequence of values. Those methods that return a singleton value (for example, \<xref:System.Linq.Enumerable.Average*> and \<xref:System.Linq.Enumerable.Sum*>) execute immediately. Methods that return a sequence defer the query execution and return an enumerable object.  
  
 In the case of the methods that operate on in-memory collections, that is, those methods that extend <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>1*> do not implement any querying behavior, but build an expression tree that represents the query to be performed. The query processing is handled by the source \<xref:System.Linq.IQueryable`1*> object.  
  
 Calls to query methods can be chained together in one query, which enables queries to become arbitrarily complex.  
  
 The following code example demonstrates how the standard query operators can be used to obtain information about a sequence.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Query Expression Syntax  
 Some of the more frequently used standard query operators have dedicated C# and Visual Basic language keyword syntax that enables them to be called as part of a *query* *expression*. For more information about standard query operators that have dedicated keywords and their corresponding syntaxes, see [Query Expression Syntax for Standard Query Operators (C#)](../vs140/query-expression-syntax-for-standard-query-operators--csharp-.md).  
  
## Extending the Standard Query Operators  
 You can augment the set of standard query operators by creating domain-specific methods that are appropriate for your target domain or technology. You can also replace the standard query operators with your own implementations that provide additional services such as remote evaluation, query translation, and optimization. See \<xref:System.Linq.Enumerable.AsEnumerable*> for an example.  
  
## Related Sections  
 The following links take you to topics that provide additional information about the various standard query operators based on functionality.  
  
 [Sorting Data (C#)](../vs140/sorting-data--csharp-.md)  
  
 [Set Operations (C#)](../vs140/set-operations--csharp-.md)  
  
 [Filtering Data (C#)](../vs140/filtering-data--csharp-.md)  
  
 [Quantifier Operations (C#)](../vs140/quantifier-operations--csharp-.md)  
  
 [Projection Operations (C#)](../vs140/projection-operations--csharp-.md)  
  
 [Partitioning Data (C#)](../vs140/partitioning-data--csharp-.md)  
  
 [Join Operations (C#)](../vs140/join-operations--csharp-.md)  
  
 [Grouping Data (C#)](../vs140/grouping-data--csharp-.md)  
  
 [Generation Operations (C#)](../vs140/generation-operations--csharp-.md)  
  
 [Equality Operations (C#)](../vs140/equality-operations--csharp-.md)  
  
 [Element Operations (C#)](../vs140/element-operations--csharp-.md)  
  
 [Converting Data Types (C#)](../vs140/converting-data-types--csharp-.md)  
  
 [Concatenation Operations (C#)](../vs140/concatenation-operations--csharp-.md)  
  
 [Aggregation Operations (C#)](../vs140/aggregation-operations--csharp-.md)  
  
## See Also  
 \<xref:System.Linq.Enumerable*>   
 \<xref:System.Linq.Queryable*>   
 [Introduction to LINQ Queries (C#)](../vs140/introduction-to-linq-queries--csharp-.md)   
 [Query Expression Syntax for Standard Query Operators (C#)](../vs140/query-expression-syntax-for-standard-query-operators--csharp-.md)   
 [Classification of Standard Query Operators by Manner of Execution (C#)](../vs140/classification-of-standard-query-operators-by-manner-of-execution--csharp-.md)   
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)