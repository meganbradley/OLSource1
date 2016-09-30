---
title: "Option Strict On requires that all method parameters have an &#39;As&#39; clause"
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
  - "vbc30211"
  - "bc30211"
helpviewer_keywords: 
  - "BC30211"
ms.assetid: 855795ce-8499-4525-a1de-cbb8ba364cd7
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option Strict On requires that all method parameters have an &#39;As&#39; clause
A method contains a parameter without an `As` clause. When `Option Strict` is on, every variable, property, procedure argument, and function return must be declared with an `As` clause to specify its data type; for example, `Sub GetData(ByVal filter As String)`.  
  
 **Error ID:** BC30211  
  
### To correct this error  
  
-   Check to see whether the `As` keyword is misspelled.  
  
-   Supply an `As` clause for the declared variable, or turn `Option Strict` off.  
  
## See Also  
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [Sub Statement (Visual Basic)](../vs140/sub-statement--visual-basic-.md)   
 [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md)