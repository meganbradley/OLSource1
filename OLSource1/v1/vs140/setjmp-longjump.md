---
title: "setjmp-longjump"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: setjmp/longjump
dev_langs: 
  - C++
ms.assetid: b0e21902-095d-4198-8f9a-b6326525721a
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# setjmp-longjump
When you include setjmpex.h or setjmp.h, all calls to [setjmp](../vs140/setjmp.md) or [longjmp](../vs140/longjmp.md) will result in an unwind that invokes destructors and finally calls.  This differs from x86, where including setjmp.h results in finally clauses and destructors not being invoked.  
  
 A call to `setjmp` preserves the current stack pointer, non-volatile registers, and MxCsr registers.  Calls to `longjmp` return to the most recent `setjmp` call site and resets the stack pointer, non-volatile registers, and MxCsr registers, back to the state as preserved by the most recent `setjmp` call.  
  
## See Also  
 [Calling Convention](../vs140/calling-convention.md)