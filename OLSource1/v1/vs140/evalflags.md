---
title: "EVALFLAGS"
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
  - "EVALFLAGS"
helpviewer_keywords: 
  - "EVALFLAGS enumeration"
ms.assetid: 7b2cb14a-511a-4fef-9e4f-308139719fba
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# EVALFLAGS
Specifies flags that control expression evaluation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 EVAL_RETURNVALUE  
 Specifies that the return value, if any, be evaluated.  
  
 EVAL_NOSIDEEFFECTS  
 Specifies that side effects not be allowed.  
  
 EVAL_ALLOWBPS  
 Specifies stopping on breakpoints.  
  
 EVAL_ALLOWERRORREPORT  
 Specifies error reporting to the host to be allowed. Primarily used for expression evaluation in script in Internet Explorer.  
  
 EVAL_FUNCTION_AS_ADDRESS  
 Forces functions to be evaluated as addresses, instead of invoking the function.  
  
 EVAL_NOFUNCEVAL  
 Prevents function from being evaluated. For example, consider the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> token in the expression <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This function can be correctly evaluated as an address, but not as a value.  
  
 EVAL_NOEVENTS  
 Flag to indicate that events that occur during the expression evaluation should not be sent to the session debug manager (SDM) or to the IDE.  
  
## Remarks  
 These flags are passed as an argument to the [EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md) and [EvaluateSync](../vs140/idebugexpression2--evaluatesync.md) methods.  
  
 These flags may be combined with a bitwise OR.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [EvaluateAsync](../vs140/idebugexpression2--evaluateasync.md)   
 [EvaluateSync](../vs140/idebugexpression2--evaluatesync.md)