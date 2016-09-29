---
title: "IDebugBoundBreakpoint2"
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
  - "IDebugBoundBreakpoint2"
helpviewer_keywords: 
  - "IDebugBoundBreakpoint2 interface"
ms.assetid: df33c52e-ded2-48a0-951d-1f36c8fc922e
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBoundBreakpoint2
This interface represents a breakpoint that is bound to a code location.  
  
## Syntax  
  
```  
IDebugBoundBreakpoint2 : IUnknown  
```  
  
## Notes for Implementers  
 The debug engine (DE) implements this interface as part of its support for breakpoints.  
  
## Notes for Callers  
 A call to [IDebugPendingBreakpoint2::Bind](../vs140/idebugpendingbreakpoint2--bind.md) creates this interface. Calls to [IDebugBreakpointUnboundEvent2::GetBreakpoint](../vs140/idebugbreakpointunboundevent2--getbreakpoint.md) and [IEnumDebugBoundBreakpoints2::Next](../vs140/ienumdebugboundbreakpoints2--next.md) can also obtain This interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugBoundBreakpoint2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetPendingBreakpoint](../vs140/idebugboundbreakpoint2--getpendingbreakpoint.md)|Gets the pending breakpoint from which the specified bound breakpoint was created.|  
|[GetState](../vs140/idebugboundbreakpoint2--getstate.md)|Gets the state of this bound breakpoint.|  
|[GetHitCount](../vs140/idebugboundbreakpoint2--gethitcount.md)|Gets the current hit count for this bound breakpoint.|  
|[GetBreakpointResolution](../vs140/idebugboundbreakpoint2--getbreakpointresolution.md)|Gets the breakpoint resolution that describes this breakpoint.|  
|[Enable](../vs140/idebugboundbreakpoint2--enable.md)|Enables or disables the breakpoint.|  
|[SetHitCount](../vs140/idebugboundbreakpoint2--sethitcount.md)|Sets the hit count for this bound breakpoint.|  
|[SetCondition](../vs140/idebugboundbreakpoint2--setcondition.md)|Sets or changes the condition associated with this bound breakpoint.|  
|[SetPassCount](../vs140/idebugboundbreakpoint2--setpasscount.md)|Sets or change the pass count associated with this bound breakpoint.|  
|[Delete](../vs140/idebugboundbreakpoint2--delete.md)|Deletes the breakpoint.|  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [GetBreakpoint](../vs140/idebugbreakpointunboundevent2--getbreakpoint.md)   
 [Next](../vs140/ienumdebugboundbreakpoints2--next.md)   
 [IDebugPendingBreakpoint2::Bind](../vs140/idebugpendingbreakpoint2--bind.md)