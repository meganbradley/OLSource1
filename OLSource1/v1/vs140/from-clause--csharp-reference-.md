---
title: "from clause (C# Reference)"
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
  - "from_CSharpKeyword"
  - "from"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "from clause [C#]"
  - "from keyword [C#]"
ms.assetid: 1aefd18c-1314-47f8-99ec-9bcefb09e699
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# from clause (C# Reference)
A query expression must begin with a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> clause. Additionally, a query expression can contain sub-queries, which also begin with a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause specifies the following:  
  
-   The data source on which the query or sub-query will be run.  
  
-   A local *range variable* that represents each element in the source sequence.  
  
 Both the range variable and the data source are strongly typed. The data source referenced in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause must have a type of \<xref:System.Collections.IEnumerable*>, <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*>.  
  
 In the following example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the data source and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the range variable. Note that both variables are strongly typed even through the [var](../vs140/var--csharp-reference-.md) keyword is used.  
  
 [!code[cscsrefQueryKeywords#1](../vs140/codesnippet/CSharp/from-clause--csharp-reference-_1.cs)]  
  
## The Range Variable  
 The compiler infers the type of the range variable when the data source implements <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>IEnumerable<Customer><CodeContentPlaceHolder>8\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>IEnumerable<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>num<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>select num<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>select num.ToString()<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>select n + 10<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>IEnumerable<Student><CodeContentPlaceHolder>16\</CodeContentPlaceHolder>Student<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>Student<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>List<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>from<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>from` clauses, see [How To: Perform Custom Join Operations](../vs140/how-to--perform-custom-join-operations--csharp-programming-guide-.md).  
  
## See Also  
 [Query Keywords (C# Reference)](../vs140/query-keywords--csharp-reference-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)