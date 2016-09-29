---
title: "VERIFY"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VERIFY"
  - "AFX/VERIFY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VERIFY macro"
ms.assetid: 3e1ab4ee-cbc7-4290-a777-c92f42ce7b96
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VERIFY
In the Debug version of MFC, evaluates its argument.  
  
## Syntax  
  
```  
  
VERIFY(  
booleanExpression )  
```  
  
#### Parameters  
 `booleanExpression`  
 Specifies an expression (including pointer values) that evaluates to nonzero or 0.  
  
## Remarks  
 If the result is 0, the macro prints a diagnostic message and halts the program. If the condition is nonzero, it does nothing.  
  
 The diagnostic message has the form  
  
 `assertion failed in file <name> in line <num>`  
  
 where *name* is the name of the source file and *num* is the line number of the assertion that failed in the source file.  
  
 In the Release version of MFC, **VERIFY** evaluates the expression but does not print or interrupt the program. For example, if the expression is a function call, the call will be made.  
  
## Example  
 [!code[NVC_MFCDocView#198](../VS_csharp/codesnippet/CPP/verify_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [ASSERT](../VS_csharp/assert--mfc-.md)