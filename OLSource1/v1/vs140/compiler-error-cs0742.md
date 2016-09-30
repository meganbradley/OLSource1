---
title: "Compiler Error CS0742"
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
  - "CS0742"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0742"
ms.assetid: 078ee7af-17e4-4572-8fee-d97e09c9002b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0742
A query body must end with a select clause or a group clause  
  
 A query expression must terminate with either a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause or a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause without a continuation.  
  
### To correct this error  
  
1.  Add a [select clause](../vs140/select-clause--csharp-reference-.md) or [group clause](../vs140/group-clause--csharp-reference-.md) to the query.  
  
## Example  
 The following code generates CS0742:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause uses the [into](../vs140/into--csharp-reference-.md) keyword to store the results of the grouping into a temporary identifier, it cannot be the last clause in a query. A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or second <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause is still required.  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)