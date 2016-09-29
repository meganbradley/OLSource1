---
title: "ASSERT (MFC)"
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
  - "AFX/ASSERT"
  - "ASSERT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ASSERT macro"
ms.assetid: 1e70902d-d58c-4e7b-9f69-2aeb6cbe476c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ASSERT (MFC)
Evaluates its argument.  
  
## Syntax  
  
```  
  
      ASSERT(  
   booleanExpression  
)  
```  
  
#### Parameters  
 `booleanExpression`  
 Specifies an expression (including pointer values) that evaluates to nonzero or 0.  
  
## Remarks  
 If the result is 0, the macro prints a diagnostic message and aborts the program. If the condition is nonzero, it does nothing.  
  
 The diagnostic message has the form  
  
 `assertion failed in file <name> in line <num>`  
  
 where *name* is the name of the source file, and *num* is the line number of the assertion that failed in the source file.  
  
 In the Release version of MFC, **ASSERT** does not evaluate the expression and thus will not interrupt the program. If the expression must be evaluated regardless of environment, use the **VERIFY** macro in place of **ASSERT**.  
  
> [!NOTE]
>  This function is available only in the Debug version of MFC.  
  
## Example  
 [!code[NVC_MFC_Utilities#44](../vs140/codesnippet/CPP/assert--mfc-_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [VERIFY](../vs140/verify.md)