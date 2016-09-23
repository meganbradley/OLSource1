---
title: "Introduction to LINQ Queries (C#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - deferred execution [LINQ]
  - LINQ, queries
  - LINQ, deferred execution
  - queries [LINQ], about LINQ queries
ms.assetid: 37895c02-268c-41d5-be39-f7d936fa88a8
caps.latest.revision: 51
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Introduction to LINQ Queries (C#)
A *query* is an expression that retrieves data from a data source. Queries are usually expressed in a specialized query language. Different languages have been developed over time for the various types of data sources, for example SQL for relational databases and XQuery for XML. Therefore, developers have had to learn a new query language for each type of data source or data format that they must support. [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] simplifies this situation by offering a consistent model for working with data across various kinds of data sources and formats. In a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query, you are always working with objects. You use the same basic coding patterns to query and transform data in XML documents, SQL databases, [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)] Datasets, .NET collections, and any other format for which a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] provider is available.  
  
## Three Parts of a Query Operation  
 All [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query operations consist of three distinct actions:  
  
1.  Obtain the data source.  
  
2.  Create the query.  
  
3.  Execute the query.  
  
 The following example shows how the three parts of a query operation are expressed in source code. The example uses an integer array as a data source for convenience; however, the same concepts apply to other data sources also. This example is referred to throughout the rest of this topic.  
  
 [!code[CsLINQGettingStarted#1](../vs140/codesnippet/CSharp/introduction-to-linq-queries--csharp-_1.cs)]
  
  
 The following illustration shows the complete query operation. In [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] the execution of the query is distinct from the query itself; in other words you have not retrieved any data just by creating a query variable.  
  
 ![Complete LINQ Query Operation](../vs140/media/linq_query.png "LINQ_Query")  
  
## The Data Source  
 In the previous example, because the data source is an array, it implicitly supports the generic <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface. This fact means it can be queried with [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)]. A query is executed in a `foreach` statement, and `foreach` requires <xref:System.Collections.IEnumerable?qualifyHint=False> or <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>. Types that support <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> or a derived interface such as the generic <xref:System.Linq.IQueryable`1?qualifyHint=False> are called *queryable types*.  
  
 A queryable type requires no modification or special treatment to serve as a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data source. If the source data is not already in memory as a queryable type, the [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] provider must represent it as such. For example, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] loads an XML document into a queryable <xref:System.Xml.Linq.XElement?qualifyHint=False> type:  
  
 [!code[CsLINQGettingStarted#2](../vs140/codesnippet/CSharp/introduction-to-linq-queries--csharp-_2.cs)]
  
  
 With [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)], you first create an object-relational mapping at design time either manually or by using the [Object Relational Designer (O/R Designer)](assetId:///45e477c0-5c6b-41f9-b2d0-2808fb4f6537) in Visual Studio. You write your queries against the objects, and at run-time [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] handles the communication with the database. In the following example, `Customers` represents a specific table in the database, and the type of the query result, <xref:System.Linq.IQueryable`1?qualifyHint=False>, derives from <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>.  
  
```c#  
Northwnd db = new Northwnd(@"c:\northwnd.mdf");  
  
// Query for customers in London.  
IQueryable<Customer> custQuery =  
    from cust in db.Customers  
    where cust.City == "London"  
    select cust;  
  
```  
  
 For more information about how to create specific types of data sources, see the documentation for the various [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] providers. However, the basic rule is very simple: a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data source is any object that supports the generic <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface, or an interface that inherits from it.  
  
> [!NOTE]
>  Types such as <xref:System.Collections.ArrayList?qualifyHint=False> that support the non-generic <xref:System.Collections.IEnumerable?qualifyHint=False> interface can also be used as a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data source. For more information, see [How to: Query an ArrayList with LINQ (C#)](../vs140/how-to--query-an-arraylist-with-linq--csharp-.md).  
  
##  <a name="query"></a> The Query  
 The query specifies what information to retrieve from the data source or sources. Optionally, a query also specifies how that information should be sorted, grouped, and shaped before it is returned. A query is stored in a query variable and initialized with a query expression. To make it easier to write queries, C# has introduced new query syntax.  
  
 The query in the previous example returns all the even numbers from the integer array. The query expression contains three clauses: `from`, `where` and `select`. (If you are familiar with SQL, you will have noticed that the ordering of the clauses is reversed from the order in SQL.) The `from` clause specifies the data source, the `where` clause applies the filter, and the `select` clause specifies the type of the returned elements. These and the other query clauses are discussed in detail in the [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md) section. For now, the important point is that in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)], the query variable itself takes no action and returns no data. It just stores the information that is required to produce the results when the query is executed at some later point. For more information about how queries are constructed behind the scenes, see [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)[Standard Query Operators Overview](../vs140/standard-query-operators-overview.md).  
  
> [!NOTE]
>  Queries can also be expressed by using method syntax. For more information, see [Query Syntax and Method Syntax in LINQ (C#)](../vs140/query-syntax-and-method-syntax-in-linq--csharp-.md).  
  
## Query Execution  
  
### Deferred Execution  
 As stated previously, the query variable itself only stores the query commands. The actual execution of the query is deferred until you iterate over the query variable in a `foreach` statement. This concept is referred to as *deferred execution* and is demonstrated in the following example:  
  
 [!code[csLinqGettingStarted#4](../vs140/codesnippet/CSharp/introduction-to-linq-queries--csharp-_3.cs)]
  
  
 The `foreach` statement is also where the query results are retrieved. For example, in the previous query, the iteration variable `num` holds each value (one at a time) in the returned sequence.  
  
 Because the query variable itself never holds the query results, you can execute it as often as you like. For example, you may have a database that is being updated continually by a separate application. In your application, you could create one query that retrieves the latest data, and you could execute it repeatedly at some interval to retrieve different results every time.  
  
### Forcing Immediate Execution  
 Queries that perform aggregation functions over a range of source elements must first iterate over those elements. Examples of such queries are `Count`, `Max`, `Average`, and `First`. These execute without an explicit `foreach` statement because the query itself must use `foreach` in order to return a result. Note also that these types of queries return a single value, not an `IEnumerable` collection. The following query returns a count of the even numbers in the source array:  
  
 [!code[csLinqGettingStarted#5](../vs140/codesnippet/CSharp/introduction-to-linq-queries--csharp-_4.cs)]
  
  
 To force immediate execution of any query and cache its results, you can call the <xref:System.Linq.Enumerable.ToList``1?qualifyHint=False> or <xref:System.Linq.Enumerable.ToArray``1?qualifyHint=False> methods.  
  
 [!code[csLinqGettingStarted#6](../vs140/codesnippet/CSharp/introduction-to-linq-queries--csharp-_5.cs)]
  
  
 You can also force execution by putting the `foreach` loop immediately after the query expression. However, by calling `ToList` or `ToArray` you also cache all the data in a single collection object.  
  
## See Also  
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)   
 [Walkthrough: Writing Queries in C# (LINQ)](../vs140/walkthrough--writing-queries-in-csharp--linq-.md)   
 [Walkthrough: Writing Queries in C# (LINQ)](../vs140/walkthrough--writing-queries-in-csharp--linq-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [foreach, in (C# Reference)](../vs140/foreach--in--csharp-reference-.md)   
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)