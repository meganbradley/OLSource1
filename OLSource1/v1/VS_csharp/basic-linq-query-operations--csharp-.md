---
title: "Basic LINQ Query Operations (C#)"
ms.custom: na
ms.date: "10/10/2016"
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
  - "orderby clause [LINQ in C#]"
  - "ordering data [LINQ in C#]"
  - "selecting data [LINQ in C#]"
  - "queries [LINQ in C#], basic operations"
  - "grouping data [LINQ in C#]"
  - "data sources [LINQ in C#]"
  - "sorting data [LINQ in C#]"
  - "projections [LINQ in C#]"
  - "filtering data [LINQ in C#]"
  - "joining data [LINQ in C#]"
  - "select clause [LINQ in C#]"
  - "LINQ [C#], basic query operations"
  - "join clause [LINQ in C#]"
  - "group clause [LINQ in C#]"
ms.assetid: a7ea3421-1cf4-4df7-832a-aa22fe6379e9
caps.latest.revision: 39
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Basic LINQ Query Operations (C#)
This topic gives a brief introduction to [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] query expressions and some of the typical kinds of operations that you perform in a query. More detailed information is in the following topics:  
  
 [LINQ Query Expressions](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)  
  
 [Standard Query Operators Overview (C#)](../VS_csharp/standard-query-operators-overview--csharp-.md)  
  
 [Walkthrough: Writing Queries in C#](../VS_csharp/walkthrough--writing-queries-in-csharp--linq-.md)  
  
> [!NOTE]
>  If you already are familiar with a query language such as SQL or XQuery, you can skip most of this topic. Read about the "`from` clause" in the next section to learn about the order of clauses in [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] query expressions.  
  
## Obtaining a Data Source  
 In a [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] query, the first step is to specify the data source. In C# as in most programming languages a variable must be declared before it can be used. In a [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] query, the `from` clause comes first in order to introduce the data source (`customers`) and the *range variable* (`cust`).  
  
 [!code[csLINQGettingStarted#23](../VS_csharp/codesnippet/CSharp/basic-linq-query-operations--csharp-_1.cs)]  
  
 The range variable is like the iteration variable in a `foreach` loop except that no actual iteration occurs in a query expression. When the query is executed, the range variable will serve as a reference to each successive element in `customers`. Because the compiler can infer the type of `cust`, you do not have to specify it explicitly. Additional range variables can be introduced by a `let` clause. For more information, see [let clause](../VS_csharp/let-clause--csharp-reference-.md).  
  
> [!NOTE]
>  For non-generic data sources such as \<xref:System.Collections.ArrayList>, the range variable must be explicitly typed. For more information, see [How to: Query an ArrayList with LINQ (C#)](../VS_csharp/how-to--query-an-arraylist-with-linq--csharp-.md) and [from clause](../VS_csharp/from-clause--csharp-reference-.md).  
  
## Filtering  
 Probably the most common query operation is to apply a filter in the form of a Boolean expression. The filter causes the query to return only those elements for which the expression is true. The result is produced by using the `where` clause. The filter in effect specifies which elements to exclude from the source sequence. In the following example, only those `customers` who have an address in London are returned.  
  
 [!code[csLINQGettingStarted#24](../VS_csharp/codesnippet/CSharp/basic-linq-query-operations--csharp-_2.cs)]  
  
 You can use the familiar C# logical `AND` and `OR` operators to apply as many filter expressions as necessary in the `where` clause. For example, to return only customers from "London" `AND` whose name is "Devon" you would write the following code:  
  
 [!code[csLINQGettingStarted#25](../VS_csharp/codesnippet/CSharp/basic-linq-query-operations--csharp-_3.cs)]  
  
 To return customers from London or Paris, you would write the following code:  
  
 [!code[csLINQGettingStarted#26](../VS_csharp/codesnippet/CSharp/basic-linq-query-operations--csharp-_4.cs)]  
  
 For more information, see [where clause](../VS_csharp/where-clause--csharp-reference-.md).  
  
## Ordering  
 Often it is convenient to sort the returned data. The `orderby` clause will cause the elements in the returned sequence to be sorted according to the default comparer for the type being sorted. For example, the following query can be extended to sort the results based on the `Name` property. Because `Name` is a string, the default comparer performs an alphabetical sort from A to Z.  
  
 [!code[csLINQGettingStarted#27](../VS_csharp/codesnippet/CSharp/basic-linq-query-operations--csharp-_5.cs)]  
  
 To order the results in reverse order, from Z to A, use the `orderby…descending` clause.  
  
 For more information, see [orderby clause](../VS_csharp/orderby-clause--csharp-reference-.md).  
  
## Grouping  
 The `group` clause enables you to group your results based on a key that you specify. For example you could specify that the results should be grouped by the `City` so that all customers from London or Paris are in individual groups. In this case, `cust.City` is the key.  
  
 [!code[csLINQGettingStarted#28](../VS_csharp/codesnippet/CSharp/basic-linq-query-operations--csharp-_6.cs)]  
  
 When you end a query with a `group` clause, your results take the form of a list of lists. Each element in the list is an object that has a `Key` member and a list of elements that are grouped under that key. When you iterate over a query that produces a sequence of groups, you must use a nested `foreach` loop. The outer loop iterates over each group, and the inner loop iterates over each group's members.  
  
 If you must refer to the results of a group operation, you can use the `into` keyword to create an identifier that can be queried further. The following query returns only those groups that contain more than two customers:  
  
 [!code[csLINQGettingStarted#29](../VS_csharp/codesnippet/CSharp/basic-linq-query-operations--csharp-_7.cs)]  
  
 For more information, see [group clause](../VS_csharp/group-clause--csharp-reference-.md).  
  
## Joining  
 Join operations create associations between sequences that are not explicitly modeled in the data sources. For example you can perform a join to find all the customers and distributors who have the same location. In [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] the `join` clause always works against object collections instead of database tables directly.  
  
 [!code[csLINQGettingStarted#36](../VS_csharp/codesnippet/CSharp/basic-linq-query-operations--csharp-_8.cs)]  
  
 In [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] you do not have to use `join` as often as you do in SQL because foreign keys in [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] are represented in the object model as properties that hold a collection of items. For example, a `Customer` object contains a collection of `Order` objects. Rather than performing a join, you access the orders by using dot notation:  
  
```  
from order in Customer.Orders...  
```  
  
 For more information, see [join clause](../VS_csharp/join-clause--csharp-reference-.md).  
  
## Selecting (Projections)  
 The `select` clause produces the results of the query and specifies the "shape" or type of each returned element. For example, you can specify whether your results will consist of complete `Customer` objects, just one member, a subset of members, or some completely different result type based on a computation or new object creation. When the `select` clause produces something other than a copy of the source element, the operation is called a *projection*. The use of projections to transform data is a powerful capability of [!INCLUDE[vbteclinq](../VS_csharp/includes/vbteclinq_md.md)] query expressions. For more information, see [Data Transformations with LINQ (C#)](../VS_csharp/data-transformations-with-linq--csharp-.md) and [select clause](../VS_csharp/select-clause--csharp-reference-.md).  
  
## See Also  
 [Getting Started with LINQ in C#](../VS_csharp/getting-started-with-linq-in-csharp.md)   
 [LINQ Query Expressions](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)   
 [Walkthrough: Writing Queries in C#](../VS_csharp/walkthrough--writing-queries-in-csharp--linq-.md)   
 [Query Keywords (LINQ)](../VS_csharp/query-keywords--csharp-reference-.md)   
 [Anonymous Types](../VS_csharp/anonymous-types--csharp-programming-guide-.md)