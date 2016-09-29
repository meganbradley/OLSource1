---
title: "Function evaluation is disabled because a previous function evaluation timed out"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc30957"
  - "vbc30957"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30957"
ms.assetid: 561e593a-f50a-4b72-a708-4cab60ec7b28
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function evaluation is disabled because a previous function evaluation timed out
Function evaluation is disabled because a previous function evaluation timed out. To re-enable function evaluation, step again or restart debugging.  
  
 In the Visual Studio debugger, an expression specifies a procedure call, but another evaluation has timed out.  
  
 Possible causes for a procedure call to time out include an infinite loop or *endless loop*. For more information, see [For...Next Statement (Visual Basic)](../vs140/for...next-statement--visual-basic-.md).  
  
 A special case of an infinite loop is *recursion*. For more information, see [Recursive Procedures](../vs140/recursive-procedures--visual-basic-.md).  
  
 **Error ID:** BC30957  
  
### To correct this error  
  
1.  If possible, determine what the previous function evaluation was and what caused it to time out. Otherwise, you might encounter this error again.  
  
2.  Either step the debugger again, or terminate and restart debugging.  
  
## See Also  
 [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md)   
 [Start, Break, Step, Run through Code, and Stop Debugging in Visual Studio](../vs140/navigating-through-code-with-the-debugger.md)   
 [Expressions in Visual Basic](../vs140/expressions-in-visual-basic.md)