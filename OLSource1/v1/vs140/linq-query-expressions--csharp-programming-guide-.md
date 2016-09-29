---
title: "LINQ Query Expressions (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "expressions [C#], LINQ query expressions"
  - "queries [LINQ in C#], query expressions"
  - "LINQ [C#], query expressions"
  - "query expressions [LINQ in C#]"
  - "C# Language, LINQ query expressions"
ms.assetid: 40638f19-fb46-4d26-a2d9-a383b48f5ed4
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LINQ Query Expressions (C# Programming Guide)
[!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)] is the name for a set of technologies based on the integration of query capabilities directly into the C# language (also in Visual Basic and potentially any other .NET language). With [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)], a query is now a first-class language construct, just like classes, methods, events and so on.  
  
 For a developer who writes queries, the most visible "language-integrated" part of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] is the query expression. Query expressions are written in a declarative *query syntax* introduced in C# 3.0. By using query syntax, you can perform even complex filtering, ordering, and grouping operations on data sources with a minimum of code. You use the same basic query expression patterns to query and transform data in SQL databases, [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)] Datasets, XML documents and streams, and .NET collections.  
  
 The following example shows the complete query operation. The complete operation includes creating a data source, defining the query expression, and executing the query in a `foreach` statement.  
  
 [!code[csProgGuideLINQ#11](../vs140/codesnippet/CSharp/linq-query-expressions--csharp-programming-guide-_1.cs)]  
  
 For more information about the basics of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] in C#, see [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md).  
  
## Query Expression Overview  
  
-   Query expressions can be used to query and to transform data from any [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)]-enabled data source. For example, a single query can retrieve data from a SQL database, and produce an XML stream as output.  
  
-   Query expressions are easy to master because they use many familiar C# language constructs. For more information, see [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md).  
  
-   The variables in a query expression are all strongly typed, although in many cases you do not have to provide the type explicitly because the compiler can infer it. For more information, see [Type Relationships in Query Operations (LINQ)](../vs140/type-relationships-in-linq-query-operations--csharp-.md).  
  
-   A query is not executed until you iterate over the query variable in a `foreach` statement. For more information, see [The Three Parts of a LINQ Query](../vs140/introduction-to-linq-queries--csharp-.md).  
  
-   At compile time, query expressions are converted to Standard Query Operator method calls according to the rules set forth in the C# specification. Any query that can be expressed by using query syntax can also be expressed by using method syntax. However, in most cases query syntax is more readable and concise. For more information, see [C# Language Specification](../vs140/csharp-language-specification.md) and [Standard Query Operators Overview](../vs140/standard-query-operators-overview.md).  
  
