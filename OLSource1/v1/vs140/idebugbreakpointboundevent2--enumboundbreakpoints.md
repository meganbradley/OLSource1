---
title: "IDebugBreakpointBoundEvent2::EnumBoundBreakpoints"
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
  - "IDebugBreakpointBoundEvent2::EnumBoundBreakpoints"
helpviewer_keywords: 
  - "IDebugBreakpointBoundEvent2::EnumBoundBreakpoints"
ms.assetid: 1f588feb-522e-488d-be92-7bc19b9e3688
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointBoundEvent2::EnumBoundBreakpoints
Creates an enumerator of breakpoints that were bound on this event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md) object that enumerates all the breakpoints bound from this event.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if there are no bound breakpoints; otherwise, returns an error code.  
  
## Remarks  
 The list of bound breakpoints is for those bound to this event and might not be the entire list of breakpoints bound from a pending breakpoint. To get a list of all breakpoints bound to a pending breakpoint, call the [IDebugBreakpointBoundEvent2::GetPendingBreakpoint](../vs140/idebugbreakpointboundevent2--getpendingbreakpoint.md) method to get the associated [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) object and then call the [IDebugPendingBreakpoint2::EnumBoundBreakpoints](../vs140/idebugpendingbreakpoint2--enumboundbreakpoints.md) method to get an [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md) object which contains all the bound breakpoints for the pending breakpoint.  
  
## Example  
 The following example shows how to implement this method for a **CBreakpointSetDebugEventBase** object that exposes the [IDebugBreakpointBoundEvent2](../vs140/idebugbreakpointboundevent2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointBoundEvent2](../vs140/idebugbreakpointboundevent2.md)   
 [IEnumDebugBoundBreakpoints2](../vs140/ienumdebugboundbreakpoints2.md)   
 [IDebugBreakpointBoundEvent2::GetPendingBreakpoint](../vs140/idebugbreakpointboundevent2--getpendingbreakpoint.md)   
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)   
 [IDebugPendingBreakpoint2::EnumBoundBreakpoints](../vs140/idebugpendingbreakpoint2--enumboundbreakpoints.md)