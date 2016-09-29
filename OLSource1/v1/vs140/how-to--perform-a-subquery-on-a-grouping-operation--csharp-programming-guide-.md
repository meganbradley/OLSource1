---
title: "How to: Perform a Subquery on a Grouping Operation (C# Programming Guide)"
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
  - "queries [LINQ in C#], subqueires"
  - "query expressions [LINQ in C#], subqueries"
  - "groups [C#], LINQ query expressions"
  - "subqueries [C#]"
  - "queries [LINQ in C#], grouping"
  - "grouping LINQ queries [C#]"
  - "query expressions [LINQ in C#], grouping"
  - "groups [LINQ in C#], subqueries"
ms.assetid: 7b0805cd-53b4-429d-86b6-d37fb08f2c95
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Perform a Subquery on a Grouping Operation (C# Programming Guide)
This topic shows two different ways to create a query that orders the source data into groups, and then performs a subquery over each group individually. The basic technique in each example is to group the source elements by using a *continuation* named `newGroup`, and then generating a new subquery against `newGroup`. This subquery is run against each new group that is created by the outer query. Note that in this particular example the final output is not a group, but a flat sequence of anonymous types.  
  
 For more information about how to group, see [group clause (C# Reference)](../vs140/group-clause--csharp-reference-.md).  
  
 For more information about continuations, see [into (C# Reference)](../vs140/into--csharp-reference-.md). The following example uses an in-memory data structure as the data source, but the same principles apply for any kind of [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] data source.  
  
## Example  
 [!code[csProgGuideLINQ#23](../vs140/codesnippet/CSharp/how-to--perform-a-subquery-on-a-grouping-operation--csharp-programming-guide-_1.cs)]  
  
## Compiling the Code  
 This example contains references to objects that are defined in the sample application in [How to: Query a Collections of Objects](../vs140/how-to--query-a-collection-of-objects--csharp-programming-guide-.md). To compile and run this method, paste it into the `StudentClass` class in that application and add a call to it from the `Main` method.  
  
 When you adapt this method to your own application, remember that LINQ requires version 3.5 of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], and the project must contain a reference to System.Core.dll and a using directive for System.Linq. LINQ to SQL, LINQ to XML and LINQ to DataSet types require additional usings and references. For more information, see [How To: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project_deleted.md).  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)