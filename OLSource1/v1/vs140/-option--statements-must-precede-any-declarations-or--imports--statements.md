---
title: "&#39;Option&#39; statements must precede any declarations or &#39;Imports&#39; statements"
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
  - "vbc30627"
  - "bc30627"
helpviewer_keywords: 
  - "BC30627"
ms.assetid: 2ce0fcf2-80f4-47d3-a394-44e0aed456db
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Option&#39; statements must precede any declarations or &#39;Imports&#39; statements
`Option` statements should be the first non-comment statements in your source code.  
  
 **Error ID:** BC30627  
  
### To correct this error  
  
-   Move the `Option` statements to the top of the source code, immediately before `Imports` and `Namespace` statements.  
  
## See Also  
 [Option \<keyword> Statement](../vs140/option--keyword--statement.md)   
 [Option Compare Statement](../vs140/option-compare-statement.md)   
 [Option Explicit Statement](../vs140/option-explicit-statement--visual-basic-.md)   
 [Option Infer Statement](../vs140/option-infer-statement.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)