-   As a rule when you write [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries, we recommend that you use query syntax whenever possible and method syntax whenever necessary. There is no semantic or performance difference between the two different forms. Query expressions are often more readable than equivalent expressions written in method syntax.  
  
-   Some query operations, such as <xref:System.Linq.Enumerable.Count*> or <xref:System.Linq.Enumerable.Max*>, have no equivalent query expression clause and must therefore be expressed as a method call. Method syntax can be combined with query syntax in various ways. For more information, see [Query Syntax versus Method Syntax (LINQ)](../vs140/query-syntax-and-method-syntax-in-linq--csharp-.md).  
  
-   Query expressions can be compiled to expression trees or to delegates, depending on the type that the query is applied to. <xref:System.Collections.Generic.IEnumerable`1*> queries are compiled to delegates. <xref:System.Linq.IQueryable*> and <xref:System.Linq.IQueryable`1*> queries are compiled to expression trees. For more information, see [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md).  
  
 The following table lists topics that provide additional information about queries and code examples for common tasks.  
  
|Topic|Description|  
|-----------|-----------------|  
|[Query Expression Basics](../vs140/query-expression-basics--csharp-programming-guide-.md)|Introduces fundamental query concepts and provides examples of C# query syntax.|  
|[How to: Write LINQ Queries in C#](../vs140/how-to--write-linq-queries-in-csharp.md)|Provides examples of several basic types of query expressions.|  
|[How to: Handle Exceptions in Query Expressions](../vs140/how-to--handle-exceptions-in-query-expressions--csharp-programming-guide-.md)|How and when to move potential exception-throwing code outside a query expression.|  
|[How to: Merge Data from Different Source Types](../vs140/how-to--populate-object-collections-from-multiple-sources--linq-.md)|How to use the `select` statement to merge data from different sources into a new type.|  
|[How to: Group Results in Various Ways (LINQ)](../vs140/how-to--group-query-results--csharp-programming-guide-.md)|Shows different ways to use the `group` clause.|  
|[How to: Group a Group (LINQ)](../vs140/how-to--create-a-nested-group--csharp-programming-guide-.md)|Shows how to create nested groups.|  
|[How to: Perform a Sub-query on a Grouping Operation (C# Programming Guide)](../vs140/how-to--perform-a-subquery-on-a-grouping-operation--csharp-programming-guide-.md)|Shows how to use a sub-expression in a query as a data source for a new query.|  
|[How to: Group Results By Contiguous Keys (C# Programming Guide)](../vs140/how-to--group-results-by-contiguous-keys--csharp-programming-guide-.md)|Shows how to implement a thread-safe standard query operator that can perform grouping operations on streaming data sources.|  
|[How to: Dynamically Specify Predicate Filters at Runtime](../vs140/how-to--dynamically-specify-predicate-filters-at-runtime--csharp-programming-guide-.md)|Shows how to supply an arbitrary number of values to use in equality comparisons in a `where` clause.|  
|[How to: Store the Results of a Query in Memory](../vs140/how-to--store-the-results-of-a-query-in-memory--csharp-programming-guide-.md)|Illustrates how to materialize and store query results without necessarily using a `foreach` loop.|  
|[How to: Return a Query From a Method (LINQ)](../vs140/how-to--return-a-query-from-a-method--csharp-programming-guide-.md)|Shows how to return query variables from methods, and how to pass them to methods as input parameters.|  
|[How to: Perform Custom Join Operations](../vs140/how-to--perform-custom-join-operations--csharp-programming-guide-.md)|Shows how to perform join operations based on any kind of predicate function.|  
|[How to: Join By Using Composite Keys (C# Programming Guide)](../vs140/how-to--join-by-using-composite-keys--csharp-programming-guide-.md)|Shows how to join two sources based on more than one matching key.|  
|[How to: Order the Results of a Join Clause (C# Programming Guide)](../vs140/how-to--order-the-results-of-a-join-clause--csharp-programming-guide-.md)|Shows how to order a sequence that is produced by a join operation.|  
|[How to: Perform an Inner Join (C# Programming Guide)](../vs140/how-to--perform-inner-joins--csharp-programming-guide-.md)|Shows how to perform an inner join in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)].|  
|[How to: Perform a Grouped Join (C# Programming Guide)](../vs140/how-to--perform-grouped-joins--csharp-programming-guide-.md)|Shows how to produce a grouped join in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)].|  
|[How to: Perform a Left Outer Join (C# Programming Guide)](../vs140/how-to--perform-left-outer-joins--csharp-programming-guide-.md)|Shows how to produce a left outer join in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)].|  
|[How to: Handle Null Values in Query Expressions (C# Programming Guide)](../vs140/how-to--handle-null-values-in-query-expressions--csharp-programming-guide-.md)|Shows how to handle null values in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries.|  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Language-Integrated Query (LINQ)](../vs140/linq--language-integrated-query-.md)   
 [Walkthrough: Writing Queries in C# (LINQ)](../vs140/walkthrough--writing-queries-in-csharp--linq-.md)   
 [Basic Query Concepts](../vs140/basic-linq-query-operations--csharp-.md)   
 [Query Syntax vs. Method Syntax](../vs140/query-syntax-and-method-syntax-in-linq--csharp-.md)   
 [Standard Query Operators Overview](../vs140/standard-query-operators-overview.md)   
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [How Linq to Objects Queries Work](http://go.microsoft.com/fwlink/?LinkId=112389)   
 [Reading and Writing Queries](http://go.microsoft.com/fwlink/?LinkId=112391)   
 [What is a collection?](http://go.microsoft.com/fwlink/?LinkId=112394)   
 [Link to Everything: A List of LINQ Providers](http://go.microsoft.com/fwlink/?LinkId=112411)