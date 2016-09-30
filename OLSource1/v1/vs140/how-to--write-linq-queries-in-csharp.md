---
title: "How to: Write LINQ Queries in C#"
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
  - "query expressions [LINQ in C#], writing queries"
  - "queries [LINQ in C#], writing"
  - "writing LINQ queries"
ms.assetid: 45e47fcc-cfa1-4b72-b161-d038ae87bd23
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write LINQ Queries in C#
This topic shows the three ways in which you can write a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query in C#:  
  
1.  Use query syntax.  
  
2.  Use method syntax.  
  
3.  Use a combination of query syntax and method syntax.  
  
 The following examples demonstrate some simple [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] queries by using each approach listed previously. In general, the rule is to use (1) whenever possible, and use (2) and (3) whenever necessary.  
  
> [!NOTE]
>  These queries operate on simple in-memory collections; however, the basic syntax is identical to that used in [!INCLUDE[vbtecdlinq](../vs140/includes/vbtecdlinq_md.md)] and [!INCLUDE[sqltecxlinq](../vs140/includes/sqltecxlinq_md.md)].  
  
## Example  
  
## Query Syntax  
 The recommended way to write most queries is to use *query syntax* to create *query expressions*. The following example shows three query expressions. The first query expression demonstrates how to filter or restrict results by applying conditions with a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause. It returns all elements in the source sequence whose values are greater than 7 or less than 3. The second expression demonstrates how to order the returned results. The third expression demonstrates how to group results according to a key. This query returns two groups based on the first letter of the word.  
  
 [!code[csProgGuideLINQ#5](../vs140/codesnippet/CSharp/how-to--write-linq-queries-in-csharp_1.cs)]  
  
 Note that the type of the queries is <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>var<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>var query = from num in numbers...<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1*> collection. The method itself has to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in order to compute its value.  
  
 Each of the previous queries can be written by using implicit typing with [var](../vs140/var--csharp-reference-.md), as shown in the following example:  
  
 [!code[csProgGuideLINQ#8](../vs140/codesnippet/CSharp/how-to--write-linq-queries-in-csharp_4.cs)]  
  
## Example  
  
## Mixed Query and Method Syntax  
 This example shows how to use method syntax on the results of a query clause. Just enclose the query expression in parentheses, and then apply the dot operator and call the method. In the following example, query #7 returns a count of the numbers whose value is between 3 and 7. In general, however, it is better to use a second variable to store the result of the method call. In this manner, the query is less likely to be confused with the results of the query.  
  
 [!code[csProgGuideLINQ#9](../vs140/codesnippet/CSharp/how-to--write-linq-queries-in-csharp_5.cs)]  
  
 Because Query #7 returns a single value and not a collection, the query executes immediately.  
  
 The previous query can be written by using implicit typing with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 It can be written in method syntax as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 It can be written by using explicit typing, as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Language-Integrated Query](../vs140/linq--language-integrated-query-.md)   
 [Walkthrough: Writing Queries in C# (LINQ)](../vs140/walkthrough--writing-queries-in-csharp--linq-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [where clause (C# Reference)](../vs140/where-clause--csharp-reference-.md)