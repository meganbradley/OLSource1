---
title: "IDebugBreakpointUnboundEvent2::GetBreakpoint"
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
  - "IDebugBreakpointUnboundEvent2::GetBreakpoint"
helpviewer_keywords: 
  - "IDebugBreakpointUnboundEvent2::GetBreakpoint"
ms.assetid: ad73a207-b778-4dc5-b645-5ec668a63333
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointUnboundEvent2::GetBreakpoint
Gets the breakpoint that became unbound.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md) object that represents the breakpoint that became unbound.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CBreakpointUnboundDebugEventBase** object that exposes the [IDebugBreakpointUnboundEvent2](../vs140/idebugbreakpointunboundevent2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointUnboundEvent2](../vs140/idebugbreakpointunboundevent2.md)   
 [IDebugBoundBreakpoint2](../vs140/idebugboundbreakpoint2.md)