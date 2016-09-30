---
title: "Cannot set the value of a local variable for a method that is not at the top of the stack"
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
  - "bc30711"
  - "vbc30711"
helpviewer_keywords: 
  - "BC30711"
ms.assetid: b2aa290f-3311-448a-af46-ff2a2add5788
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Cannot set the value of a local variable for a method that is not at the top of the stack
You can only modify variables if they are the top of the call stack. For example, if `procedure1` calls `procedure2` and you are in `procedure1`, you cannot modify variables in `procedure2`.  
  
 **Error ID:** BC30711  
  
### To correct this error  
  
-   Modify variables that are at the top of the call stack.  
  
## See Also  
 [Debugging in Visual Studio](../vs140/debugging-in-visual-studio.md)