---
title: "group clause (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "group"
  - "group_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "group keyword [C#]"
  - "group clause [C#]"
ms.assetid: c817242e-b12c-4baa-a57e-73ee138f34d1
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# group clause (C# Reference)
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause returns a sequence of <xref:System.Linq.IGrouping<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>Key<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>2*> object. The compiler infers the type of the key.  
  
 You can end a query expression with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause, as shown in the following example:  
  
 [!code[cscsrefQueryKeywords#10](../vs140/codesnippet/CSharp/group-clause--csharp-reference-_1.cs)]  
  
 If you want to perform additional query operations on each group, you can specify a temporary identifier by using the [into](../vs140/into--csharp-reference-.md) contextual keyword. When you use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, you must continue with the query, and eventually end it with either a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement or another <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause, as shown in the following excerpt:  
  
 [!code[cscsrefQueryKeywords#11](../vs140/codesnippet/CSharp/group-clause--csharp-reference-_2.cs)]  
  
 More complete examples of the use of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with and without <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are provided in the Example section of this topic.  
  
## Enumerating the Results of a Group Query  
 Because the <xref:System.Linq.IGrouping<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>char<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Person<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>surname<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>city<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>2*> type that contains a public <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> property of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and an <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>foreach<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>into<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>group<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>2*>   
 \<xref:System.Linq.Enumerable.GroupBy*>   
 \<xref:System.Linq.Enumerable.ThenBy*>   
 \<xref:System.Linq.Enumerable.ThenByDescending*>   
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [How To: Execute a Group Query and Enumerate Group Items](../vs140/how-to--create-a-nested-group--csharp-programming-guide-.md)   
 [How To: Group Results in Various Ways (LINQ)](../vs140/how-to--group-query-results--csharp-programming-guide-.md)   
 [How to: Perform a Subquery on a Grouping Operation (C# Programming Guide)](../vs140/how-to--perform-a-subquery-on-a-grouping-operation--csharp-programming-guide-.md)