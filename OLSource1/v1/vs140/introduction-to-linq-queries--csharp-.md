---
title: "Introduction to LINQ Queries (C#)"
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
  - "deferred execution [LINQ]"
  - "LINQ, queries"
  - "LINQ, deferred execution"
  - "queries [LINQ], about LINQ queries"
ms.assetid: 37895c02-268c-41d5-be39-f7d936fa88a8
caps.latest.revision: 51
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
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
 In the previous example, because the data source is an array, it implicitly supports the generic <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>1*>. Types that support <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> are called *queryable types*.  
  
 A queryable type requires no modification or special treatment to serve as a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data source. If the source data is not already in memory as a queryable type, the [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] provider must represent it as such. For example, [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)] loads an XML document into a queryable \<xref:System.Xml.Linq.XElement*> type:  
  
 [!code[CsLINQGettingStarted#2](../vs140/codesnippet/CSharp/introduction-to-linq-queries--csharp-_2.cs)]  
  
 With [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)], you first create an object-relational mapping at design time either manually or by using the [Object Relational Designer (O/R Designer)](assetId:///45e477c0-5c6b-41f9-b2d0-2808fb4f6537) in Visual Studio. You write your queries against the objects, and at run-time [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] handles the communication with the database. In the following example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> represents a specific table in the database, and the type of the query result, <xref:System.Linq.IQueryable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>1*>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For more information about how to create specific types of data sources, see the documentation for the various [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] providers. However, the basic rule is very simple: a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data source is any object that supports the generic <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>where<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>select<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>where<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>select<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>num<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Count<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>Max<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Average<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>First<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>IEnumerable<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>ToList<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>ToArray` you also cache all the data in a single collection object.  
  
## See Also  
 [Getting Started with LINQ in C#](../vs140/getting-started-with-linq-in-csharp.md)   
 [Walkthrough: Writing Queries in C# (LINQ)](../vs140/walkthrough--writing-queries-in-csharp--linq-.md)   
 [Walkthrough: Writing Queries in C# (LINQ)](../vs140/walkthrough--writing-queries-in-csharp--linq-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [foreach, in (C# Reference)](../vs140/foreach--in--csharp-reference-.md)   
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)