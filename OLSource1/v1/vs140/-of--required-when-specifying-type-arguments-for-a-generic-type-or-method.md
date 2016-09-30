---
title: "&#39;Of&#39; required when specifying type arguments for a generic type or method"
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
  - "bc32093"
  - "vbc32093"
helpviewer_keywords: 
  - "BC32093"
ms.assetid: 9a1baf12-a4a4-442d-9baa-852ad30a956b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Of&#39; required when specifying type arguments for a generic type or method
A statement attempts to construct a type from a generic type, or call a generic method, without using an [Of](../vs140/of-clause--visual-basic-.md) clause.  
  
 The [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] syntax for generic types calls for the type parameters and type arguments to be introduced by the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> keyword. In addition, the type parameter list or type argument list must be enclosed within parentheses.  
  
 **Error ID:** BC32093  
  
### To correct this error  
  
-   Include the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword at the beginning of the type argument list, and enclose the entire list within parentheses.  
  
## See Also  
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [How to: Use a Generic Class](../vs140/how-to--use-a-generic-class--visual-basic-.md)