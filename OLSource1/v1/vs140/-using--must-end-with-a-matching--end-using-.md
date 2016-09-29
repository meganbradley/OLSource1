---
title: "&#39;Using&#39; must end with a matching &#39;End Using&#39;"
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
  - "vbc36008"
  - "bc36008"
helpviewer_keywords: 
  - "BC36008"
ms.assetid: 83269108-b169-40a6-bbcc-af1ac8fcfd67
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Using&#39; must end with a matching &#39;End Using&#39;
A `Using` statement occurs without a corresponding `End Using` statement.  
  
 An `End Using` statement must be used to end the `Using` block.  
  
 **Error ID:** BC36008  
  
### To correct this error  
  
1.  If this `Using` block is part of a set of nested `Using` blocks, make sure each block is properly terminated.  
  
2.  Add an `End Using` statement to the end of the `Using` block.  
  
## See Also  
 [Using Statement (Visual Basic)](../vs140/using-statement--visual-basic-.md)   
 [How to: Dispose of a System Resource](../vs140/how-to--dispose-of-a-system-resource--visual-basic-.md)