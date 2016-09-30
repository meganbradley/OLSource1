---
title: "IDebugThread2::CanSetNextStatement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugThread2::CanSetNextStatement"
helpviewer_keywords: 
  - "IDebugThread2::CanSetNextStatement"
ms.assetid: 7014af80-ff4f-4790-a34b-0528918d1fa3
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugThread2::CanSetNextStatement
Determines whether the current instruction pointer can be set to the given stack frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reserved for future use; set to a null value. If this is a null value, use the current stack frame.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An [IDebugCodeContext2](../vs140/idebugcodecontext2.md) object that describes the code location about to be executed and its context.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 If this method returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, then call the [IDebugThread2::SetNextStatement](../vs140/idebugthread2--setnextstatement.md) method to actually set the next statement.  
  
## See Also  
 [IDebugThread2](../vs140/idebugthread2.md)   
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)   
 [IDebugCodeContext2](../vs140/idebugcodecontext2.md)   
 [IDebugThread2::SetNextStatement](../vs140/idebugthread2--setnextstatement.md)