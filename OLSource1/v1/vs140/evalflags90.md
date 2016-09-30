---
title: "EVALFLAGS90"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "EVALFLAGS90 enumeration"
ms.assetid: 64fb0139-8b04-4726-b52c-db2e04d65498
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# EVALFLAGS90
Enumerates the valid values for flags that control expression evaluation. This enumeration extends the [EVALFLAGS](../vs140/evalflags.md) enumeration.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 EVAL90_RETURNVALUE  
 Specifies that the return value, if any, be evaluated.  
  
 EVAL90_NOSIDEEFFECTS  
 Specifies that side effects not be allowed.  
  
 EVAL90_ALLOWBPS  
 Specifies stopping on breakpoints.  
  
 EVAL90_ALLOWERRORREPORT  
 Specifies that error reporting to the host to be allowed. Primarily used for expression evaluation in script in Internet Explorer.  
  
 EVAL90_FUNCTION_AS_ADDRESS  
 Forces functions to be evaluated as addresses, instead of invoking the function.  
  
 EVAL90_NOFUNCEVAL  
 Prevents function from being evaluated. For example, consider the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> token in the expression <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This function can be correctly evaluated as an address, but not as a value.  
  
 EVAL90_NOEVENTS  
 Flag to indicate that events that occur during the expression evaluation should not be sent to the session debug manager (SDM) or to the IDE.  
  
 EVAL90_DESIGN_TIME_EXPR_EVAL  
 Enables design-time expression evaluation.  
  
 EVAL90_ALLOW_IMPLICIT_VARS  
 Allows implicit variable creation.  
  
 EVAL90_FORCE_EVALUATION_NOW  
 Forces evaluation to occur immediately. This is useful when servicing a request, such as a user request.  
  
## Requirements  
 Header: Msdbg90.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)