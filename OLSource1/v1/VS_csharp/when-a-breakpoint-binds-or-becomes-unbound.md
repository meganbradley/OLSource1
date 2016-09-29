---
title: "When a Breakpoint Binds or Becomes Unbound"
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
  - "debugging [Debugging SDK], breakpoint unbound events"
  - "breakpoint bound events"
ms.assetid: 61bf00b2-8293-49d3-b919-1efb0dec9151
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# When a Breakpoint Binds or Becomes Unbound
When a breakpoint cannot be bound at the time a call is made to the [IDebugPendingBreakpoint2::CanBind](../VS_csharp/idebugpendingbreakpoint2--canbind.md) method, the bind time and create time of the breakpoint are different.  
  
## Methods Called  
 The session debug manager (SDM) calls the following methods:  
  
1.  [IDebugEngine2::CreatePendingBreakpoint](../VS_csharp/idebugengine2--creatependingbreakpoint.md). The DE returns an [IDebugPendingBreakpoint2](../VS_csharp/idebugpendingbreakpoint2.md).  
  
2.  [IDebugPendingBreakpoint2::Enable](../VS_csharp/idebugpendingbreakpoint2--enable.md).  
  
3.  [IDebugPendingBreakpoint2::Virtualize](../VS_csharp/idebugpendingbreakpoint2--virtualize.md).  
  
4.  The [IDebugPendingBreakpoint2::Bind](../VS_csharp/idebugpendingbreakpoint2--bind.md) method and returns S_OK. The DE sends an [IDebugBreakpointBoundEvent2](../VS_csharp/idebugbreakpointboundevent2.md) or [IDebugBreakpointErrorEvent2](../VS_csharp/idebugbreakpointerrorevent2.md).  
  
5.  [IDebugBreakpointBoundEvent2::GetPendingBreakpoint](../VS_csharp/idebugbreakpointboundevent2--getpendingbreakpoint.md) and [IDebugBreakpointBoundEvent2::EnumBoundBreakpoints](../VS_csharp/idebugbreakpointboundevent2--enumboundbreakpoints.md) methods to verify and to get the bound breakpoints.  
  
## See Also  
 [Calling Debugger Events](../VS_csharp/calling-debugger-events.md)