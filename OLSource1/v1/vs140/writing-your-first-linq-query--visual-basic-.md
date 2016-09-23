---
title: "Writing Your First LINQ Query (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - queries [LINQ in Visual Basic], writing
  - LINQ queries [Visual Basic]
  - LINQ [Visual Basic], writing queries
ms.assetid: 4affb732-3e9b-4479-aa31-1f9bd8183cbe
caps.latest.revision: 60
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Writing Your First LINQ Query (Visual Basic)
A *query* is an expression that retrieves data from a data source. Queries are expressed in a dedicated query language. Over time, different languages have been developed for different types of data sources, for example, SQL for relational databases and XQuery for XML. This makes it necessary for the application developer to learn a new query language for each type of data source or data format that is supported.  
  
 [!INCLUDE[vbteclinqext](../vs140/includes/vbteclinqext_md.md)] simplifies the situation by offering a consistent model for working with data across various kinds of data sources and formats. In a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query, you are always working with objects. You use the same basic coding patterns to query and transform data in XML documents, SQL databases, ADO.NET datasets and entities, .NET Framework collections, and any other source or format for which a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] provider is available. This document describes the three phases of the creation and use of basic [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries.  
  
## Three Stages of a Query Operation  
 [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query operations consist of three actions:  
  
1.  Obtain the data source or sources.  
  
2.  Create the query.  
  
3.  Execute the query.  
  
 In [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)], the execution of a query is distinct from the creation of the query. You do not retrieve any data just by creating a query. This point is discussed in more detail later in this topic.  
  
 The following example illustrates the three parts of a query operation. The example uses an array of integers as a convenient data source for demonstration purposes. However, the same concepts also apply to other data sources.  
  
> [!NOTE]
>  On the [Compile Page, Project Designer (Visual Basic)](../vs140/compile-page--project-designer--visual-basic-.md), ensure that **Option infer** is set to **On**.  
  
 [!code[VbLINQFirstQuery#1](../vs140/codesnippet/VisualBasic/writing-your-first-linq-query--visual-basic-_1.vb)]
  
  
 Output:  
  
 `0 2 4 6`  
  
## The Data Source  
 Because the data source in the previous example is an array, it implicitly supports the generic <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface. It is this fact that enables you to use an array as a data source for a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query. Types that support <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> or a derived interface such as the generic <xref:System.Linq.IQueryable`1?qualifyHint=False> are called *queryable types*.  
  
 As an implicitly queryable type, the array requires no modification or special treatment to serve as a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data source. The same is true for any collection type that supports <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>, including the generic <xref:System.Collections.Generic.List`1?qualifyHint=False>, <xref:System.Collections.Generic.Dictionary`2?qualifyHint=False>, and other classes in the .NET Framework class library.  
  
 If the source data does not already implement <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>, a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] provider is needed to implement the functionality of the *standard query operators* for that data source. For example, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] handles the work of loading an XML document into a queryable <xref:System.Xml.Linq.XElement?qualifyHint=False> type, as shown in the following example. For more information about standard query operators, see [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md).  
  
 [!code[VbLINQFirstQuery#2](../vs140/codesnippet/VisualBasic/writing-your-first-linq-query--visual-basic-_2.vb)]
  
  
 With [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)], you first create an object-relational mapping at design time, either manually or by using the [Object Relational Designer (O/R Designer)](assetId:///45e477c0-5c6b-41f9-b2d0-2808fb4f6537) in Visual Studio. You write your queries against the objects, and at run-time [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] handles the communication with the database. In the following example, `customers` represents a specific table in the database, and <xref:System.Data.Linq.Table`1?qualifyHint=False> supports generic <xref:System.Linq.IQueryable`1?qualifyHint=False>.  
  
```vb#  
' Create a data source from a SQL table.  
Dim db As New DataContext("C:\Northwind\Northwnd.mdf")  
Dim customers As Table(Of Customer) = db.GetTable(Of Customer)  
```  
  
 For more information about how to create specific types of data sources, see the documentation for the various [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] providers. (For a list of these providers, see [Language-Integrated Query (LINQ)](../vs140/linq--language-integrated-query-.md).) The basic rule is simple: a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data source is any object that supports the generic <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False> interface, or an interface that inherits from it.  
  
> [!NOTE]
>  Types such as <xref:System.Collections.ArrayList?qualifyHint=False> that support the non-generic <xref:System.Collections.IEnumerable?qualifyHint=False> interface can also be used as [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data sources. For an example that uses an <xref:System.Collections.ArrayList?qualifyHint=False>, see [How to: Query an ArrayList with LINQ (Visual Basic)](../vs140/how-to--query-an-arraylist-with-linq--visual-basic-.md).  
  
## The Query  
 In the query, you specify what information you want to retrieve from the data source or sources. You also have the option of specifying how that information should be sorted, grouped, or structured before it is returned. To enable query creation, Visual Basic has incorporated new query syntax into the language.  
  
 When it is executed, the query in the following example returns all the even numbers from an integer array, `numbers`.  
  
 [!code[VbLINQFirstQuery#1](../vs140/codesnippet/VisualBasic/writing-your-first-linq-query--visual-basic-_1.vb)]
  
  
 The query expression contains three clauses: `From`, `Where`, and `Select`. The specific function and purpose of each query expression clause is discussed in [Basic Query Operators (Visual Basic)](../vs140/basic-query-operations--visual-basic-.md). For more information, see [Queries (Visual Basic)](../vs140/queries--visual-basic-.md). Note that in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)], a query definition often is stored in a variable and executed later. The query variable, such as `evensQuery` in the previous example, must be a queryable type. The type of `evensQuery` is `IEnumerable(Of Integer)`, assigned by the compiler using local type inference.  
  
 It is important to remember that the query variable itself takes no action and returns no data. It only stores the query definition. In the previous example, it is the `For Each` loop that executes the query.  
  
## Query Execution  
 Query execution is separate from query creation. Query creation defines the query, but execution is triggered by a different mechanism. A query can be executed as soon as it is defined (*immediate execution*), or the definition can be stored and the query can be executed later (*deferred execution*).  
  
### Deferred Execution  
 A typical [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query resembles the one in the previous example, in which `evensQuery` is defined. It creates the query but does not execute it immediately. Instead, the query definition is stored in the query variable `evensQuery`. You execute the query later, typically by using a `For Each` loop, which returns a sequence of values, or by applying a standard query operator, such as `Count` or `Max`. This process is referred to as *deferred execution*.  
  
 [!code[VbLINQFirstQuery#7](../vs140/codesnippet/VisualBasic/writing-your-first-linq-query--visual-basic-_3.vb)]
  
  
 For a sequence of values, you access the retrieved data by using the iteration variable in the `For Each` loop (`number` in the previous example). Because the query variable, `evensQuery`, holds the query definition rather than the query results, you can execute a query as often as you want by using the query variable more than one time. For example, you might have a database in your application that is being updated continually by a separate application. After you have created a query that retrieves data from that database, you can use a `For Each` loop to execute the query repeatedly, retrieving the most recent data every time.  
  
 The following example demonstrates how deferred execution works. After `evensQuery2` is defined and executed with a `For Each` loop, as in the previous examples, some elements in the data source `numbers` are changed. Then a second `For Each` loop runs `evensQuery2` again. The results are different the second time, because the `For Each` loop executes the query again, using the new values in `numbers`.  
  
 [!code[VbLINQFirstQuery#3](../vs140/codesnippet/VisualBasic/writing-your-first-linq-query--visual-basic-_4.vb)]
  
  
 Output:  
  
 `Evens in original array:`  
  
 `0  2  4  6`  
  
 `Evens in changed array:`  
  
 `0  10  2  22  8`  
  
### Immediate Execution  
 In deferred execution of queries, the query definition is stored in a query variable for later execution. In immediate execution, the query is executed at the time of its definition. Execution is triggered when you apply a method that requires access to individual elements of the query result. Immediate execution often is forced by using one of the standard query operators that return single values. Examples are `Count`, `Max`, `Average`, and `First`. These standard query operators execute the query as soon as they are applied in order to calculate and return a singleton result. For more information about standard query operators that return single values, see [Aggregation Operations in LINQ](../vs140/aggregation-operations.md), [Element Operations in LINQ](../vs140/element-operations.md), and [Quantifier Operations in LINQ](../vs140/quantifier-operations.md).  
  
 The following query returns a count of the even numbers in an array of integers. The query definition is not saved, and `numEvens` is a simple `Integer`.  
  
 [!code[VbLINQFirstQuery#4](../vs140/codesnippet/VisualBasic/writing-your-first-linq-query--visual-basic-_5.vb)]
  
  
 You can achieve the same result by using the `Aggregate` method.  
  
 [!code[VbLINQFirstQuery#5](../vs140/codesnippet/VisualBasic/writing-your-first-linq-query--visual-basic-_6.vb)]
  
  
 You can also force execution of a query by calling the `ToList` or `ToArray` method on a query (immediate) or query variable (deferred), as shown in the following code.  
  
 [!code[VbLINQFirstQuery#6](../vs140/codesnippet/VisualBasic/writing-your-first-linq-query--visual-basic-_7.vb)]
  
  
 In the previous examples, `evensQuery3` is a query variable, but `evensList` is a list and `evensArray` is an array.  
  
 Using `ToList` or `ToArray` to force immediate execution is especially useful in scenarios in which you want to execute the query immediately and cache the results in a single collection object. For more information about these methods, see [Converting Data Types](../vs140/converting-data-types.md).  
  
 You can also cause a query to be executed by using an `IEnumerable` method such as the <xref:Microsoft.VisualBasic.Collection.System#Collections#IEnumerable#GetEnumerator?qualifyHint=False> method.  
  
## See Also  
 [Getting Started with LINQ in Visual Basic](../vs140/getting-started-with-linq-in-visual-basic.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [Queries](../vs140/queries--visual-basic-.md)