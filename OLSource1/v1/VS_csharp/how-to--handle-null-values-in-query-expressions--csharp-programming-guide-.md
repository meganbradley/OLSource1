---
title: "How to: Handle Null Values in Query Expressions (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "query expressions [LINQ in C#], null values"
  - "null values [LINQ in C#]"
  - "queries [LINQ in C#], null values"
ms.assetid: cb34f7a1-7ef5-466a-90ba-91da30ab525d
caps.latest.revision: 6
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Handle Null Values in Query Expressions (C# Programming Guide)
This example shows how to handle possible null values in source collections. An object collection such as an <xref:System.Collections.Generic.IEnumerable`1> can contain elements whose value is [null](../VS_csharp/null--csharp-reference-.md). If a source collection is null or contains an element whose value is null, and your query does not handle null values, a <xref:System.NullReferenceException> will be thrown when you execute the query.  
  
## Example  
 You can code defensively to avoid a null reference exception as shown in the following example:  
  
 [!code[csProgGuideLINQ#82](../VS_csharp/codesnippet/CSharp/how-to--handle-null-values-in-query-expressions--csharp-programming-guide-_1.cs)]  
  
 In the previous example, the `where` clause filters out all null elements in the categories sequence. This technique is independent of the null check in the join clause. The conditional expression with null in this example works because `Products.CategoryID` is of type `int?` which is shorthand for `Nullable<int>`.  
  
## Example  
 In a join clause, if only one of the comparison keys is a nullable value type, you can cast the other to a nullable type in the query expression. In the following example, assume that `EmployeeID` is a column that contains values of type `int?`:  
  
 [!code[csProgGuideLINQ#83](../VS_csharp/codesnippet/CSharp/how-to--handle-null-values-in-query-expressions--csharp-programming-guide-_2.cs)]  
  
## See Also  
 <xref:System.Nullable`1>   
 [LINQ Query Expressions](../VS_csharp/linq-query-expressions--csharp-programming-guide-.md)   
 [Nullable Types](../VS_csharp/nullable-types--csharp-programming-guide-.md)