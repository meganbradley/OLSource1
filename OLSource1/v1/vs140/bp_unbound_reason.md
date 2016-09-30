---
title: "BP_UNBOUND_REASON"
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
  - "BP_UNBOUND_REASON"
helpviewer_keywords: 
  - "BP_UNBOUND_REASON enumeration"
ms.assetid: 939b6f9c-113b-471d-9f30-b03871af6285
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_UNBOUND_REASON
Gives the reason a breakpoint was unbound.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 BPUR_UNKNOWN  
 The reason is unknown.  
  
 BPUR_CODE_UNLOADED  
 The code that contains the breakpoint has been unloaded.  
  
 BPUR_BREAKPOINT_REBIND  
 The breakpoint has been rebound to a different location. This can happen after Edit and Continue operations when the breakpoint moves, or when the breakpoint is bound to a file with a path that is no longer valid.  
  
 BPUR_ BREAKPOINT_ERROR  
 The breakpoint is determined to be in error after it is bound. This happens to managed breakpoints whose conditions are no longer valid.  
  
## Remarks  
 Returned by the [GetReason](../vs140/idebugbreakpointunboundevent2--getreason.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [GetReason](../vs140/idebugbreakpointunboundevent2--getreason.md)