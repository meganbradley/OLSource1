---
title: "Basic LINQ Query Operations (C#)"
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
caps.latest.revision: 43
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Basic LINQ Query Operations (C#)
This topic gives a brief introduction to [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expressions and some of the typical kinds of operations that you perform in a query. More detailed information is in the following topics:  
  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)  
  
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)  
  
 [Walkthrough: Writing Queries in C#](../vs140/walkthrough--writing-queries-in-csharp--linq-.md)  
  
> [!NOTE]
>  If you already are familiar with a query language such as SQL or XQuery, you can skip most of this topic. Read about the "<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause" in the next section to learn about the order of clauses in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expressions.  
  
## Obtaining a Data Source  
 In a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query, the first step is to specify the data source. In C# as in most programming languages a variable must be declared before it can be used. In a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query, the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause comes first in order to introduce the data source (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) and the *range variable* (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>).  
  
 [!code[csLINQGettingStarted#23](../vs140/codesnippet/CSharp/basic-linq-query-operations--csharp-_1.cs)]  
  
 The range variable is like the iteration variable in a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> loop except that no actual iteration occurs in a query expression. When the query is executed, the range variable will serve as a reference to each successive element in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Because the compiler can infer the type of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, you do not have to specify it explicitly. Additional range variables can be introduced by a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> clause. For more information, see [let clause (C# Reference)](../vs140/let-clause--csharp-reference-.md).  
  
> [!NOTE]
>  For non-generic data sources such as \<xref:System.Collections.ArrayList*>, the range variable must be explicitly typed. For more information, see [How to: Query an ArrayList with LINQ (C#)](../vs140/how-to--query-an-arraylist-with-linq--csharp-.md) and [from clause (C# Reference)](../vs140/from-clause--csharp-reference-.md).  
  
## Filtering  
 Probably the most common query operation is to apply a filter in the form of a Boolean expression. The filter causes the query to return only those elements for which the expression is true. The result is produced by using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> clause. The filter in effect specifies which elements to exclude from the source sequence. In the following example, only those <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> who have an address in London are returned.  
  
 [!code[csLINQGettingStarted#24](../vs140/codesnippet/CSharp/basic-linq-query-operations--csharp-_2.cs)]  
  
 You can use the familiar C# logical <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operators to apply as many filter expressions as necessary in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> clause. For example, to return only customers from "London" <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> whose name is "Devon" you would write the following code:  
  
 [!code[csLINQGettingStarted#25](../vs140/codesnippet/CSharp/basic-linq-query-operations--csharp-_3.cs)]  
  
 To return customers from London or Paris, you would write the following code:  
  
 [!code[csLINQGettingStarted#26](../vs140/codesnippet/CSharp/basic-linq-query-operations--csharp-_4.cs)]  
  
 For more information, see [where clause (C# Reference)](../vs140/where-clause--csharp-reference-.md).  
  
## Ordering  
 Often it is convenient to sort the returned data. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> clause will cause the elements in the returned sequence to be sorted according to the default comparer for the type being sorted. For example, the following query can be extended to sort the results based on the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> property. Because <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is a string, the default comparer performs an alphabetical sort from A to Z.  
  
 [!code[csLINQGettingStarted#27](../vs140/codesnippet/CSharp/basic-linq-query-operations--csharp-_5.cs)]  
  
 To order the results in reverse order, from Z to A, use the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> clause.  
  
 For more information, see [orderby (C# Reference)](../vs140/orderby-clause--csharp-reference-.md).  
  
## Grouping  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> clause enables you to group your results based on a key that you specify. For example you could specify that the results should be grouped by the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> so that all customers from London or Paris are in individual groups. In this case, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is the key.  
  
 [!code[csLINQGettingStarted#28](../vs140/codesnippet/CSharp/basic-linq-query-operations--csharp-_6.cs)]  
  
 When you end a query with a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> clause, your results take the form of a list of lists. Each element in the list is an object that has a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member and a list of elements that are grouped under that key. When you iterate over a query that produces a sequence of groups, you must use a nested <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> loop. The outer loop iterates over each group, and the inner loop iterates over each group's members.  
  
 If you must refer to the results of a group operation, you can use the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> keyword to create an identifier that can be queried further. The following query returns only those groups that contain more than two customers:  
  
 [!code[csLINQGettingStarted#29](../vs140/codesnippet/CSharp/basic-linq-query-operations--csharp-_7.cs)]  
  
 For more information, see [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md).  
  
## Joining  
 Join operations create associations between sequences that are not explicitly modeled in the data sources. For example you can perform a join to find all the customers and distributors who have the same location. In [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> clause always works against object collections instead of database tables directly.  
  
 [!code[csLINQGettingStarted#36](../vs140/codesnippet/CSharp/basic-linq-query-operations--csharp-_8.cs)]  
  
 In [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] you do not have to use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as often as you do in SQL because foreign keys in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] are represented in the object model as properties that hold a collection of items. For example, a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object contains a collection of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> objects. Rather than performing a join, you access the orders by using dot notation:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For more information, see [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md).  
  
## Selecting (Projections)  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> clause produces the results of the query and specifies the "shape" or type of each returned element. For example, you can specify whether your results will consist of complete <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects, just one member, a subset of members, or some completely different result type based on a computation or new object creation. When the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> clause produces something other than a copy of the source element, the operation is called a *projection*. The use of projections to transform data is a powerful capability of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expressions. For more information, see [Data Transformations with LINQ](../vs140/data-transformations-with-linq--csharp-.md) and [select clause (C# Reference)](../vs140/select-clause--csharp-reference-.md).  
  
## See Also  
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [Walkthrough: Writing Queries in C# (LINQ)](../vs140/walkthrough--writing-queries-in-csharp--linq-.md)   
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)