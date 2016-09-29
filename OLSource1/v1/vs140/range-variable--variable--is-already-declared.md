---
title: "Range variable &lt;variable&gt; is already declared"
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
  - "vbc36600"
  - "bc36600"
helpviewer_keywords: 
  - "BC36600"
ms.assetid: d53da04d-cd36-44ec-8b23-48cd81231191
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Range variable &lt;variable&gt; is already declared
A range variable name specified in a `Select` clause, or the `Into` part of an `Aggregate`, `Group By`, or `Group Join` clause, duplicates the name of a range variable already specified in the query clause.  
  
 **Error ID:** BC36600  
  
### To correct this error  
  
1.  Ensure that all range variables in a query clause have unique names.  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Aggregate Clause (Visual Basic)](../vs140/aggregate-clause--visual-basic-.md)   
 [Select Clause (Visual Basic)](../vs140/select-clause--visual-basic-.md)   
 [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md)   
 [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md)