---
title: "IDebugBreakpointEvent2::EnumBreakpoints"
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
  - "IDebugBreakpointEvent2:::EnumBreakpoints"
helpviewer_keywords: 
  - "IDebugBreakpointEvent2:::EnumBreakpoints"
ms.assetid: 606a9625-ee43-4e84-9a47-af9a50d2d005
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointEvent2::EnumBreakpoints
Creates an enumerator for all the breakpoints that fired at the current code location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md) object that enumerates all the breakpoints associated with the current code location.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Not all breakpoints at a particular location may fire at a particular time (for example, a breakpoint with a condition will not fire until that condition is met).  
  
## See Also  
 [IDebugBreakpointEvent2](../vs140/idebugbreakpointevent2.md)   
 [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md)